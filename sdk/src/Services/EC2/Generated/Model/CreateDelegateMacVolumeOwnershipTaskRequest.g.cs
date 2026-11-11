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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 Mac instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

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
        [AWSProperty(Required = true, Sensitive = true)]
        public string MacCredentials { get; set; }

        /// <summary>
        /// Checks to see if the MacCredentials property is set.
        /// </summary>
        internal bool IsSetMacCredentials() => this.MacCredentials != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the volume ownership delegation task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
