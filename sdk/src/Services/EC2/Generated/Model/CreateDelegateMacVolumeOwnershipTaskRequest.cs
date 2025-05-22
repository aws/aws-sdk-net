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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDelegateMacVolumeOwnershipTask operation.
    /// Delegates ownership of the Amazon EBS root volume for an Apple silicon Mac instance
    /// to an administrative user.
    /// </summary>
    public partial class CreateDelegateMacVolumeOwnershipTaskRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _dryRun;
        private string _instanceId;
        private string _macCredentials;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 Mac instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MacCredentials. 
        /// <para>
        /// Specifies the following credentials:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Internal disk administrative user</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Username</b> - Only the default administrative user (<c>aws-managed-user</c>)
        /// is supported and it is used by default. You can't specify a different administrative
        /// user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Password</b> - If you did not change the default password for <c>aws-managed-user</c>,
        /// specify the default password, which is <i>blank</i>. Otherwise, specify your password.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Amazon EBS root volume administrative user</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Username</b> - If you did not change the default administrative user, specify
        /// <c>ec2-user</c>. Otherwise, specify the username for your administrative user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Password</b> - Specify the password for the administrative user.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The credentials must be specified in the following JSON format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "internalDiskPassword":"<i>internal-disk-admin_password</i>", "rootVolumeUsername":"<i>root-volume-admin_username</i>",
        /// "rootVolumepassword":"<i>root-volume-admin_password</i>" }</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string MacCredentials
        {
            get { return this._macCredentials; }
            set { this._macCredentials = value; }
        }

        // Check to see if MacCredentials property is set
        internal bool IsSetMacCredentials()
        {
            return this._macCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the volume ownership delegation task.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}