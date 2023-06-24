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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all metadata tags attached to an DMS resource, including replication instance,
    /// endpoint, subnet group, and migration task. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
    /// <code>Tag</code> </a> data type description.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _resourceArn;
        private List<string> _resourceArnList = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the DMS resource to
        /// list tags for. This returns a list of keys (names of tags) created for the resource
        /// and their associated tag values.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArnList. 
        /// <para>
        /// List of ARNs that identify multiple DMS resources that you want to list tags for.
        /// This returns a list of keys (tag names) and their associated tag values. It also returns
        /// each tag's associated <code>ResourceArn</code> value, which is the ARN of the resource
        /// for which each listed tag is created. 
        /// </para>
        /// </summary>
        public List<string> ResourceArnList
        {
            get { return this._resourceArnList; }
            set { this._resourceArnList = value; }
        }

        // Check to see if ResourceArnList property is set
        internal bool IsSetResourceArnList()
        {
            return this._resourceArnList != null && this._resourceArnList.Count > 0; 
        }

    }
}