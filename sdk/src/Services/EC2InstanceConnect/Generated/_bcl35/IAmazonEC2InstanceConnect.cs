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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EC2InstanceConnect.Model;

namespace Amazon.EC2InstanceConnect
{
    /// <summary>
    /// Interface for accessing EC2InstanceConnect
    ///
    /// AWS EC2 Connect Service is a service that enables system administrators to publish
    /// temporary SSH keys to their EC2 instances in order to establish connections to their
    /// instances without leaving a permanent authentication option.
    /// </summary>
    public partial interface IAmazonEC2InstanceConnect : IAmazonService, IDisposable
    {

        
        #region  SendSSHPublicKey


        /// <summary>
        /// Pushes an SSH public key to a particular OS user on a given EC2 instance for 60 seconds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the SendSSHPublicKey service method, as returned by EC2InstanceConnect.</returns>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.AuthException">
        /// Indicates that either your AWS credentials are invalid or you do not have access to
        /// the EC2 instance.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceNotFoundException">
        /// Indicates that the instance requested was not found in the given zone. Check that
        /// you have provided a valid instance ID and the correct zone.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.InvalidArgsException">
        /// Indicates that you provided bad input. Ensure you have a valid instance ID, the correct
        /// zone, and a valid SSH public key.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ServiceException">
        /// Indicates that the service encountered an error. Follow the message's instructions
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ThrottlingException">
        /// Indicates you have been making requests too frequently and have been throttled. Wait
        /// for a while and try again. If higher call volume is warranted contact AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSSHPublicKey">REST API Reference for SendSSHPublicKey Operation</seealso>
        SendSSHPublicKeyResponse SendSSHPublicKey(SendSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendSSHPublicKey operation on AmazonEC2InstanceConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSSHPublicKey">REST API Reference for SendSSHPublicKey Operation</seealso>
        IAsyncResult BeginSendSSHPublicKey(SendSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  SendSSHPublicKeyResult from EC2InstanceConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSSHPublicKey">REST API Reference for SendSSHPublicKey Operation</seealso>
        SendSSHPublicKeyResponse EndSendSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
    }
}