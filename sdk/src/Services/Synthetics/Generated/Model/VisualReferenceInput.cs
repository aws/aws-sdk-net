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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VisualReferenceInput
    {
        private string _baseCanaryRunId;
        private List<BaseScreenshot> _baseScreenshots = new List<BaseScreenshot>();

        /// <summary>
        /// Gets and sets the property BaseCanaryRunId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string BaseCanaryRunId
        {
            get { return this._baseCanaryRunId; }
            set { this._baseCanaryRunId = value; }
        }

        // Check to see if BaseCanaryRunId property is set
        internal bool IsSetBaseCanaryRunId()
        {
            return this._baseCanaryRunId != null;
        }

        /// <summary>
        /// Gets and sets the property BaseScreenshots.
        /// </summary>
        public List<BaseScreenshot> BaseScreenshots
        {
            get { return this._baseScreenshots; }
            set { this._baseScreenshots = value; }
        }

        // Check to see if BaseScreenshots property is set
        internal bool IsSetBaseScreenshots()
        {
            return this._baseScreenshots != null && this._baseScreenshots.Count > 0; 
        }

    }
}