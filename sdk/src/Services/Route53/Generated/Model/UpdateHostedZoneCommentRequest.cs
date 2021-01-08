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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHostedZoneComment operation.
    /// Updates the comment for a specified hosted zone.
    /// </summary>
    public partial class UpdateHostedZoneCommentRequest : AmazonRoute53Request
    {
        private string _id;
        private string _comment;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the hosted zone that you want to update the comment for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The new comment for the hosted zone. If you don't specify a value for <code>Comment</code>,
        /// Amazon Route 53 deletes the existing value of the <code>Comment</code> element, if
        /// any.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

    }
}