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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleDBv2.Model;

#pragma warning disable CS1570
namespace Amazon.SimpleDBv2
{
    /// <summary>
    /// <para>Interface for accessing SimpleDBv2</para>
    ///
    /// Amazon SimpleDB is a web service providing the core database functions of data indexing
    /// and querying in the cloud. By offloading the time and effort associated with building
    /// and operating a web-scale database, SimpleDB provides developers the freedom to focus
    /// on application development.
    /// 
    ///  <pre><c> A traditional, clustered relational database requires a sizable upfront
    /// capital outlay, is complex to design, and often requires extensive and repetitive
    /// database administration. Amazon SimpleDB is dramatically simpler, requiring no schema,
    /// automatically indexing your data and providing a simple API for storage and access.
    /// This approach eliminates the administrative burden of data modeling, index maintenance,
    /// and performance tuning. Developers gain access to this functionality within Amazon's
    /// proven computing environment, are able to scale instantly, and pay only for what they
    /// use. </c></pre>
    /// </summary>
    public partial interface IAmazonSimpleDBv2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleDBv2PaginatorFactory Paginators { get; }
#endif


        
        #region  GetExport


        /// <summary>
        /// Returns information for an existing domain export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchExportException">
        /// Export with specified ARN does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse GetExport(GetExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation on AmazonSimpleDBv2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/GetExport">REST API Reference for GetExport Operation</seealso>
        IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from SimpleDBv2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/GetExport">REST API Reference for GetExport Operation</seealso>
        GetExportResponse EndGetExport(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all exports that were created. The results are paginated and can be filtered
        /// by domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidNextTokenException">
        /// The specified next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation on AmazonSimpleDBv2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/ListExports">REST API Reference for ListExports Operation</seealso>
        IAsyncResult BeginListExports(ListExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExports.</param>
        /// 
        /// <returns>Returns a  ListExportsResult from SimpleDBv2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse EndListExports(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDomainExport


        /// <summary>
        /// Initiates the export of a SimpleDB domain to an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainExport service method.</param>
        /// 
        /// <returns>The response from the StartDomainExport service method, as returned by SimpleDBv2.</returns>
        /// <exception cref="Amazon.SimpleDBv2.Model.ConflictException">
        /// Indicates a conflict with one or more parameters of the request.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together in the request.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.InvalidParameterValueException">
        /// The specified parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NoSuchDomainException">
        /// The specified domain does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleDBv2.Model.NumberExportsLimitExceededException">
        /// Cannot start export as export quota limit was exceeded
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/StartDomainExport">REST API Reference for StartDomainExport Operation</seealso>
        StartDomainExportResponse StartDomainExport(StartDomainExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDomainExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDomainExport operation on AmazonSimpleDBv2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDomainExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/StartDomainExport">REST API Reference for StartDomainExport Operation</seealso>
        IAsyncResult BeginStartDomainExport(StartDomainExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDomainExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDomainExport.</param>
        /// 
        /// <returns>Returns a  StartDomainExportResult from SimpleDBv2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simpledbv2-2025-09-26/StartDomainExport">REST API Reference for StartDomainExport Operation</seealso>
        StartDomainExportResponse EndStartDomainExport(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}