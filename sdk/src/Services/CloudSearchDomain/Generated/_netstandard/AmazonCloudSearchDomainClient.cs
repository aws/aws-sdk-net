/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudSearchDomain.Model;
using Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations;
using Amazon.CloudSearchDomain.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudSearchDomain
{
    /// <summary>
    /// <para>Implementation for accessing CloudSearchDomain</para>
    ///
    /// You use the AmazonCloudSearch2013 API to upload documents to a search domain and search
    /// those documents. 
    /// 
    ///  
    /// <para>
    /// The endpoints for submitting <c>UploadDocuments</c>, <c>Search</c>, and <c>Suggest</c>
    /// requests are domain-specific. To get the endpoints for your domain, use the Amazon
    /// CloudSearch configuration service <c>DescribeDomains</c> action. The domain endpoints
    /// are also displayed on the domain dashboard in the Amazon CloudSearch console. You
    /// submit suggest requests to the search endpoint. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide">Amazon
    /// CloudSearch Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudSearchDomainClient : AmazonServiceClient, IAmazonCloudSearchDomain
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudSearchDomainMetadata();
        

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudSearchDomain.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.CloudSearchDomain.Internal.ValidationResponseHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.CloudSearchDomain.Internal.ProcessExceptionHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudSearchDomainEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudSearchDomainAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  Search

        internal virtual SearchResponse Search(SearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of documents that match the specified search criteria. How you specify
        /// the search criteria depends on which query parser you use. Amazon CloudSearch supports
        /// four query parsers:
        /// 
        ///  <ul> <li><c>simple</c>: search all <c>text</c> and <c>text-array</c> fields for the
        /// specified string. Search for phrases, individual terms, and prefixes. </li> <li><c>structured</c>:
        /// search specific fields, construct compound queries using Boolean operators, and use
        /// advanced features such as term boosting and proximity searching.</li> <li><c>lucene</c>:
        /// specify search criteria using the Apache Lucene query parser syntax.</li> <li><c>dismax</c>:
        /// specify search criteria using the simplified subset of the Apache Lucene query parser
        /// syntax defined by the DisMax query parser.</li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching.html">Searching
        /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The endpoint for submitting <c>Search</c> requests is domain-specific. You submit
        /// search requests to a domain's search endpoint. To get the search endpoint for your
        /// domain, use the Amazon CloudSearch configuration service <c>DescribeDomains</c> action.
        /// A domain's endpoints are also displayed on the domain dashboard in the Amazon CloudSearch
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.SearchException">
        /// Information about any problems encountered while processing a search request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearchdomain-2013-01-01/Search">REST API Reference for Search Operation</seealso>
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return InvokeAsync<SearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Suggest

        internal virtual SuggestResponse Suggest(SuggestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return Invoke<SuggestResponse>(request, options);
        }



        /// <summary>
        /// Retrieves autocomplete suggestions for a partial query string. You can use suggestions
        /// enable you to display likely matches before users finish typing. In Amazon CloudSearch,
        /// suggestions are based on the contents of a particular text field. When you request
        /// suggestions, Amazon CloudSearch finds all of the documents whose values in the suggester
        /// field start with the specified query string. The beginning of the field must match
        /// the query string to be considered a match. 
        /// 
        ///  
        /// <para>
        /// For more information about configuring suggesters and retrieving suggestions, see
        /// <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-suggestions.html">Getting
        /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The endpoint for submitting <c>Suggest</c> requests is domain-specific. You submit
        /// suggest requests to a domain's search endpoint. To get the search endpoint for your
        /// domain, use the Amazon CloudSearch configuration service <c>DescribeDomains</c> action.
        /// A domain's endpoints are also displayed on the domain dashboard in the Amazon CloudSearch
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Suggest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Suggest service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.SearchException">
        /// Information about any problems encountered while processing a search request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearchdomain-2013-01-01/Suggest">REST API Reference for Suggest Operation</seealso>
        public virtual Task<SuggestResponse> SuggestAsync(SuggestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SuggestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuggestResponseUnmarshaller.Instance;

            return InvokeAsync<SuggestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UploadDocuments

        internal virtual UploadDocumentsResponse UploadDocuments(UploadDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return Invoke<UploadDocumentsResponse>(request, options);
        }



        /// <summary>
        /// Posts a batch of documents to a search domain for indexing. A document batch is a
        /// collection of add and delete operations that represent the documents you want to add,
        /// update, or delete from your domain. Batches can be described in either JSON or XML.
        /// Each item that you want Amazon CloudSearch to return as a search result (such as a
        /// product) is represented as a document. Every document has a unique ID and one or more
        /// fields that contain the data that you want to search and return in results. Individual
        /// documents cannot contain more than 1 MB of data. The entire batch cannot exceed 5
        /// MB. To get the best possible upload performance, group add and delete operations in
        /// batches that are close the 5 MB limit. Submitting a large volume of single-document
        /// batches can overload a domain's document service. 
        /// 
        ///  
        /// <para>
        /// The endpoint for submitting <c>UploadDocuments</c> requests is domain-specific. To
        /// get the document endpoint for your domain, use the Amazon CloudSearch configuration
        /// service <c>DescribeDomains</c> action. A domain's endpoints are also displayed on
        /// the domain dashboard in the Amazon CloudSearch console. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting your data for Amazon CloudSearch, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/preparing-data.html">Preparing
        /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>. For more information
        /// about uploading data for indexing, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/uploading-data.html">Uploading
        /// Data</a> in the <i>Amazon CloudSearch Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadDocuments service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.DocumentServiceException">
        /// Information about any problems encountered while processing an upload request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudsearchdomain-2013-01-01/UploadDocuments">REST API Reference for UploadDocuments Operation</seealso>
        public virtual Task<UploadDocumentsResponse> UploadDocumentsAsync(UploadDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<UploadDocumentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}