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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMailMessageFlow.Model;

namespace Amazon.WorkMailMessageFlow
{
    /// <summary>
    /// Interface for accessing WorkMailMessageFlow
    ///
    /// The WorkMail Message Flow API provides access to email messages as they are being
    /// sent and received by a WorkMail organization.
    /// </summary>
    public partial interface IAmazonWorkMailMessageFlow : IAmazonService, IDisposable
    {




        
        #region  GetRawMessageContent


        /// <summary>
        /// Retrieves the raw content of an in-transit email message, in MIME format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent service method.</param>
        /// 
        /// <returns>The response from the GetRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        GetRawMessageContentResponse GetRawMessageContent(GetRawMessageContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent operation on AmazonWorkMailMessageFlowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRawMessageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        IAsyncResult BeginGetRawMessageContent(GetRawMessageContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRawMessageContent.</param>
        /// 
        /// <returns>Returns a  GetRawMessageContentResult from WorkMailMessageFlow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        GetRawMessageContentResponse EndGetRawMessageContent(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRawMessageContent


        /// <summary>
        /// Updates the raw content of an in-transit email message, in MIME format.
        /// 
        ///  
        /// <para>
        /// This example describes how to update in-transit email message. For more information
        /// and examples for using this API, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
        /// Updating message content with AWS Lambda</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Updates to an in-transit message only appear when you call <code>PutRawMessageContent</code>
        /// from an AWS Lambda function configured with a synchronous <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/lambda.html#synchronous-rules">
        /// Run Lambda</a> rule. If you call <code>PutRawMessageContent</code> on a delivered
        /// or sent message, the message remains unchanged, even though <a href="https://docs.aws.amazon.com/workmail/latest/APIReference/API_messageflow_GetRawMessageContent.html">GetRawMessageContent</a>
        /// returns an updated message. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRawMessageContent service method.</param>
        /// 
        /// <returns>The response from the PutRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.InvalidContentLocationException">
        /// WorkMail could not access the updated email content. Possible reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You made the request in a region other than your S3 bucket region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-owner-condition.html">S3
        /// bucket owner</a> is not the same as the calling AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You have an incomplete or missing S3 bucket policy. For more information about policies,
        /// see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
        /// Updating message content with AWS Lambda </a> in the <i>WorkMail Administrator Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.MessageFrozenException">
        /// The requested email is not eligible for update. This is usually the case for a redirected
        /// email.
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.MessageRejectedException">
        /// The requested email could not be updated due to an error in the MIME content. Check
        /// the error message for more information about what caused the error.
        /// </exception>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/PutRawMessageContent">REST API Reference for PutRawMessageContent Operation</seealso>
        PutRawMessageContentResponse PutRawMessageContent(PutRawMessageContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRawMessageContent operation on AmazonWorkMailMessageFlowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRawMessageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/PutRawMessageContent">REST API Reference for PutRawMessageContent Operation</seealso>
        IAsyncResult BeginPutRawMessageContent(PutRawMessageContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRawMessageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRawMessageContent.</param>
        /// 
        /// <returns>Returns a  PutRawMessageContentResult from WorkMailMessageFlow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/PutRawMessageContent">REST API Reference for PutRawMessageContent Operation</seealso>
        PutRawMessageContentResponse EndPutRawMessageContent(IAsyncResult asyncResult);

        #endregion
        
    }
}