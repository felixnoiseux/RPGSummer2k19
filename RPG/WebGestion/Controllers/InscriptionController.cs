using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebGestion.Model.Inscription;
using WebGestion.Class;

namespace WebGestion.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        public IConfiguration Configuration { get; }
        public InscriptionController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inscription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inscription/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InscriptionModel inscriptionModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string Salt = Securite.GetSalt();
                        string EncryptedPassword = Securite.GenerateSHA256String(inscriptionModel.Password + Salt);
                        EncryptedPassword += ":" + Salt;

                        string sql = $"Insert Into dbo.Utilisateur (TypeUtilisateurID, Prenom, Nom, Inscription, Courriel, MotDePasse, Username) Values ('1', '{inscriptionModel.Prenom}','{inscriptionModel.Nom}',GETDATE(),'{inscriptionModel.Courriel}','{EncryptedPassword}','{inscriptionModel.Username}')";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        return Redirect("/Home");
                    }
                }
                else
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inscription/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inscription/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}