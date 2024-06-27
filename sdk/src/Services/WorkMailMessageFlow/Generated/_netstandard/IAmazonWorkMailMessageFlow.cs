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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMailMessageFlow.Model;

#pragma warning disable CS1570
namespace Amazon.WorkMailMessageFlow
{
    /// <summary>
    /// <para>Interface for accessing WorkMailMessageFlow</para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        Task<GetRawMessageContentResponse> GetRawMessageContentAsync(GetRawMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates to an in-transit message only appear when you call <c>PutRawMessageContent</c>
        /// from an AWS Lambda function configured with a synchronous <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/lambda.html#synchronous-rules">
        /// Run Lambda</a> rule. If you call <c>PutRawMessageContent</c> on a delivered or sent
        /// message, the message remains unchanged, even though <a href="https://docs.aws.amazon.com/workmail/latest/APIReference/API_messageflow_GetRawMessageContent.html">GetRawMessageContent</a>
        /// returns an updated message. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRawMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutRawMessageContentResponse> PutRawMessageContentAsync(PutRawMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonWorkMailMessageFlowConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonWorkMailMessageFlowConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonWorkMailMessageFlowConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonWorkMailMessageFlowConfig to create AmazonWorkMailMessageFlowClient");
            }

            return awsCredentials == null ? 
                    new AmazonWorkMailMessageFlowClient(serviceClientConfig) :
                    new AmazonWorkMailMessageFlowClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}