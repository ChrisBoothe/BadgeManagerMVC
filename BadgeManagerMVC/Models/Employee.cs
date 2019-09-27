namespace BadgeManagerMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Key]
        public System.Guid EmployeeGuid { get; set; }

        [Display(Name = "ID")]
        [Required(ErrorMessage = "ID is required.")]
        public int EmployeeNumber { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Display(Name = "Date of Hire")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Date of Hire is required.")]
        public System.DateTime HireDate { get; set; }

        [Display(Name = "Date of Termination")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> TerminationDate { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type is required.")]
        public EmployeeType Type { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required.")]
        public EmployeeStatus Status { get; set; }

        [Display(Name = "Shift")]
        [Required(ErrorMessage = "Shift is required.")]
        public EmployeeShift Shift { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department is required.")]
        public EmployeeDepartment Department { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
    }
}
