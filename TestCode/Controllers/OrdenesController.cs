using AutoMapper;
using Domain.Core.Interface;
using Domain.Core.Models;
using Infraestructure.Data.AccessData;
using Infraestructure.Data.Persistent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestCode.Controllers
{
    [Authorize]
    public class OrdenesController : Controller
    {
        private IBaseRepository<Tbl_Ordenes> _ordenes = new RepositoryOrdenes();
        private IBaseRepository<tbl_Clientes> _clientes = new RepositoryClientes();
        private IBaseRepository<tbl_Productos> _producto = new RepositoryProductos();
        private readonly IMapper _mapper;
        public OrdenesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: OrdenesController
        public ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<OrdenesDTO>>(_ordenes.GetAll()));
        }

        public ActionResult ModalPartial()
        {
            ViewBag.ID_Cliente = _clientes.GetAll();
            ViewBag.Productos = _producto.GetAll();
            return View("/Views/Ordenes/ModalPartial.cshtml");
        }

        // GET: OrdenesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_mapper.Map<OrdenesDTO>(_ordenes.Obtener(id)));
        }

        // GET: OrdenesController/Create
        public ActionResult Create()
        {
            ViewBag.ID_Cliente = _clientes.GetAll();
            return View();
        }

        // POST: OrdenesController/Create
        [HttpPost]
        public ActionResult SaveOrder([FromForm] OrdenesDTO value)
        {
            try
            {
                _ordenes.Agregar(_mapper.Map<Tbl_Ordenes>(value));
                return Json("");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdenesController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ID_Cliente = _clientes.GetAll();
            return View(_mapper.Map<OrdenesDTO>(_ordenes.Obtener(id)));
        }

        // POST: OrdenesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrdenesDTO collection)
        {
            try
            {
                _ordenes.Editar(_mapper.Map<Tbl_Ordenes>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdenesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_mapper.Map<OrdenesDTO>(_ordenes.Obtener(id)));
        }

        // POST: OrdenesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, OrdenesDTO collection)
        {
            try
            {
                _ordenes.Eliminar(_mapper.Map<Tbl_Ordenes>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
