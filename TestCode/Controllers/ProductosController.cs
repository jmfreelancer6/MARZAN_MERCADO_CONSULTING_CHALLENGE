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
    public class ProductosController : Controller
    {
        private IBaseRepository<tbl_Productos> _producto = new RepositoryProductos();
        private readonly IMapper _mapper;
        public ProductosController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: ProductosController
        public ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<ProductosDTO>>(_producto.GetAll()));
        }

        // GET: ProductosController/Details/5
        public ActionResult Details(int id)
        {
            return View(_mapper.Map<ProductosDTO>(_producto.Obtener(id)));
        }

        // GET: ProductosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductosDTO collection)
        {
            try
            {
                _producto.Agregar(_mapper.Map<tbl_Productos>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_mapper.Map<ProductosDTO>(_producto.Obtener(id)));
        }

        // POST: ProductosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductosDTO collection)
        {
            try
            {
                _producto.Editar(_mapper.Map<tbl_Productos>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_mapper.Map<ProductosDTO>(_producto.Obtener(id)));
        }

        // POST: ProductosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductosDTO collection)
        {
            try
            {
                _producto.Eliminar(_mapper.Map<tbl_Productos>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
