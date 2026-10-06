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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LambdaWeb.Model;

#pragma warning disable CS1570
namespace Amazon.LambdaWeb
{
    /// <summary>
    /// <para>Interface for accessing LambdaWeb</para>
    ///
    /// <note> 
    /// <para>
    /// The AWS Lambda Web Functions APIs (<c>LambdaWeb</c> namespace) are experimental and
    /// for internal AWS use only. They are not yet available to external customers.
    /// 
    ///  </note>
    /// </para>
    /// </summary>
    public partial interface IAmazonLambdaWeb : IAmazonService, IDisposable
    {


        
        #region  GetWebAccountSettings


        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// 
        ///  <note> 
        /// <para>
        /// This API is experimental and for internal AWS use only. It is not yet available to
        /// external customers.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        GetWebAccountSettingsResponse GetWebAccountSettings(GetWebAccountSettingsRequest request);



        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// 
        ///  <note> 
        /// <para>
        /// This API is experimental and for internal AWS use only. It is not yet available to
        /// external customers.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        Task<GetWebAccountSettingsResponse> GetWebAccountSettingsAsync(GetWebAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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