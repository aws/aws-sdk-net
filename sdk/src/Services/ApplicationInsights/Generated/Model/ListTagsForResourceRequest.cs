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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Retrieve a list of the tags (keys and values) that are associated with a specified
    /// application. A <i>tag</i> is a label that you optionally define and associate with
    /// an application. Each tag consists of a required <i>tag key</i> and an optional associated
    /// <i>tag value</i>. A tag key is a general label that acts as a category for more specific
    /// tag values. A tag value acts as a descriptor within a tag key.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonApplicationInsightsRequest
    {
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application that you want to retrieve tag information
        /// for.
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