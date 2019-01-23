namespace AWSSDK.DynamoDBv2.CoreCLR.Custom.DataModel {
    /// <summary>
    /// A strongly-typed object for retrieving search results (Query or Scan)
    /// from DynamoDB.
    /// </summary>
    public partial interface IAsyncSearch<T>
    {
        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        bool IsDone { get; }
    }
}