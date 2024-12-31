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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTags operation.
    /// Returns all resource tags for an Amazon OpenSearch Service domain, data source, or
    /// application. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-awsresourcetagging.html">Tagging
    /// Amazon OpenSearch Service resources</a>.
    /// </summary>
    public partial class ListTagsRequest : AmazonOpenSearchServiceRequest
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// Amazon Resource Name (ARN) for the domain, data source, or application to view tags
        /// for.
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

    }
}