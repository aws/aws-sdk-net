using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Extension methods extending <seealso cref="IDynamoDBContext"/> with additional functionality.
    /// </summary>
    public static class DynamoDbContextExtensions
    {
        /// <summary>
        /// Serializes an object to a Document.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <remarks>In contrast to <see cref="IDynamoDBContext.ToDocument{T}(T)"/> this method bypassed any table loading, caching or validation against the table.</remarks>
        /// <returns>Document with attributes populated from object.</returns>
        public static Document ConvertToDocument<T>(this IDynamoDBContext dynamoDbContext, T value)
        {
            return dynamoDbContext.ConvertToDocument(value, new DynamoDBOperationConfig());
        }

        /// <summary>
        /// Serializes an object to a Document.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <param name="operationConfig">Config object which can be used to override conversion settings.</param>
        /// <remarks>In contrast to <see cref="IDynamoDBContext.ToDocument{T}(T)"/> this method bypassed any table loading, caching or validation against the table.</remarks>
        /// <returns>Document with attributes populated from object.</returns>
        public static Document ConvertToDocument<T>(this IDynamoDBContext dynamoDbContext, T value, DynamoDBOperationConfig operationConfig)
        {
            operationConfig.ConvertOnly = true;
            return dynamoDbContext.ToDocument(value, operationConfig);
        }

        /// <summary>
        /// Deserializes a document to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document">Document with properties to use.</param>
        /// <remarks>In contrast to <see cref="IDynamoDBContext.ToDocument{T}(T)"/> this method bypassed any table loading, caching or validation against the table.</remarks>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        public static T ConvertFromDocument<T>(this IDynamoDBContext dynamoDbContext, Document document)
        {
            return dynamoDbContext.ConvertFromDocument<T>(document, new DynamoDBOperationConfig());
        }

        /// <summary>
        /// Deserializes a document to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document">Document with properties to use.</param>
        /// <param name="operationConfig">Config object which can be used to override conversion settings.</param>
        /// <remarks>In contrast to <see cref="IDynamoDBContext.ToDocument{T}(T)"/> this method bypassed any table loading, caching or validation against the table.</remarks>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        public static T ConvertFromDocument<T>(this IDynamoDBContext dynamoDbContext, Document document, DynamoDBOperationConfig operationConfig)
        {
            operationConfig.ConvertOnly = true;
            return dynamoDbContext.FromDocument<T>(document, operationConfig);
        }
    }
}