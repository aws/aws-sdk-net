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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The OpsItem summaries result item.
    /// </summary>
    public partial class OpsEntityItem
    {
        private string _captureTime;
        private List<Dictionary<string, string>> _content = new List<Dictionary<string, string>>();

        /// <summary>
        /// Gets and sets the property CaptureTime. 
        /// <para>
        /// The time OpsItem data was captured.
        /// </para>
        /// </summary>
        public string CaptureTime
        {
            get { return this._captureTime; }
            set { this._captureTime = value; }
        }

        // Check to see if CaptureTime property is set
        internal bool IsSetCaptureTime()
        {
            return this._captureTime != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The detailed data content for an OpsItem summaries result item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public List<Dictionary<string, string>> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && this._content.Count > 0; 
        }

    }
}