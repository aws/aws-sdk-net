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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QLDBSession.Model;

#pragma warning disable CS1570
namespace Amazon.QLDBSession
{
    /// <summary>
    /// <para>Interface for accessing QLDBSession</para>
    ///
    /// The transactional data APIs for Amazon QLDB
    /// 
    ///  <note> 
    /// <para>
    /// Instead of interacting directly with this API, we recommend using the QLDB driver
    /// or the QLDB shell to execute data transactions on a ledger.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
    /// abstraction layer above this <i>QLDB Session</i> data plane and manages <c>SendCommand</c>
    /// API calls for you. For information and a list of supported programming languages,
    /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
    /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
    /// The shell is a command line interface that uses the QLDB driver to interact with a
    /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
    /// Amazon QLDB using the QLDB shell</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial interface IAmazonQLDBSession : IAmazonService, IDisposable
    {


        
        #region  SendCommand


        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// 
        ///  <note> 
        /// <para>
        /// Instead of interacting directly with this API, we recommend using the QLDB driver
        /// or the QLDB shell to execute data transactions on a ledger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
        /// abstraction layer above this <i>QLDB Session</i> data plane and manages <c>SendCommand</c>
        /// API calls for you. For information and a list of supported programming languages,
        /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
        /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
        /// The shell is a command line interface that uses the QLDB driver to interact with a
        /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
        /// Amazon QLDB using the QLDB shell</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.CapacityExceededException">
        /// Returned when the request exceeds the processing capacity of the ledger.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of <i>optimistic concurrency control</i> (OCC).
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        SendCommandResponse SendCommand(SendCommandRequest request);



        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// 
        ///  <note> 
        /// <para>
        /// Instead of interacting directly with this API, we recommend using the QLDB driver
        /// or the QLDB shell to execute data transactions on a ledger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
        /// abstraction layer above this <i>QLDB Session</i> data plane and manages <c>SendCommand</c>
        /// API calls for you. For information and a list of supported programming languages,
        /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
        /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
        /// The shell is a command line interface that uses the QLDB driver to interact with a
        /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
        /// Amazon QLDB using the QLDB shell</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.CapacityExceededException">
        /// Returned when the request exceeds the processing capacity of the ledger.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of <i>optimistic concurrency control</i> (OCC).
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, CancellationToken cancellationToken = default(CancellationToken));

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