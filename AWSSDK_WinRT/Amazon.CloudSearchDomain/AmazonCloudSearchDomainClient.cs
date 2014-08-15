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


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

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
    public partial class AmazonCloudSearchDomainClient : AmazonWebServiceClient, IAmazonCloudSearchDomain
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        
        #region  Search

        internal SearchResponse Search(SearchRequest request)
        {
            var task = SearchAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// <seealso cref="Amazon.CloudSearchDomain.IAmazonCloudSearchDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SearchRequestMarshaller();
            var unmarshaller = SearchResponseUnmarshaller.Instance;
            return Invoke<IRequest, SearchRequest, SearchResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  Suggest

        internal SuggestResponse Suggest(SuggestRequest request)
        {
            var task = SuggestAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Suggest operation.
        /// <seealso cref="Amazon.CloudSearchDomain.IAmazonCloudSearchDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Suggest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SuggestResponse> SuggestAsync(SuggestRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SuggestRequestMarshaller();
            var unmarshaller = SuggestResponseUnmarshaller.Instance;
            return Invoke<IRequest, SuggestRequest, SuggestResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UploadDocuments

        internal UploadDocumentsResponse UploadDocuments(UploadDocumentsRequest request)
        {
            var task = UploadDocumentsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDocuments operation.
        /// <seealso cref="Amazon.CloudSearchDomain.IAmazonCloudSearchDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadDocumentsResponse> UploadDocumentsAsync(UploadDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadDocumentsRequestMarshaller();
            var unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;
            return Invoke<IRequest, UploadDocumentsRequest, UploadDocumentsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}