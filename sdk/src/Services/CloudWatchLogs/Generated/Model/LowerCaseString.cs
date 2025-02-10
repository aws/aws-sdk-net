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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This processor converts a string to lowercase.
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-lowerCaseString">
    /// lowerCaseString</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LowerCaseString
    {
        private List<string> _withKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property WithKeys. 
        /// <para>
        /// The array caontaining the keys of the fields to convert to lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> WithKeys
        {
            get { return this._withKeys; }
            set { this._withKeys = value; }
        }

        // Check to see if WithKeys property is set
        internal bool IsSetWithKeys()
        {
            return this._withKeys != null && (this._withKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}