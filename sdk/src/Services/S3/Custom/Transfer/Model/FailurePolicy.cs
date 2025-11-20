namespace AWSSDK.S3.Transfer.Model
{
    /// <summary>
    /// Specifies the policy to apply when a failure occurs during a directory transfer operation.
    /// </summary>
    public enum FailurePolicy
    {
        /// <summary>
        /// Abort the directory transfer operation on failure.
        /// </summary>
        ABORT_ON_FAILURE,

        /// <summary>
        /// Continue the directory transfer operation despite failures.
        /// </summary>
        CONTINUE_ON_FAILURE
    }
}
