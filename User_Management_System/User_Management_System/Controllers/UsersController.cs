using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using User_Management_System.Database;
using User_Management_System.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace User_Management_System.Controllers
{
    public class UsersController : Controller
    {
        private readonly UMSContext _context;

        public UsersController(UMSContext context)
        {
            _context = context;
        }

        //GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }

        //POST: Users/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(include: "Email, Password")]Users users)
        {
            if (ModelState.IsValid)
            {
                Users u = _context.Users.SingleOrDefault(u => u.Email == users.Email);
                string inputHash = BCrypt.Net.BCrypt.HashPassword(users.Password, u.Salt);
                if (u == null || inputHash != u.HashPassword)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    //Set the value into a session key
                    HttpContext.Session.SetString("UsersSession", JsonConvert.SerializeObject(u));
                    string uID = u.ID.ToString();
                    return RedirectToAction("Homepage");
                }
            }

            return View(users);
        }

        //GET: Users/Login
        public IActionResult Logout() {
            HttpContext.Session.Remove("UsersSession");
            return RedirectToAction("Login");
        }

        //Get: Users/Homepage
        public IActionResult Homepage()
        {
            var user = JsonConvert.DeserializeObject<Users>(HttpContext.Session.GetString("UsersSession"));
            ViewBag.UsersName = user.FirstName;
            return View();
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details
        public IActionResult Details()
        {
            var user = JsonConvert.DeserializeObject<Users>(HttpContext.Session.GetString("UsersSession"));

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,HashPassword,FirstName,LastName,DOB,ProfilePicture,Salt,Password")] Users users)
        {
            if (ModelState.IsValid)
            {
                users.Salt = BCrypt.Net.BCrypt.GenerateSalt();
                users.HashPassword = BCrypt.Net.BCrypt.HashPassword(users.Password, users.Salt);
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Users/Edit/5
        public IActionResult Edit()
        {
            var user = JsonConvert.DeserializeObject<Users>(HttpContext.Session.GetString("UsersSession"));
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Email,FirstName,LastName,DOB,ProfilePicture,Password")] Users users)
        {
            //get user from db using id of logged in user via session
            var user = _context.Users.SingleOrDefault(u => u.ID == JsonConvert.DeserializeObject<Users>(HttpContext.Session.GetString("UsersSession")).ID);

            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.Email = users.Email;
                    user.FirstName = users.FirstName;
                    user.LastName = users.LastName;
                    user.DOB = users.DOB;
                    user.ProfilePicture = users.ProfilePicture;

                    user.Salt = BCrypt.Net.BCrypt.GenerateSalt();
                    user.HashPassword = BCrypt.Net.BCrypt.HashPassword(users.Password, user.Salt);
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }
    }
}
