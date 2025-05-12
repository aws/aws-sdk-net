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
    /// Container for the parameters to the UntagResource operation.
    /// Use this operation to remove tags on a resource. A tag is a key-value pair where the
    /// key and value are case-sensitive. You can use tags to categorize and track all your
    /// MemoryDB resources. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/Tagging-Resources.html">Tagging
    /// your MemoryDB resources</a>.
    /// 
    ///  
    /// <para>
    /// When you remove tags from multi region clusters, you might not immediately see the
    /// latest effective tags in the ListTags API response due to it being eventually consistent
    /// specifically for multi region clusters. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/Tagging-Resources.html">Tagging
    /// your MemoryDB resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can specify cost-allocation tags for your MemoryDB resources, Amazon generates
    /// a cost allocation report as a comma-separated value (CSV) file with your usage and
    /// costs aggregated by your tags. You can apply tags that represent business categories
    /// (such as cost centers, application names, or owners) to organize your costs across
    /// multiple services. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/tagging.html">Using
    /// Cost Allocation Tags</a>.
    /// </para>
    /// </summary>
    public partial class UntagResourceRequest : AmazonMemoryDBRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to which the tags are to be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The list of keys of the tags that are to be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}