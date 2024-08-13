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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information for groups.
    /// </summary>
    public partial class GroupSummary
    {
        private string _groupId;
        private long? _orderingId;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the group you want group summary information on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property OrderingId. 
        /// <para>
        /// The timestamp identifier used for the latest <c>PUT</c> or <c>DELETE</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32535158400000)]
        public long? OrderingId
        {
            get { return this._orderingId; }
            set { this._orderingId = value; }
        }

        // Check to see if OrderingId property is set
        internal bool IsSetOrderingId()
        {
            return this._orderingId.HasValue; 
        }

    }
}