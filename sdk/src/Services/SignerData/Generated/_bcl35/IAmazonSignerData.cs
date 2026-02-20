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
 * Do not modify this file. This file is generated from the signer-data-2017-08-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SignerData.Model;

#pragma warning disable CS1570
namespace Amazon.SignerData
{
    /// <summary>
    /// <para>Interface for accessing SignerData</para>
    ///
    /// AWS Signer Data Plane service provides APIs for checking revocation status of signed
    /// artifacts.
    /// </summary>
    public partial interface IAmazonSignerData : IAmazonService, IDisposable
    {




        
        #region  GetRevocationStatus


        /// <summary>
        /// Retrieves the revocation status for a signed artifact by checking if the signing profile,
        /// job, or certificate has been revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus service method.</param>
        /// 
        /// <returns>The response from the GetRevocationStatus service method, as returned by SignerData.</returns>
        /// <exception cref="Amazon.SignerData.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SignerData.Model.ValidationException">
        /// The request contains invalid parameters or is malformed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        GetRevocationStatusResponse GetRevocationStatus(GetRevocationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus operation on AmazonSignerDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevocationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        IAsyncResult BeginGetRevocationStatus(GetRevocationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevocationStatus.</param>
        /// 
        /// <returns>Returns a  GetRevocationStatusResult from SignerData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-data-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        GetRevocationStatusResponse EndGetRevocationStatus(IAsyncResult asyncResult);

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