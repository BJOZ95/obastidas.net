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

namespace obastidast.Controllers.contabilidad
{
    public class CON_DIARIO_AUX_TIPOController : Controller
    {
        private EntitiesEmpresa db = new EntitiesEmpresa();

        // GET: CON_DIARIO_AUX_TIPO
        public async Task<ActionResult> Index()
        {
            var cON_DIARIO_AUX_TIPO = db.CON_DIARIO_AUX_TIPO.Include(c => c.SEG_ESTADO_AI).Include(c => c.SEG_USUARIO).Include(c => c.SEG_USUARIO1);
            return View(await cON_DIARIO_AUX_TIPO.ToListAsync());
        }

        // GET: CON_DIARIO_AUX_TIPO/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO = await db.CON_DIARIO_AUX_TIPO.FindAsync(id);
            if (cON_DIARIO_AUX_TIPO == null)
            {
                return HttpNotFound();
            }
            return View(cON_DIARIO_AUX_TIPO);
        }

        // GET: CON_DIARIO_AUX_TIPO/Create
        public ActionResult Create()
        {
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion");
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            return View();
        }

        // POST: CON_DIARIO_AUX_TIPO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Con_AuxTipo_Id,Con_Aux_Descripcion,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO)
        {
            if (ModelState.IsValid)
            {
                db.CON_DIARIO_AUX_TIPO.Add(cON_DIARIO_AUX_TIPO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cON_DIARIO_AUX_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Modifica);
            return View(cON_DIARIO_AUX_TIPO);
        }

        // GET: CON_DIARIO_AUX_TIPO/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO = await db.CON_DIARIO_AUX_TIPO.FindAsync(id);
            if (cON_DIARIO_AUX_TIPO == null)
            {
                return HttpNotFound();
            }
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cON_DIARIO_AUX_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Modifica);
            return View(cON_DIARIO_AUX_TIPO);
        }

        // POST: CON_DIARIO_AUX_TIPO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Con_AuxTipo_Id,Con_Aux_Descripcion,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cON_DIARIO_AUX_TIPO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cON_DIARIO_AUX_TIPO.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cON_DIARIO_AUX_TIPO.Aud_Usuario_Modifica);
            return View(cON_DIARIO_AUX_TIPO);
        }

        // GET: CON_DIARIO_AUX_TIPO/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO = await db.CON_DIARIO_AUX_TIPO.FindAsync(id);
            if (cON_DIARIO_AUX_TIPO == null)
            {
                return HttpNotFound();
            }
            return View(cON_DIARIO_AUX_TIPO);
        }

        // POST: CON_DIARIO_AUX_TIPO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CON_DIARIO_AUX_TIPO cON_DIARIO_AUX_TIPO = await db.CON_DIARIO_AUX_TIPO.FindAsync(id);
            db.CON_DIARIO_AUX_TIPO.Remove(cON_DIARIO_AUX_TIPO);
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
