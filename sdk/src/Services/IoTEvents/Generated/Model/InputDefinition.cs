/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// The definition of the input.
    /// </summary>
    public partial class InputDefinition
    {
        private List<Attribute> _attributes = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes from the JSON payload that are made available by the input. Inputs
        /// are derived from messages sent to the AWS IoT Events system using <code>BatchPutMessage</code>.
        /// Each such message contains a JSON payload, and those attributes (and their paired
        /// values) specified here are available for use in the <code>condition</code> expressions
        /// used by detectors that monitor this input. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}