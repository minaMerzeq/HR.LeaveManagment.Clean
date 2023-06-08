namespace HR.LeaveManagment.Domain.Common;

// abstract will allow inheritance but prevent creating instance from it
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
}
