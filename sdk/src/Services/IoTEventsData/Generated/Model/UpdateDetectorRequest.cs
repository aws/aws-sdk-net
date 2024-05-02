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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Information used to update the detector (instance).
    /// </summary>
    public partial class UpdateDetectorRequest
    {
        private string _detectorModelName;
        private string _keyValue;
        private string _messageId;
        private DetectorStateDefinition _state;

        /// <summary>
        /// Gets and sets the property DetectorModelName. 
        /// <para>
        /// The name of the detector model that created the detectors (instances).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DetectorModelName
        {
            get { return this._detectorModelName; }
            set { this._detectorModelName = value; }
        }

        // Check to see if DetectorModelName property is set
        internal bool IsSetDetectorModelName()
        {
            return this._detectorModelName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValue. 
        /// <para>
        /// The value of the input key attribute (identifying the device or system) that caused
        /// the creation of this detector (instance).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyValue
        {
            get { return this._keyValue; }
            set { this._keyValue = value; }
        }

        // Check to see if KeyValue property is set
        internal bool IsSetKeyValue()
        {
            return this._keyValue != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID to assign to the detector update <c>"message"</c>. Each <c>"messageId"</c>
        /// must be unique within each batch sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The new state, variable values, and timer settings of the detector (instance).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DetectorStateDefinition State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}