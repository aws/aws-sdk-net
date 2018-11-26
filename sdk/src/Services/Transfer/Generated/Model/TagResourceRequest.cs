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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
    /// (ARN). Resources are users, servers, roles, and other entities.
    /// 
    ///  
    /// <para>
    /// There is no response returned from this call.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonTransferRequest
    {
        private string _arn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// An Amazon Resource Name (ARN) for a specific AWS resource, such as a server, user,
        /// or role.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs assigned to ARNs that you can use to group and search for resources
        /// by type. You can attach this metadata to user accounts for any purpose.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}