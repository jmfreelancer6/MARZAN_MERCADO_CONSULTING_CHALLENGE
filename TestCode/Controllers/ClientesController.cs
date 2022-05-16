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
    public class ClientesController : Controller
    {
        private IBaseRepository<tbl_Clientes> _cliente = new RepositoryClientes();
        private readonly IMapper _mapper;
        public ClientesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: ClientesController
        public ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<ClientesDTO>>(_cliente.GetAll()));
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_mapper.Map<ClientesDTO>(_cliente.Obtener(id)));
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientesDTO collection)
        {
            try
            {
                _cliente.Agregar(_mapper.Map<tbl_Clientes>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_mapper.Map<ClientesDTO>(_cliente.Obtener(id)));
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClientesDTO collection)
        {
            try
            {
                _cliente.Editar(_mapper.Map<tbl_Clientes>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_mapper.Map<ClientesDTO>(_cliente.Obtener(id)));
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClientesDTO collection)
        {
            try
            {
                _cliente.Eliminar(_mapper.Map<tbl_Clientes>(collection));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
