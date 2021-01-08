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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// This is the response object from the DeleteSubnetGroup operation.
    /// </summary>
    public partial class DeleteSubnetGroupResponse : AmazonWebServiceResponse
    {
        private string _deletionMessage;

        /// <summary>
        /// Gets and sets the property DeletionMessage. 
        /// <para>
        /// A user-specified message for this action (i.e., a reason for deleting the subnet group).
        /// </para>
        /// </summary>
        public string DeletionMessage
        {
            get { return this._deletionMessage; }
            set { this._deletionMessage = value; }
        }

        // Check to see if DeletionMessage property is set
        internal bool IsSetDeletionMessage()
        {
            return this._deletionMessage != null;
        }

    }
}