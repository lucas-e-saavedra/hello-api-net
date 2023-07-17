using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetEmployee")]
    public Employee Get(int id)
    {
        Employee oneEmployee = new Employee();
        oneEmployee.Id = id;
        oneEmployee.Name = "Name"+id;
        oneEmployee.Lastname = "Lastname"+id;
        oneEmployee.Email = "mail"+id+"@domain.com";
        return oneEmployee;
    }
}
