namespace AccessMS.Entities;

public class UserEntity {
    public virtual long Id { get; set; }
    public virtual string Name { get; set; } = string.Empty;
    public virtual DateTime BirthDate { get; set; } = new DateTime();
    public virtual string CPF { get; set; } = string.Empty;
    public virtual string Cellphone { get; set; } = string.Empty;
    public virtual string Email { get; set; } = string.Empty;
    public virtual string UserName { get; set; } = string.Empty;
    public virtual string Password { get; set; } = string.Empty;
}