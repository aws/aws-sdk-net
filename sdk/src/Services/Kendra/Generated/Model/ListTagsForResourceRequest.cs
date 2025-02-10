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
    /// Container for the parameters to the ListTagsForResource operation.
    /// Gets a list of tags associated with a resource. Indexes, FAQs, data sources, and other
    /// resources can have tags associated with them.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonKendraRequest
    {
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the index, FAQ, data source, or other resource to
        /// get a list of tags for. For example, the ARN of an index is constructed as follows:
        /// <i>arn:aws:kendra:your-region:your-account-id:index/index-id</i> For information on
        /// how to construct an ARN for all types of Amazon Kendra resources, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonkendra.html#amazonkendra-resources-for-iam-policies">Resource
        /// types</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
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

    }
}