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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the DeleteServiceLinkedRole operation.
    /// </summary>
    public partial class DeleteServiceLinkedRoleResponse : AmazonWebServiceResponse
    {
        private string _deletionTaskId;

        /// <summary>
        /// Gets and sets the property DeletionTaskId. 
        /// <para>
        /// The deletion task identifier that you can use to check the status of the deletion.
        /// This identifier is returned in the format <c>task/aws-service-role/&lt;service-principal-name&gt;/&lt;role-name&gt;/&lt;task-uuid&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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