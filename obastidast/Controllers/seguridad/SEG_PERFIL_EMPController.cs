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
    public class SEG_PERFIL_EMPController : Controller
    {
        private EntitiesEmpresa db = new EntitiesEmpresa();

        // GET: SEG_PERFIL_EMP
        public async Task<ActionResult> Index()
        {
            var sEG_PERFIL_EMP = db.SEG_PERFIL_EMP.Include(s => s.SEG_EMPRESA).Include(s => s.SEG_ESTADO_AI).Include(s => s.SEG_USUARIO).Include(s => s.SEG_USUARIO1);
            return View(await sEG_PERFIL_EMP.ToListAsync());
        }

        // GET: SEG_PERFIL_EMP/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_PERFIL_EMP sEG_PERFIL_EMP = await db.SEG_PERFIL_EMP.FindAsync(id);
            if (sEG_PERFIL_EMP == null)
            {
                return HttpNotFound();
            }
            return View(sEG_PERFIL_EMP);
        }

        // GET: SEG_PERFIL_EMP/Create
        public ActionResult Create()
        {
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante");
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion");
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            return View();
        }

        // POST: SEG_PERFIL_EMP/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SEG_PERFIL_EMP_Id,EMP_Id_Empresa,PEM_Id_Perfil,PEM_Descripcion,PEM_Trm_i,PEM_Trm_m,PEM_Trm_e,PEM_Trm_c,PEM_Trm_r,PEM_Estado,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] SEG_PERFIL_EMP sEG_PERFIL_EMP)
        {
            if (ModelState.IsValid)
            {
                db.SEG_PERFIL_EMP.Add(sEG_PERFIL_EMP);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_PERFIL_EMP.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_PERFIL_EMP.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Modifica);
            return View(sEG_PERFIL_EMP);
        }

        // GET: SEG_PERFIL_EMP/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_PERFIL_EMP sEG_PERFIL_EMP = await db.SEG_PERFIL_EMP.FindAsync(id);
            if (sEG_PERFIL_EMP == null)
            {
                return HttpNotFound();
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_PERFIL_EMP.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_PERFIL_EMP.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Modifica);
            return View(sEG_PERFIL_EMP);
        }

        // POST: SEG_PERFIL_EMP/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SEG_PERFIL_EMP_Id,EMP_Id_Empresa,PEM_Id_Perfil,PEM_Descripcion,PEM_Trm_i,PEM_Trm_m,PEM_Trm_e,PEM_Trm_c,PEM_Trm_r,PEM_Estado,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] SEG_PERFIL_EMP sEG_PERFIL_EMP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sEG_PERFIL_EMP).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", sEG_PERFIL_EMP.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", sEG_PERFIL_EMP.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", sEG_PERFIL_EMP.Aud_Usuario_Modifica);
            return View(sEG_PERFIL_EMP);
        }

        // GET: SEG_PERFIL_EMP/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SEG_PERFIL_EMP sEG_PERFIL_EMP = await db.SEG_PERFIL_EMP.FindAsync(id);
            if (sEG_PERFIL_EMP == null)
            {
                return HttpNotFound();
            }
            return View(sEG_PERFIL_EMP);
        }

        // POST: SEG_PERFIL_EMP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SEG_PERFIL_EMP sEG_PERFIL_EMP = await db.SEG_PERFIL_EMP.FindAsync(id);
            db.SEG_PERFIL_EMP.Remove(sEG_PERFIL_EMP);
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
