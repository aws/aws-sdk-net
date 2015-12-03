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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// The metadata about the Inspector application data metrics collected by the agent.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>GetAssessmentTelemetry</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class Telemetry
    {
        private List<MessageTypeTelemetry> _messageTypeTelemetries = new List<MessageTypeTelemetry>();
        private string _status;

        /// <summary>
        /// Gets and sets the property MessageTypeTelemetries. 
        /// <para>
        /// Counts of individual metrics received by Inspector from the agent.
        /// </para>
        /// </summary>
        public List<MessageTypeTelemetry> MessageTypeTelemetries
        {
            get { return this._messageTypeTelemetries; }
            set { this._messageTypeTelemetries = value; }
        }

        // Check to see if MessageTypeTelemetries property is set
        internal bool IsSetMessageTypeTelemetries()
        {
            return this._messageTypeTelemetries != null && this._messageTypeTelemetries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The category of the individual metrics that together constitute the telemetry that
        /// Inspector received from the agent.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}