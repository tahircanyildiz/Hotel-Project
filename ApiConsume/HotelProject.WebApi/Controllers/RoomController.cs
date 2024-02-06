using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService staffService)
        {
            _roomService = staffService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddRoom(Room staff)
        {
            _roomService.TInsert(staff);
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room staff)
        {
            _roomService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }


    }
}
