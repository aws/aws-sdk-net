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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateManagedInstanceRole operation.
    /// Changes the Identity and Access Management (IAM) role that is assigned to the on-premises
    /// server, edge device, or virtual machines (VM). IAM roles are first assigned to these
    /// hybrid nodes during the activation process. For more information, see <a>CreateActivation</a>.
    /// </summary>
    public partial class UpdateManagedInstanceRoleRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _iamRole;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role you want to assign or change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node where you want to update the role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=124)]
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

    }
}