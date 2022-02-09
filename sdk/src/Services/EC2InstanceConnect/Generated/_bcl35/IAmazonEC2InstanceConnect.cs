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
    /// Amazon EC2 Instance Connect enables system administrators to publish one-time use
    /// SSH public keys to EC2, providing users a simple and secure way to connect to their
    /// instances.
    /// </summary>
    public partial interface IAmazonEC2InstanceConnect : IAmazonService, IDisposable
    {




        
        #region  SendSerialConsoleSSHPublicKey


        /// <summary>
        /// Pushes an SSH public key to the specified EC2 instance. The key remains for 60 seconds,
        /// which gives you 60 seconds to establish a serial console connection to the instance
        /// using SSH. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-serial-console.html">EC2
        /// Serial Console</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendSerialConsoleSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the SendSerialConsoleSSHPublicKey service method, as returned by EC2InstanceConnect.</returns>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.AuthException">
        /// Either your AWS credentials are not valid or you do not have access to the EC2 instance.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceNotFoundException">
        /// The specified instance was not found.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceStateInvalidException">
        /// Unable to connect because the instance is not in a valid state. Connecting to a stopped
        /// or terminated instance is not supported. If the instance is stopped, start your instance,
        /// and try to connect again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceTypeInvalidException">
        /// The instance type is not supported for connecting via the serial console. Only Nitro
        /// instance types are currently supported.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.InvalidArgsException">
        /// One of the parameters is not valid.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.SerialConsoleAccessDisabledException">
        /// Your account is not authorized to use the EC2 Serial Console. To authorize your account,
        /// run the EnableSerialConsoleAccess API. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_EnableSerialConsoleAccess.html">EnableSerialConsoleAccess</a>
        /// in the <i>Amazon EC2 API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.SerialConsoleSessionLimitExceededException">
        /// The instance currently has 1 active serial console session. Only 1 session is supported
        /// at a time.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.SerialConsoleSessionUnavailableException">
        /// Unable to start a serial console session. Please try again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ServiceException">
        /// The service encountered an error. Follow the instructions in the error message and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ThrottlingException">
        /// The requests were made too frequently and have been throttled. Wait a while and try
        /// again. To increase the limit on your request frequency, contact AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSerialConsoleSSHPublicKey">REST API Reference for SendSerialConsoleSSHPublicKey Operation</seealso>
        SendSerialConsoleSSHPublicKeyResponse SendSerialConsoleSSHPublicKey(SendSerialConsoleSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendSerialConsoleSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendSerialConsoleSSHPublicKey operation on AmazonEC2InstanceConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendSerialConsoleSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSerialConsoleSSHPublicKey">REST API Reference for SendSerialConsoleSSHPublicKey Operation</seealso>
        IAsyncResult BeginSendSerialConsoleSSHPublicKey(SendSerialConsoleSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendSerialConsoleSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendSerialConsoleSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  SendSerialConsoleSSHPublicKeyResult from EC2InstanceConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-instance-connect-2018-04-02/SendSerialConsoleSSHPublicKey">REST API Reference for SendSerialConsoleSSHPublicKey Operation</seealso>
        SendSerialConsoleSSHPublicKeyResponse EndSendSerialConsoleSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  SendSSHPublicKey


        /// <summary>
        /// Pushes an SSH public key to the specified EC2 instance for use by the specified user.
        /// The key remains for 60 seconds. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Connect-using-EC2-Instance-Connect.html">Connect
        /// to your Linux instance using EC2 Instance Connect</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the SendSSHPublicKey service method, as returned by EC2InstanceConnect.</returns>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.AuthException">
        /// Either your AWS credentials are not valid or you do not have access to the EC2 instance.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceNotFoundException">
        /// The specified instance was not found.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.EC2InstanceStateInvalidException">
        /// Unable to connect because the instance is not in a valid state. Connecting to a stopped
        /// or terminated instance is not supported. If the instance is stopped, start your instance,
        /// and try to connect again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.InvalidArgsException">
        /// One of the parameters is not valid.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ServiceException">
        /// The service encountered an error. Follow the instructions in the error message and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.EC2InstanceConnect.Model.ThrottlingException">
        /// The requests were made too frequently and have been throttled. Wait a while and try
        /// again. To increase the limit on your request frequency, contact AWS Support.
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