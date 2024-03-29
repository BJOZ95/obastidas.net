﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using obastidast.Database;

namespace obastidast.Controllers.nomina
{
    public class NOM_VENDEDOR_TIPOController : Controller
    {
        private EntitiesEmpresa db = new EntitiesEmpresa();

        // GET: NOM_VENDEDOR_TIPO
        public async Task<ActionResult> Index()
        {
            var nOM_VENDEDOR_TIPO = db.NOM_VENDEDOR_TIPO.Include(n => n.SEG_EMPRESA).Include(n => n.SEG_ESTADO_AI).Include(n => n.SEG_USUARIO).Include(n => n.SEG_USUARIO1);
            return View(await nOM_VENDEDOR_TIPO.ToListAsync());
        }

        // GET: NOM_VENDEDOR_TIPO/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO = await db.NOM_VENDEDOR_TIPO.FindAsync(id);
            if (nOM_VENDEDOR_TIPO == null)
            {
                return HttpNotFound();
            }
            return View(nOM_VENDEDOR_TIPO);
        }

        // GET: NOM_VENDEDOR_TIPO/Create
        public ActionResult Create()
        {
            ViewBag.SEG_EMPRESA_Id = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante");
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion");
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            return View();
        }

        // POST: NOM_VENDEDOR_TIPO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Nom_VendT_Id,SEG_EMPRESA_Id,Nom_VendT_Descripcion,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO)
        {
            if (ModelState.IsValid)
            {
                db.NOM_VENDEDOR_TIPO.Add(nOM_VENDEDOR_TIPO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SEG_EMPRESA_Id = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", nOM_VENDEDOR_TIPO.SEG_EMPRESA_Id);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", nOM_VENDEDOR_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Modifica);
            return View(nOM_VENDEDOR_TIPO);
        }

        // GET: NOM_VENDEDOR_TIPO/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO = await db.NOM_VENDEDOR_TIPO.FindAsync(id);
            if (nOM_VENDEDOR_TIPO == null)
            {
                return HttpNotFound();
            }
            ViewBag.SEG_EMPRESA_Id = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", nOM_VENDEDOR_TIPO.SEG_EMPRESA_Id);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", nOM_VENDEDOR_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Modifica);
            return View(nOM_VENDEDOR_TIPO);
        }

        // POST: NOM_VENDEDOR_TIPO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Nom_VendT_Id,SEG_EMPRESA_Id,Nom_VendT_Descripcion,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nOM_VENDEDOR_TIPO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SEG_EMPRESA_Id = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", nOM_VENDEDOR_TIPO.SEG_EMPRESA_Id);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", nOM_VENDEDOR_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", nOM_VENDEDOR_TIPO.Aud_Usuario_Modifica);
            return View(nOM_VENDEDOR_TIPO);
        }

        // GET: NOM_VENDEDOR_TIPO/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO = await db.NOM_VENDEDOR_TIPO.FindAsync(id);
            if (nOM_VENDEDOR_TIPO == null)
            {
                return HttpNotFound();
            }
            return View(nOM_VENDEDOR_TIPO);
        }

        // POST: NOM_VENDEDOR_TIPO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NOM_VENDEDOR_TIPO nOM_VENDEDOR_TIPO = await db.NOM_VENDEDOR_TIPO.FindAsync(id);
            db.NOM_VENDEDOR_TIPO.Remove(nOM_VENDEDOR_TIPO);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
