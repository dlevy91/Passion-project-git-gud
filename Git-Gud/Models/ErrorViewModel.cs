using System;
using System.ComponentModel.DataAnnotations;

namespace Passion_project_git_gud.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
