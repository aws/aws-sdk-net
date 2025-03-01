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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// List tags for an Amazon Bedrock Data Automation resource
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonBedrockDataAutomationRuntimeRequest
    {
        private string _resourcearn;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourcearn; }
            set { this._resourcearn = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourcearn != null;
        }

    }
}