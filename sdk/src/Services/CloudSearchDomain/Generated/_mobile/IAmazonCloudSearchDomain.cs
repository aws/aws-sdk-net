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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudSearchDomain.Model;

namespace Amazon.CloudSearchDomain
{
    /// <summary>
    /// Interface for accessing CloudSearchDomain
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
    public partial interface IAmazonCloudSearchDomain : IDisposable
    {
                
        #region  Search

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Suggest

        /// <summary>
        /// Initiates the asynchronous execution of the Suggest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Suggest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SuggestResponse> SuggestAsync(SuggestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadDocuments

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UploadDocumentsResponse> UploadDocumentsAsync(UploadDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}