using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
   public class RoomUpdateDto
    {
        public int RoomID { get; set; }
       
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız.")]
        public string RoomNumber { get; set; }
       
        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]
        public string RoomCoverImage { get; set; }
        
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }
        
        [Required(ErrorMessage = "Lütfen oda başlığı giriniz.")]
        public string Title { get; set; }
       
        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
        public string BadCount { get; set; }
       
        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
        public string BathCount { get; set; }
        
        [Required(ErrorMessage = "Lütfen wifi bilgisi giriniz.")]
        public string Wifi { get; set; }
       
        [Required(ErrorMessage = "Lütfen açıklama yazınız.")]
        public string Description { get; set; }
    }
}
