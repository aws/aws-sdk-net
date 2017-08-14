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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes the specified tag or tags from the specified AWS CloudHSM cluster.
    /// </summary>
    public partial class UntagResourceRequest : AmazonCloudHSMV2Request
    {
        private string _resourceId;
        private List<string> _tagKeyList = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The cluster identifier (ID) for the cluster whose tags you are removing. To find the
        /// cluster ID, use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeyList. 
        /// <para>
        /// A list of one or more tag keys for the tags that you are removing. Specify only the
        /// tag keys, not the tag values.
        /// </para>
        /// </summary>
        public List<string> TagKeyList
        {
            get { return this._tagKeyList; }
            set { this._tagKeyList = value; }
        }

        // Check to see if TagKeyList property is set
        internal bool IsSetTagKeyList()
        {
            return this._tagKeyList != null && this._tagKeyList.Count > 0; 
        }

    }
}