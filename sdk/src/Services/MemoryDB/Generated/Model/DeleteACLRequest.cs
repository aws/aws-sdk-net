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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteACL operation.
    /// Deletes an Access Control List. The ACL must first be disassociated from the cluster
    /// before it can be deleted. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
    /// users with Access Contol Lists (ACLs)</a>.
    /// </summary>
    public partial class DeleteACLRequest : AmazonMemoryDBRequest
    {
        private string _aclName;

        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ACLName
        {
            get { return this._aclName; }
            set { this._aclName = value; }
        }

        // Check to see if ACLName property is set
        internal bool IsSetACLName()
        {
            return this._aclName != null;
        }

    }
}