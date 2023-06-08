using HR.LeaveManagment.Domain.Common;

// using ; will remove {} of the name space with no issues
namespace HR.LeaveManagment.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    // make it nullable to identify that it could be null
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    
    public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }

    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }

    public string RequestingEmployeeId { get; set; } = string.Empty;
}
