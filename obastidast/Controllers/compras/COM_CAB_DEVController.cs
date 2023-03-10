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
    public class COM_CAB_DEVController : Controller
    {
        private EntitiesEmpresa db = new EntitiesEmpresa();

        // GET: COM_CAB_DEV
        public async Task<ActionResult> Index()
        {
            var cOM_CAB_DEV = db.COM_CAB_DEV.Include(c => c.SEG_EMPRESA).Include(c => c.SEG_ESTADO_AI).Include(c => c.SEG_USUARIO).Include(c => c.SEG_USUARIO1);
            return View(await cOM_CAB_DEV.ToListAsync());
        }

        // GET: COM_CAB_DEV/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_CAB_DEV cOM_CAB_DEV = await db.COM_CAB_DEV.FindAsync(id);
            if (cOM_CAB_DEV == null)
            {
                return HttpNotFound();
            }
            return View(cOM_CAB_DEV);
        }

        // GET: COM_CAB_DEV/Create
        public ActionResult Create()
        {
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante");
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion");
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login");
            return View();
        }

        // POST: COM_CAB_DEV/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CAB_Devolucion_Id,EMP_Id_Empresa,CAB_Id_Orden,CAB_Id_PPersona,CAB_Id_EPersona,CAB_FechaCompra,CAB_FechaDevolucion,CAB_Observacion,CAB_Total,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] COM_CAB_DEV cOM_CAB_DEV)
        {
            if (ModelState.IsValid)
            {
                db.COM_CAB_DEV.Add(cOM_CAB_DEV);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", cOM_CAB_DEV.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cOM_CAB_DEV.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Modifica);
            return View(cOM_CAB_DEV);
        }

        // GET: COM_CAB_DEV/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_CAB_DEV cOM_CAB_DEV = await db.COM_CAB_DEV.FindAsync(id);
            if (cOM_CAB_DEV == null)
            {
                return HttpNotFound();
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", cOM_CAB_DEV.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cOM_CAB_DEV.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Modifica);
            return View(cOM_CAB_DEV);
        }

        // POST: COM_CAB_DEV/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CAB_Devolucion_Id,EMP_Id_Empresa,CAB_Id_Orden,CAB_Id_PPersona,CAB_Id_EPersona,CAB_FechaCompra,CAB_FechaDevolucion,CAB_Observacion,CAB_Total,Aud_EstadoAI_Id,Aud_Usuario_Ingreso,Aud_Fecha_Ingreso,Aud_PC_Ingreso,Aud_Usuario_Modifica,Aud_Fecha_Modifica,Aud_PC_Modifica")] COM_CAB_DEV cOM_CAB_DEV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cOM_CAB_DEV).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EMP_Id_Empresa = new SelectList(db.SEG_EMPRESA, "SEG_EMPRESA_Id", "EMP_Representante", cOM_CAB_DEV.EMP_Id_Empresa);
            ViewBag.Aud_EstadoAI_Id = new SelectList(db.SEG_ESTADO_AI, "Seg_EstadoAI_Id", "Gen_PrmSn_Descripcion", cOM_CAB_DEV.Aud_EstadoAI_Id);
            ViewBag.Aud_Usuario_Ingreso = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Ingreso);
            ViewBag.Aud_Usuario_Modifica = new SelectList(db.SEG_USUARIO, "Seg_Usr_Id", "USU_Login", cOM_CAB_DEV.Aud_Usuario_Modifica);
            return View(cOM_CAB_DEV);
        }

        // GET: COM_CAB_DEV/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COM_CAB_DEV cOM_CAB_DEV = await db.COM_CAB_DEV.FindAsync(id);
            if (cOM_CAB_DEV == null)
            {
                return HttpNotFound();
            }
            return View(cOM_CAB_DEV);
        }

        // POST: COM_CAB_DEV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            COM_CAB_DEV cOM_CAB_DEV = await db.COM_CAB_DEV.FindAsync(id);
            db.COM_CAB_DEV.Remove(cOM_CAB_DEV);
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
