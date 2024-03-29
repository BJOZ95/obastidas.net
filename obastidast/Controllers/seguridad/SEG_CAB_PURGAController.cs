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

namespace obastidast.Controllers.seguridad
{
    public class SEG_CAB_PURGAController : Controller
    {
        private EntitiesEmpresa db = new EntitiesEmpresa();

        // GET: SEG_CAB_PURGA
        public async Task<ActionResult> Index()
        {
            var sEG_CAB_PURGA = db.SEG_CAB_PURGA.Include(s => s.SEG_EMPRESA).Include(s => s.SEG_ESTADO_AI).Include(s => s.SEG_USUARIO).Include(s => s.SEG_USUARIO1);
            return View(await sEG_CAB_PURGA.ToListAsync());
        }

        // GET: SEG_CAB_PURGA/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_CAB_PURGA sEG_CAB_PURGA = await db.SEG_CAB_PURGA.FindAsync(id);
            if (sEG_CAB_PURGA == null)
            {
                return HttpNotFound();
            }
            return View(sEG_CAB_PURGA);
        }

        // GET: SEG_CAB_PURGA/Create
        public ActionResult Create()
        {
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante");
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion");
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            return View();
        }

        // POST: SEG_CAB_PURGA/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SEG_CAB_PURGA_Id,EMP_Id_Empresa,CAB_Id_Purga,USU_Login,CAB_Fecha,CAB_Tabla,CAB_Modulo,USU_Elim,USU_Fecelim,USU_Con,USU_Feccon,USU_Rep,USU_Fecrep,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] SEG_CAB_PURGA sEG_CAB_PURGA)
        {
            if (ModelState.IsValid)
            {
                db.SEG_CAB_PURGA.Add(sEG_CAB_PURGA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_CAB_PURGA.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_CAB_PURGA.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Modifica);
            return View(sEG_CAB_PURGA);
        }

        // GET: SEG_CAB_PURGA/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_CAB_PURGA sEG_CAB_PURGA = await db.SEG_CAB_PURGA.FindAsync(id);
            if (sEG_CAB_PURGA == null)
            {
                return HttpNotFound();
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_CAB_PURGA.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_CAB_PURGA.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Modifica);
            return View(sEG_CAB_PURGA);
        }

        // POST: SEG_CAB_PURGA/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SEG_CAB_PURGA_Id,EMP_Id_Empresa,CAB_Id_Purga,USU_Login,CAB_Fecha,CAB_Tabla,CAB_Modulo,USU_Elim,USU_Fecelim,USU_Con,USU_Feccon,USU_Rep,USU_Fecrep,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] SEG_CAB_PURGA sEG_CAB_PURGA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sEG_CAB_PURGA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_CAB_PURGA.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_CAB_PURGA.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_CAB_PURGA.Aud_Usuario_Modifica);
            return View(sEG_CAB_PURGA);
        }

        // GET: SEG_CAB_PURGA/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_CAB_PURGA sEG_CAB_PURGA = await db.SEG_CAB_PURGA.FindAsync(id);
            if (sEG_CAB_PURGA == null)
            {
                return HttpNotFound();
            }
            return View(sEG_CAB_PURGA);
        }

        // POST: SEG_CAB_PURGA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SEG_CAB_PURGA sEG_CAB_PURGA = await db.SEG_CAB_PURGA.FindAsync(id);
            db.SEG_CAB_PURGA.Remove(sEG_CAB_PURGA);
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
