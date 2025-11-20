namespace AWSSDK.S3.Transfer.Model
{
    /// <summary>
    /// Overall outcome of a directory operation.
    /// </summary>
    public enum DirectoryResult
    {
        /// <summary>
        /// All objects processed successfully.
        /// </summary>
        Success,
        /// <summary>
        /// Some objects succeeded and some failed.
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// All attempted objects failed.
        /// </summary>
        Failure
    }
}