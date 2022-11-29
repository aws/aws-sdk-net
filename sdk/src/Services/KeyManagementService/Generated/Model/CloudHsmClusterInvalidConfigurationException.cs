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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// The request was rejected because the associated CloudHSM cluster did not meet the
    /// configuration requirements for an CloudHSM key store.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The CloudHSM cluster must be configured with private subnets in at least two different
    /// Availability Zones in the Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
    /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
    /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
    /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
    /// security group ID. These rules are set by default when you create the CloudHSM cluster.
    /// Do not delete or change them. To get information about a particular security group,
    /// use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The CloudHSM cluster must contain at least as many HSMs as the operation requires.
    /// To add HSMs, use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
    /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
    /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
    /// contain at least one active HSM.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about the requirements for an CloudHSM cluster that is associated
    /// with an CloudHSM key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
    /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
    /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
    /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
    /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
    /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
    /// </para>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class CloudHsmClusterInvalidConfigurationException : AmazonKeyManagementServiceException
    {

        /// <summary>
        /// Constructs a new CloudHsmClusterInvalidConfigurationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public CloudHsmClusterInvalidConfigurationException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of CloudHsmClusterInvalidConfigurationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CloudHsmClusterInvalidConfigurationException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of CloudHsmClusterInvalidConfigurationException
        /// </summary>
        /// <param name="innerException"></param>
        public CloudHsmClusterInvalidConfigurationException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of CloudHsmClusterInvalidConfigurationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public CloudHsmClusterInvalidConfigurationException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of CloudHsmClusterInvalidConfigurationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public CloudHsmClusterInvalidConfigurationException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the CloudHsmClusterInvalidConfigurationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected CloudHsmClusterInvalidConfigurationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
#endif

    }
}