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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Retrieves a list of documents that match the specified search criteria. How you specify
        /// the search criteria depends on which query parser you use. Amazon CloudSearch supports
        /// four query parsers:
        /// 
        ///  <ul> <li><code>simple</code>: search all <code>text</code> and <code>text-array</code>
        /// fields for the specified string. Search for phrases, individual terms, and prefixes.
        /// </li> <li><code>structured</code>: search specific fields, construct compound queries
        /// using Boolean operators, and use advanced features such as term boosting and proximity
        /// searching.</li> <li><code>lucene</code>: specify search criteria using the Apache
        /// Lucene query parser syntax.</li> <li><code>dismax</code>: specify search criteria
        /// using the simplified subset of the Apache Lucene query parser syntax defined by the
        /// DisMax query parser.</li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching.html">Searching
        /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The endpoint for submitting <code>Search</code> requests is domain-specific. You submit
        /// search requests to a domain's search endpoint. To get the search endpoint for your
        /// domain, use the Amazon CloudSearch configuration service <code>DescribeDomains</code>
        /// action. A domain's endpoints are also displayed on the domain dashboard in the Amazon
        /// CloudSearch console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.SearchException">
        /// Information about any problems encountered while processing a search request.
        /// </exception>
        public virtual SearchResponse Search(SearchRequest request)
        {
            var marshaller = SearchRequestMarshaller.Instance;
            var unmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchRequest,SearchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonCloudSearchDomainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        public virtual IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SearchRequestMarshaller.Instance;
            var unmarshaller = SearchResponseUnmarshaller.Instance;

            return BeginInvoke<SearchRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from CloudSearchDomain.</returns>
        public virtual SearchResponse EndSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchResponse>(asyncResult);
        }

        #endregion
        
        #region  Suggest

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
        /// The endpoint for submitting <code>Suggest</code> requests is domain-specific. You
        /// submit suggest requests to a domain's search endpoint. To get the search endpoint
        /// for your domain, use the Amazon CloudSearch configuration service <code>DescribeDomains</code>
        /// action. A domain's endpoints are also displayed on the domain dashboard in the Amazon
        /// CloudSearch console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Suggest service method.</param>
        /// 
        /// <returns>The response from the Suggest service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.SearchException">
        /// Information about any problems encountered while processing a search request.
        /// </exception>
        public virtual SuggestResponse Suggest(SuggestRequest request)
        {
            var marshaller = SuggestRequestMarshaller.Instance;
            var unmarshaller = SuggestResponseUnmarshaller.Instance;

            return Invoke<SuggestRequest,SuggestResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Suggest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Suggest operation on AmazonCloudSearchDomainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuggest
        ///         operation.</returns>
        public virtual IAsyncResult BeginSuggest(SuggestRequest request, AsyncCallback callback, object state)
        {
            var marshaller = SuggestRequestMarshaller.Instance;
            var unmarshaller = SuggestResponseUnmarshaller.Instance;

            return BeginInvoke<SuggestRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Suggest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuggest.</param>
        /// 
        /// <returns>Returns a  SuggestResult from CloudSearchDomain.</returns>
        public virtual SuggestResponse EndSuggest(IAsyncResult asyncResult)
        {
            return EndInvoke<SuggestResponse>(asyncResult);
        }

        #endregion
        
        #region  UploadDocuments

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
        /// The endpoint for submitting <code>UploadDocuments</code> requests is domain-specific.
        /// To get the document endpoint for your domain, use the Amazon CloudSearch configuration
        /// service <code>DescribeDomains</code> action. A domain's endpoints are also displayed
        /// on the domain dashboard in the Amazon CloudSearch console. 
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
        /// 
        /// <returns>The response from the UploadDocuments service method, as returned by CloudSearchDomain.</returns>
        /// <exception cref="Amazon.CloudSearchDomain.Model.DocumentServiceException">
        /// Information about any problems encountered while processing an upload request.
        /// </exception>
        public virtual UploadDocumentsResponse UploadDocuments(UploadDocumentsRequest request)
        {
            var marshaller = UploadDocumentsRequestMarshaller.Instance;
            var unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return Invoke<UploadDocumentsRequest,UploadDocumentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadDocuments operation on AmazonCloudSearchDomainClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadDocuments
        ///         operation.</returns>
        public virtual IAsyncResult BeginUploadDocuments(UploadDocumentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UploadDocumentsRequestMarshaller.Instance;
            var unmarshaller = UploadDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke<UploadDocumentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadDocuments.</param>
        /// 
        /// <returns>Returns a  UploadDocumentsResult from CloudSearchDomain.</returns>
        public virtual UploadDocumentsResponse EndUploadDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadDocumentsResponse>(asyncResult);
        }

        #endregion
        
    }
}