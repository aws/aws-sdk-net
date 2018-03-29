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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceLinkedRoleDeletionStatus operation.
    /// Retrieves the status of your service-linked role deletion. After you use the <a>DeleteServiceLinkedRole</a>
    /// API operation to submit a service-linked role for deletion, you can use the <code>DeletionTaskId</code>
    /// parameter in <code>GetServiceLinkedRoleDeletionStatus</code> to check the status of
    /// the deletion. If the deletion fails, this operation returns the reason that it failed,
    /// if that information is returned by the service.
    /// </summary>
    public partial class GetServiceLinkedRoleDeletionStatusRequest : AmazonIdentityManagementServiceRequest
    {
        private string _deletionTaskId;

        /// <summary>
        /// Gets and sets the property DeletionTaskId. 
        /// <para>
        /// The deletion task identifier. This identifier is returned by the <a>DeleteServiceLinkedRole</a>
        /// operation in the format <code>task/aws-service-role/&lt;service-principal-name&gt;/&lt;role-name&gt;/&lt;task-uuid&gt;</code>.
        /// </para>
        /// </summary>
        public string DeletionTaskId
        {
            get { return this._deletionTaskId; }
            set { this._deletionTaskId = value; }
        }

        // Check to see if DeletionTaskId property is set
        internal bool IsSetDeletionTaskId()
        {
            return this._deletionTaskId != null;
        }

    }
}