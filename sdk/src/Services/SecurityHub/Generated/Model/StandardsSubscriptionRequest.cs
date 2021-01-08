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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The standard that you want to enable.
    /// </summary>
    public partial class StandardsSubscriptionRequest
    {
        private string _standardsArn;
        private Dictionary<string, string> _standardsInput = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The ARN of the standard that you want to enable. To view the list of available standards
        /// and their ARNs, use the <code> <a>DescribeStandards</a> </code> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsInput. 
        /// <para>
        /// A key-value pair of input for the standard.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StandardsInput
        {
            get { return this._standardsInput; }
            set { this._standardsInput = value; }
        }

        // Check to see if StandardsInput property is set
        internal bool IsSetStandardsInput()
        {
            return this._standardsInput != null && this._standardsInput.Count > 0; 
        }

    }
}