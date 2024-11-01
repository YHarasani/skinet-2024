using System;

namespace API.Errors;

public class ApiErrorResponse(int statuscode, string message, string? details)
{
    public int StatusCode { get; set; } = statuscode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;
}
