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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// The attributes from the JSON payload that are made available by the input. Inputs
    /// are derived from messages sent to the AWS IoT Events system using <c>BatchPutMessage</c>.
    /// Each such message contains a JSON payload. Those attributes (and their paired values)
    /// specified here are available for use in the <c>condition</c> expressions used by detectors.
    /// </summary>
    public partial class Attribute
    {
        private string _jsonPath;

        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// An expression that specifies an attribute-value pair in a JSON structure. Use this
        /// to specify an attribute from the JSON payload that is made available by the input.
        /// Inputs are derived from messages sent to AWS IoT Events (<c>BatchPutMessage</c>).
        /// Each such message contains a JSON payload. The attribute (and its paired value) specified
        /// here are available for use in the <c>condition</c> expressions used by detectors.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Syntax: <c>&lt;field-name&gt;.&lt;field-name&gt;...</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string JsonPath
        {
            get { return this._jsonPath; }
            set { this._jsonPath = value; }
        }

        // Check to see if JsonPath property is set
        internal bool IsSetJsonPath()
        {
            return this._jsonPath != null;
        }

    }
}