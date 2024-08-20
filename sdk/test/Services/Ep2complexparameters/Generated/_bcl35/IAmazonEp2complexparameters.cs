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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ep2complexparameters.Model;

#pragma warning disable CS1570
namespace Amazon.Ep2complexparameters
{
    /// <summary>
    /// <para>Interface for accessing Ep2complexparameters</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonEp2complexparameters : IAmazonService, IDisposable
    {




        
        #region  EmptyStaticContextOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation service method.</param>
        /// 
        /// <returns>The response from the EmptyStaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        EmptyStaticContextOperationResponse EmptyStaticContextOperation(EmptyStaticContextOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyStaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyStaticContextOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        IAsyncResult BeginEmptyStaticContextOperation(EmptyStaticContextOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyStaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyStaticContextOperation.</param>
        /// 
        /// <returns>Returns a  EmptyStaticContextOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        EmptyStaticContextOperationResponse EndEmptyStaticContextOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOfObjectsOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation service method.</param>
        /// 
        /// <returns>The response from the ListOfObjectsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        ListOfObjectsOperationResponse ListOfObjectsOperation(ListOfObjectsOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfObjectsOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfObjectsOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        IAsyncResult BeginListOfObjectsOperation(ListOfObjectsOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfObjectsOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfObjectsOperation.</param>
        /// 
        /// <returns>Returns a  ListOfObjectsOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        ListOfObjectsOperationResponse EndListOfObjectsOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  MapOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MapOperation service method.</param>
        /// 
        /// <returns>The response from the MapOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        MapOperationResponse MapOperation(MapOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MapOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MapOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMapOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        IAsyncResult BeginMapOperation(MapOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MapOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMapOperation.</param>
        /// 
        /// <returns>Returns a  MapOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        MapOperationResponse EndMapOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  NoBindingsOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation service method.</param>
        /// 
        /// <returns>The response from the NoBindingsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        NoBindingsOperationResponse NoBindingsOperation(NoBindingsOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoBindingsOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoBindingsOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        IAsyncResult BeginNoBindingsOperation(NoBindingsOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoBindingsOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoBindingsOperation.</param>
        /// 
        /// <returns>Returns a  NoBindingsOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        NoBindingsOperationResponse EndNoBindingsOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  StaticContextOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation service method.</param>
        /// 
        /// <returns>The response from the StaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        StaticContextOperationResponse StaticContextOperation(StaticContextOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation operation on AmazonEp2complexparametersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStaticContextOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        IAsyncResult BeginStaticContextOperation(StaticContextOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StaticContextOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticContextOperation.</param>
        /// 
        /// <returns>Returns a  StaticContextOperationResult from Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        StaticContextOperationResponse EndStaticContextOperation(IAsyncResult asyncResult);

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