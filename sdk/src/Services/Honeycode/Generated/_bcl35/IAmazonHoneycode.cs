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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Honeycode.Model;

namespace Amazon.Honeycode
{
    /// <summary>
    /// Interface for accessing Honeycode
    ///
    /// Amazon Honeycode is a fully managed service that allows you to quickly build mobile
    /// and web apps for teams—without programming. Build Honeycode apps for managing almost
    /// anything, like projects, customers, operations, approvals, resources, and even your
    /// team.
    /// </summary>
    public partial interface IAmazonHoneycode : IAmazonService, IDisposable
    {

        
        #region  GetScreenData


        /// <summary>
        /// The GetScreenData API allows retrieval of data from a screen in a Honeycode app.
        /// The API allows setting local variables in the screen to filter, sort or otherwise
        /// affect what will be displayed on the screen.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData service method.</param>
        /// 
        /// <returns>The response from the GetScreenData service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the screen/automation in the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        GetScreenDataResponse GetScreenData(GetScreenDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScreenData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        IAsyncResult BeginGetScreenData(GetScreenDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScreenData.</param>
        /// 
        /// <returns>Returns a  GetScreenDataResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        GetScreenDataResponse EndGetScreenData(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeScreenAutomation


        /// <summary>
        /// The InvokeScreenAutomation API allows invoking an action defined in a screen in a
        /// Honeycode app. The API allows setting local variables, which can then be used in the
        /// automation being invoked. This allows automating the Honeycode app interactions to
        /// write, update or delete data in the workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation service method.</param>
        /// 
        /// <returns>The response from the InvokeScreenAutomation service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the screen/automation in the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionException">
        /// The automation execution did not end successfully.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionTimeoutException">
        /// The automation execution timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        InvokeScreenAutomationResponse InvokeScreenAutomation(InvokeScreenAutomationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeScreenAutomation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        IAsyncResult BeginInvokeScreenAutomation(InvokeScreenAutomationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeScreenAutomation.</param>
        /// 
        /// <returns>Returns a  InvokeScreenAutomationResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        InvokeScreenAutomationResponse EndInvokeScreenAutomation(IAsyncResult asyncResult);

        #endregion
        
    }
}