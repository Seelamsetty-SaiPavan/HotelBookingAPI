using System.ComponentModel.DataAnnotations;

namespace HotelBookingAPI.DTOs.RoomTypeDTOs
{
    public class CreateRoomTypeDTO
    {
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string AccessibilityFeatures { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
