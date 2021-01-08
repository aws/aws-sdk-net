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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The collection of tagging definitions for an AWS resource. Tags are key:value pairs
    /// that you can use to categorize and manage your resources, for purposes like billing
    /// or other management. Typically, the tag key represents a category, such as "environment",
    /// and the tag value represents a specific value within that category, such as "test,"
    /// "development," or "production". Or you might set the tag key to "customer" and the
    /// value to the customer name or ID. You can specify one or more tags to add to each
    /// AWS resource, up to 50 tags for a resource.
    /// </para>
    ///  
    /// <para>
    /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
    /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
    /// console. 
    /// </para>
    /// </summary>
    public partial class TagInfoForResource
    {
        private string _resourceARN;
        private List<Tag> _tagList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The array of <a>Tag</a> objects defined for the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}