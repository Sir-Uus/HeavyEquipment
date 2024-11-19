namespace Application.Dtos
{
    public class MaintenanceRecordDto
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string ServicedPerformed { get; set; }
        public string ServicedProvider { get; set; }
        public decimal Cost { get; set; }
        public DateTime NextMaintenanceDue { get; set; }
    }
}
