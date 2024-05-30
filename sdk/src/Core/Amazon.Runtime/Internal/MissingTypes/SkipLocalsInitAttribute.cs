#if !NET8_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates to the compiler that the .locals init flag should not be set in nested method headers when emitting to metadata.</summary>
    [AttributeUsage(AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Interface, Inherited = false)]
    internal sealed class SkipLocalsInitAttribute : Attribute
    {
    }
}
#endif