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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstance operation. Update the details for
    /// the instance of IAM Identity Center that is owned by the Amazon Web Services account.
    /// <para> In a single <c>UpdateInstance</c> request, you can perform only one of the
    /// following operations: </para> <ul> <li> <para> Update the encryption configuration
    /// of the instance by specifying <c>EncryptionConfiguration</c>. </para> </li> <li> <para>
    /// Enable permission sets for the instance by specifying <c>PermissionSetsEnabled</c>.
    /// </para> </li> </ul> <para> If you specify both <c>EncryptionConfiguration</c> and
    /// <c>PermissionSetsEnabled</c> in a request, the request returns a <c>ValidationException</c>.
    /// To perform both operations, call <c>UpdateInstance</c> separately for each. You can
    /// make the two calls in parallel. </para>
    /// </summary>
    public partial class UpdateInstanceRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Specifies the encryption configuration for your IAM Identity Center instance. You
        /// can use this to configure customer managed KMS keys or Amazon Web Services owned KMS
        /// keys for encrypting your instance data.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance of IAM Identity Center under which the operation will run.
        /// For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Updates the instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionSetsEnabled. 
        /// <para>
        /// Enables permission sets for this Identity Center instance. The only accepted value
        /// is <c>true </c>. After permission sets are enabled, they cannot be disabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't set <c>EncryptionConfiguration</c> and <c>PermissionSetsEnabled</c> in the
        /// same request. To configure both, make two separate <c>UpdateInstance</c> calls. You
        /// can make these calls in parallel.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? PermissionSetsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PermissionSetsEnabled property is set.
        /// </summary>
        internal bool IsSetPermissionSetsEnabled() => this.PermissionSetsEnabled.HasValue;
    }
}
