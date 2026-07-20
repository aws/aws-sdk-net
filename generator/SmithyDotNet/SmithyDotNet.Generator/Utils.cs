using System.Xml;

namespace SmithyDotNet.Generator;

/// <summary>
/// Miscellaneous generator helpers that don't belong to a specific writer or model type.
/// </summary>
public static class Utils
{
    /// <summary>
    /// A fresh project GUID in the braced, uppercase form MSBuild uses (e.g.
    /// <c>{A5484965-036F-4ECB-B738-D88AC002AA1C}</c>). Ported from the legacy generator's
    /// <c>Utils.NewProjectGuid</c>.
    /// </summary>
    public static string NewProjectGuid => Guid.NewGuid().ToString("B").ToUpperInvariant();

    /// <summary>
    /// Returns the <c>&lt;ProjectGuid&gt;</c> of the project at <paramref name="projectFilePath"/> so
    /// regeneration doesn't churn it, or a fresh <see cref="NewProjectGuid"/> when the file, its
    /// PropertyGroup, or the element is absent. Ported from the legacy generator's
    /// <c>Utils.GetProjectGuid</c>; the legacy <c>.xproj</c> special-case is dropped — every
    /// CodeAnalysis project is an SDK-style <c>.csproj</c> with a single PropertyGroup.
    /// </summary>
    public static string GetProjectGuid(string projectFilePath)
    {
        if (!File.Exists(projectFilePath))
        {
            return NewProjectGuid;
        }

        var document = new XmlDocument();
        document.Load(projectFilePath);

        var propertyGroups = document.GetElementsByTagName("PropertyGroup");
        if (propertyGroups.Count == 0 || propertyGroups[0] is not XmlElement propertyGroup)
        {
            return NewProjectGuid;
        }

        var guidElements = propertyGroup.GetElementsByTagName("ProjectGuid");
        if (guidElements.Count == 0 || guidElements[0] is not XmlElement guidElement)
        {
            return NewProjectGuid;
        }

        return guidElement.InnerText;
    }

    /// <summary>
    /// Forces the path to use the AltDirectorySeparatorChar even on Windows.
    /// </summary>
    /// <param name="segments">The path segments to join</param>
    /// <returns>The combined path.</returns>
    public static string PathCombineAlt(params string[] segments)
    {
        return ConvertPathAlt(Path.Combine(segments));
    }

    /// <summary>
    /// Converts path characters of Path.DirectorySeparatorChar to Path.AltDirectorySeparatorChar.
    /// </summary>
    /// <param name="path">The path to convert to use Path.AltDirectorySeparatorChar characters.</param>
    /// <returns>The converted path.</returns>
    public static string ConvertPathAlt(string path)
    {
        return path.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
    }
}
