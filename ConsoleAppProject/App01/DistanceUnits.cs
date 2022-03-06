using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// List of units used to measure distance
    /// </summary>
    /// <author>
    /// Alastair Fox version 1.0
    /// </author>
    public enum DistanceUnits
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Feet,
        Metres,
        Kilometres,
        Miles
    }
}
