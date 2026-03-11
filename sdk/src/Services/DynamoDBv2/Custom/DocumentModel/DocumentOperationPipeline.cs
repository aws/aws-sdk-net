using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Provides an abstract pipeline for executing document operations against a DynamoDB table, supporting both
    /// synchronous and asynchronous execution patterns.
    /// </summary>
    /// <remarks>This class defines the structure for mapping high-level document requests to low-level
    /// DynamoDB requests, validating input, applying expressions, invoking the service, and post-processing results.
    /// Derived classes must implement the abstract methods to provide specific operation logic. The pipeline ensures
    /// that requests are executed with the appropriate user agent details and supports cancellation for asynchronous
    /// operations.</remarks>
    /// <typeparam name="THighLevelRequest">The type representing the high-level request for the document operation.</typeparam>
    /// <typeparam name="TLowLevelRequest">The type representing the low-level DynamoDB request. Must inherit from AmazonDynamoDBRequest.</typeparam>
    /// <typeparam name="TServiceResponse">The type representing the response from the DynamoDB service. Must inherit from AmazonWebServiceResponse.</typeparam>
    /// <typeparam name="TResult">The type representing the final result produced by the pipeline after processing the service response.</typeparam>
    internal abstract class DocumentOperationPipeline<THighLevelRequest, TLowLevelRequest, TServiceResponse, TResult>
        where TLowLevelRequest : AmazonDynamoDBRequest
        where TServiceResponse : AmazonWebServiceResponse
    {
        protected readonly Table Table;

        protected DocumentOperationPipeline(Table table)
        {
            Table = table ?? throw new ArgumentNullException(nameof(table));
        }

        /// <summary>
        /// Executes the specified high-level request synchronously and returns the processed result.
        /// </summary>
        /// <param name="request">The high-level request to execute. Cannot be null.</param>
        /// <returns>The result of processing the request, of type <typeparamref name="TResult"/>.</returns>
        public TResult ExecuteSync(THighLevelRequest request)
        {
            Validate(request);
            var low = Map(request);
            Table.UpdateRequestUserAgentDetails(low, isAsync: false);
            ApplyExpressions(request, low);
            var resp = InvokeSync(low);
            return PostProcess(request, resp);
        }

        /// <summary>
        /// Executes the specified high-level request asynchronously and returns the processed result.
        /// </summary>
        /// <param name="request">The high-level request to execute. Cannot be null.</param>
        /// <param name="ct">A cancellation token that can be used to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the processed response for the
        /// specified request.</returns>
        public async Task<TResult> ExecuteAsync(THighLevelRequest request, CancellationToken ct)
        {
            Validate(request);
            var low = Map(request);
            Table.UpdateRequestUserAgentDetails(low, isAsync: true);
            ApplyExpressions(request, low);
            var resp = await InvokeAsync(low, ct).ConfigureAwait(false);
            return PostProcess(request, resp);
        }

        /// <summary>
        /// Validates the specified high-level request to ensure it meets all required criteria before processing.
        /// </summary>
        /// <param name="request">The high-level request to validate. Cannot be null.</param>
        protected abstract void Validate(THighLevelRequest request);

        /// <summary>
        /// Converts a high-level request object to its corresponding low-level request representation.
        /// </summary>
        /// <param name="request">The high-level request to be mapped. Cannot be null.</param>
        /// <returns>The low-level request object that represents the mapped version of the specified high-level request.</returns>
        protected abstract TLowLevelRequest Map(THighLevelRequest request);

        /// <summary>
        /// Applies high-level request parameters to the specified low-level request object.
        /// </summary>
        /// <remarks>Implementations should ensure that all relevant parameters from the high-level
        /// request are correctly mapped to the low-level request. This method does not perform validation; callers are
        /// responsible for providing valid request objects.</remarks>
        /// <param name="request">The high-level request containing parameters and options to be applied.</param>
        /// <param name="lowLevel">The low-level request object that will be modified based on the high-level request.</param>
        protected abstract void ApplyExpressions(THighLevelRequest request, TLowLevelRequest lowLevel);

        /// <summary>
        /// Invokes the low-level request synchronously against the DynamoDB service.
        /// </summary>
        /// <param name="lowLevel">The low-level request object to be sent to the service. Cannot be null.</param>
        /// <returns>The service response returned by the service.</returns>
        protected abstract TServiceResponse InvokeSync(TLowLevelRequest lowLevel);

        /// <summary>
        /// Asynchronously sends a low-level request and returns the corresponding service response.
        /// </summary>
        /// <param name="lowLevel">The low-level request object to be sent to the service. Cannot be null.</param>
        /// <param name="ct">A cancellation token that can be used to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the service response returned by
        /// the service.</returns>
        protected abstract Task<TServiceResponse> InvokeAsync(TLowLevelRequest lowLevel, CancellationToken ct);

        /// <summary>
        /// Performs the final transformation of the raw DynamoDB service response into the high-level
        /// result type returned to the caller.
        /// </summary>
        /// <param name="request">
        /// The original high-level request that initiated the operation. Guaranteed non-null (already validated
        /// by <see cref="Validate(THighLevelRequest)"/>).
        /// </param>
        /// <param name="serviceResponse">
        /// The low-level response object returned by the DynamoDB service invocation. Contains the raw data
        /// (e.g., attribute maps) needed to construct the final result.
        /// </param>
        /// <returns>
        /// The processed result derived from <paramref name="serviceResponse"/>. Implementations may return
        /// null for operations whose semantics do not yield a material result (e.g., PutItem without requesting
        /// return values).
        /// </returns>
        /// <remarks>
        /// Typical responsibilities of an implementation include:
        /// 1. Committing or reconciling state changes on the request (e.g., persisting Document mutations).
        /// 2. Converting attribute dictionaries to <see cref="Document"/> instances or other domain types.
        /// 3. Extracting and shaping operation metadata when required by higher-level abstractions.
        ///
        /// Implementations should avoid throwing unless an unexpected serialization or mapping issue occurs.
        /// Side effects should be limited to intentional state commits on objects referenced by <paramref name="request"/>.
        /// </remarks>
        protected abstract TResult PostProcess(THighLevelRequest request, TServiceResponse serviceResponse);
    }

    /// <summary>
    /// Provides a pipeline for executing document-based PutItem operations against a DynamoDB table.
    /// </summary>
    /// <remarks>This class maps high-level document requests to low-level PutItem requests, applies
    /// conditional expressions, and processes responses to support document-oriented workflows. It is intended for
    /// internal use within the document API infrastructure and is not designed for direct consumption by application
    /// code.</remarks>
    internal sealed class PutItemPipeline : DocumentOperationPipeline<PutItemDocumentOperationRequest, PutItemRequest,
        PutItemResponse, Document>
    {
        public PutItemPipeline(Table table) : base(table)
        {
        }

        protected override void Validate(PutItemDocumentOperationRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (request.Document == null)
                throw new InvalidOperationException(
                    "The Document property of the PutItemDocumentOperationRequest cannot be null.");
        }

        protected override PutItemRequest Map(PutItemDocumentOperationRequest request)
        {
            var req = new PutItemRequest
            {
                TableName = Table.TableName,
                Item = Table.ToAttributeMap(request.Document)
            };
            if (request.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(request.ReturnValues);
            return req;
        }

        protected override void ApplyExpressions(PutItemDocumentOperationRequest request, PutItemRequest lowLevel)
        {
            if (request.ConditionalExpression is { IsSet: true })
                request.ConditionalExpression.ApplyExpression(lowLevel, Table);
        }

        protected override PutItemResponse InvokeSync(PutItemRequest lowLevel)
        {
#if NETSTANDARD

            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = Table.DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous PutItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via PutItemAsync instead.");
            }
            return client.PutItem(lowLevel);
#else
            return Table.DDBClient.PutItem(lowLevel);
#endif
        }


        protected override Task<PutItemResponse> InvokeAsync(PutItemRequest lowLevel, CancellationToken ct)
            => Table.DDBClient.PutItemAsync(lowLevel, ct);

        protected override Document PostProcess(PutItemDocumentOperationRequest request,
            PutItemResponse serviceResponse)
        {
            request.Document.CommitChanges();
            if (request.ReturnValues == ReturnValues.AllOldAttributes && serviceResponse.Attributes != null)
                return Table.FromAttributeMap(serviceResponse.Attributes);
            return null;
        }
    }

    /// <summary>
    /// Provides a pipeline for executing a DynamoDB GetItem operation using document-based requests and responses.
    /// </summary>
    /// <remarks>This class maps high-level document operation requests to low-level GetItem requests, applies
    /// projection expressions, and processes responses into document objects. It is intended for internal use within
    /// the document operation framework.</remarks>
    internal sealed class GetItemPipeline
        : DocumentOperationPipeline<GetItemDocumentOperationRequest, GetItemRequest, GetItemResponse, Document>
    {
        public GetItemPipeline(Table table) : base(table)
        {
        }

        protected override void Validate(GetItemDocumentOperationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            if (request.Key == null || request.Key.Count == 0)
                throw new InvalidOperationException("GetItemDocumentOperationRequest.Key cannot be null or empty.");
        }

        protected override GetItemRequest Map(GetItemDocumentOperationRequest request)
        {
            return new GetItemRequest
            {
                TableName = Table.TableName,
                Key = Table.MakeKey(request.Key),
                ConsistentRead = request.ConsistentRead
            };
        }

        protected override void ApplyExpressions(GetItemDocumentOperationRequest request, GetItemRequest lowLevel)
        {
            if (request.ProjectionExpression is { IsSet: true })
                request.ProjectionExpression.ApplyExpression(lowLevel, Table);
        }

        protected override GetItemResponse InvokeSync(GetItemRequest lowLevel)
        {
#if NETSTANDARD
        // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = Table.DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous GetItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via GetItemAsync instead.");
            }
            return client.GetItem(lowLevel);
#else
            return Table.DDBClient.GetItem(lowLevel);
#endif
        }


        protected override async Task<GetItemResponse> InvokeAsync(GetItemRequest lowLevel, CancellationToken ct) =>
            await Table.DDBClient.GetItemAsync(lowLevel, ct).ConfigureAwait(false);

        protected override Document PostProcess(GetItemDocumentOperationRequest request, GetItemResponse serviceResponse)
        {
            var map = serviceResponse.Item;
            return (map == null || map.Count == 0) ? null : Table.FromAttributeMap(map);
        }
    }

    /// <summary>
    /// Provides a pipeline for processing update operations on DynamoDB items, handling validation, mapping, and
    /// execution of update requests.
    /// </summary>
    /// <remarks>This class is intended for internal use within the document model infrastructure and
    /// coordinates the conversion of high-level update requests into low-level DynamoDB update operations. It ensures
    /// that either a document or an update expression is provided exclusively, and manages the mapping of keys and
    /// update expressions.</remarks>
    internal sealed class UpdateItemPipeline :
        DocumentOperationPipeline<UpdateItemDocumentOperationRequest, UpdateItemRequest, UpdateItemResponse, Document>
    {
        public UpdateItemPipeline(Table table) : base(table)
        {
        }

        protected override void Validate(UpdateItemDocumentOperationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            bool docSet = request.Document != null;
            bool exprSet = request.UpdateExpression is { IsSet: true };
            if ((docSet && exprSet) || (!docSet && !exprSet))
                throw new InvalidOperationException("Either Document or UpdateExpression must be set (exclusively).");
        }

        protected override UpdateItemRequest Map(UpdateItemDocumentOperationRequest request)
        {
            var req = new UpdateItemRequest
            {
                TableName = Table.TableName,
                ReturnValues = EnumMapper.Convert(request.ReturnValues)
            };

            Key key = request.Key != null ? Table.MakeKey(request.Key) : null;

            if (request.Document != null)
            {
                key ??= Table.MakeKey(request.Document);
                bool haveKeysChanged = Table.HaveKeysChanged(request.Document);
                var attrUpdates = Table.ToAttributeUpdateMap(request.Document, !haveKeysChanged);
                foreach (var k in Table.KeyNames)
                    attrUpdates.Remove(k);

                Common.ConvertAttributeUpdatesToUpdateExpression(
                    attrUpdates,null,
                    request.UpdateExpression,
                    Table,
                    out var statement,
                    out var exprValues,
                    out var exprNames);

                req.UpdateExpression = statement;
                req.ExpressionAttributeValues = exprValues;
                req.ExpressionAttributeNames = exprNames;
            }

            if (key == null || key.Count == 0)
                throw new InvalidOperationException("UpdateItem requires a key either via request.Key or Document.");

            req.Key = key;

            return req;
        }

        protected override void ApplyExpressions(UpdateItemDocumentOperationRequest request, UpdateItemRequest lowLevel)
        {
            if (request.UpdateExpression is { IsSet: true })
                request.UpdateExpression.ApplyUpdateExpression(lowLevel, Table);
            if (request.ConditionalExpression is { IsSet: true })
                request.ConditionalExpression.ApplyConditionalExpression(lowLevel, Table);
        }

        protected override UpdateItemResponse InvokeSync(UpdateItemRequest lowLevel)
        {
#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = Table.DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous GetItem from .NET or .NET Core requires initializing the Table " +
                                                    "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via UpdateItemAsync instead.");
            }
            return client.UpdateItem(lowLevel);
#else
            return Table.DDBClient.UpdateItem(lowLevel);
#endif
        }

        protected override async Task<UpdateItemResponse> InvokeAsync(UpdateItemRequest lowLevel, CancellationToken ct) =>
            await Table.DDBClient.UpdateItemAsync(lowLevel, ct).ConfigureAwait(false);

        protected override Document PostProcess(UpdateItemDocumentOperationRequest request,
            UpdateItemResponse serviceResponse)
        {
            var resp = (UpdateItemResponse)serviceResponse;
            request.Document?.CommitChanges();
            if (request.ReturnValues != ReturnValues.None && resp.Attributes != null)
                return Table.FromAttributeMap(resp.Attributes);
            return null;
        }
    }

    /// <summary>
    /// Provides a pipeline for executing a DynamoDB DeleteItem operation using document model requests and responses.
    /// </summary>
    /// <remarks>This class maps high-level document-based delete requests to low-level DeleteItem operations
    /// against a specific DynamoDB table. It handles validation, expression application, synchronous and asynchronous
    /// invocation, and post-processing of results. The pipeline is intended for internal use within the document model.
    /// </remarks>
    internal sealed class DeleteItemPipeline :
        DocumentOperationPipeline<DeleteItemDocumentOperationRequest, DeleteItemRequest, DeleteItemResponse, Document>
    {
        public DeleteItemPipeline(Table table) : base(table) { }

        protected override void Validate(DeleteItemDocumentOperationRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (request.Key == null || request.Key.Count == 0)
                throw new InvalidOperationException("DeleteItemDocumentOperationRequest.Key cannot be null or empty.");
        }

        protected override DeleteItemRequest Map(DeleteItemDocumentOperationRequest request)
        {
            var req = new DeleteItemRequest
            {
                TableName = Table.TableName,
                Key = Table.MakeKey(request.Key)
            };
            if (request.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(request.ReturnValues);
            return req;
        }

        protected override void ApplyExpressions(DeleteItemDocumentOperationRequest request, DeleteItemRequest lowLevel)
        {
            if (request.ConditionalExpression is { IsSet: true })
                request.ConditionalExpression.ApplyExpression(lowLevel, Table);
        }

        protected override DeleteItemResponse InvokeSync(DeleteItemRequest lowLevel)
        {
#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = Table.DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous GetItem from .NET or .NET Core requires initializing the Table " +
                                                    "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via DeleteItemAsync instead.");
            }
            return client.DeleteItem(lowLevel);
#else
            return Table.DDBClient.DeleteItem(lowLevel);
#endif
        }

        protected override async Task<DeleteItemResponse> InvokeAsync(DeleteItemRequest lowLevel, CancellationToken ct) =>
            await Table.DDBClient.DeleteItemAsync(lowLevel, ct).ConfigureAwait(false);


        protected override Document PostProcess(DeleteItemDocumentOperationRequest request, DeleteItemResponse serviceResponse)
        {
            var resp = (DeleteItemResponse)serviceResponse;
            if (request.ReturnValues == ReturnValues.AllOldAttributes && resp.Attributes != null)
                return Table.FromAttributeMap(resp.Attributes);
            return null;
        }
    }
}