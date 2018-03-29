/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudSearchDomain.Model;
using Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearchDomain
{
    /// <summary>
    /// Implementation for accessing CloudSearchDomain
    ///
    /// You use the AmazonCloudSearch2013 API to upload documents to a search domain and search
    /// those documents. 
    /// 
    ///  
    /// <para>
    /// The endpoints for submitting <code>UploadDocuments</code>, <code>Search</code>, and
    /// <code>Suggest</code> requests are domain-specific. To get the endpoints for your domain,
    /// use the Amazon CloudSearch configuration service <code>DescribeDomains</code> action.
    /// The domain endpoints are also displayed on the domain dashboard in the Amazon CloudSearch
    /// console. You submit suggest requests to the search endpoint. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide">Amazon
    /// CloudSearch Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudSearchDomainClient : AmazonServiceClient, IAmazonCloudSearchDomain
    {
        

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudSearchDomain.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.CloudSearchDomain.Internal.ValidationResponseHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.CloudSearchDomain.Internal.ProcessExceptionHandler());
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
            var marshaller = SearchRequestMarshaller.Instance;
            var unmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchRequest,SearchResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SearchRequestMarshaller.Instance;
            var unmarshaller = SearchResponseUnmarshaller.Instance;

            return InvokeAsync<SearchRequest,SearchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Suggest

        internal virtual SuggestResponse Suggest(SuggestRequest request)
        {
            var marshaller = SuggestRequestMarshaller.Instance;
            var unmarshaller = SuggestResponseUnmarshaller.Instance;

            return Invoke<SuggestRequest,SuggestResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Suggest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Suggest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SuggestResponse> SuggestAsync(SuggestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SuggestRequestMarshaller.Instance;
            var unmarshaller = SuggestResponseUnmarshaller.Instance;

            return InvokeAsync<SuggestRequest,SuggestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadDocuments

        internal virtual UploadDocumentsResponse UploadDocuments(UploadDocumentsRequest request)
        {
            var marshaller = UploadDocumentsRequestMarshaller.Instance;
            var unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return Invoke<UploadDocumentsRequest,UploadDocumentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UploadDocumentsResponse> UploadDocumentsAsync(UploadDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UploadDocumentsRequestMarshaller.Instance;
            var unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<UploadDocumentsRequest,UploadDocumentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}