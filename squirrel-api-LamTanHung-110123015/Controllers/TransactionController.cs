using Microsoft.AspNetCore.Mvc;
using squirrel_api_LamTanHung_110123015.Models;
using System.Collections.Generic;
using System.Linq;

namespace squirrel_api_LamTanHung_110123015.Controllers
{
    [ApiController]
    [Route("api/giaodich")]
    public class TransactionController : ControllerBase
    {
        // Mục 3: Khởi tạo cứng dữ liệu vào mã nguồn
        private readonly List<Transaction> _transactions = new List<Transaction>
        {
            new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 4, SoTaiKhoan = "1098765432", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
        };

        // Mục 4: Viết API GET
        [HttpGet]
        public IActionResult GetNapTien()
        {
            var danhSachNapTien = _transactions.Where(t => t.LoaiGiaoDich == "Nap tien").ToList();
            return Ok(danhSachNapTien);
        }
    }
}