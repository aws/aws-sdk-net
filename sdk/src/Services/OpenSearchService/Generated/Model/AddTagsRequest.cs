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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation.
    /// Attaches tags to an existing domain. Tags are a set of case-sensitive key value pairs.
    /// An domain can have up to 10 tags. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains.html#managedomains-awsresorcetagging"
    /// target="_blank"> Tagging Amazon OpenSearch Service domains</a> for more information.
    /// </summary>
    public partial class AddTagsRequest : AmazonOpenSearchServiceRequest
    {
        private string _arn;
        private List<Tag> _tagList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// Specify the <code>ARN</code> of the domain you want to add tags to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// List of <code>Tag</code> to add to the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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