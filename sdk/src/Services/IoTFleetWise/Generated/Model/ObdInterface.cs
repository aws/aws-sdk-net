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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// A network interface that specifies the on-board diagnostic (OBD) II network protocol.
    /// </summary>
    public partial class ObdInterface
    {
        private int? _dtcRequestIntervalSeconds;
        private bool? _hasTransmissionEcu;
        private string _name;
        private string _obdStandard;
        private int? _pidRequestIntervalSeconds;
        private int? _requestMessageId;
        private bool? _useExtendedIds;

        /// <summary>
        /// Gets and sets the property DtcRequestIntervalSeconds. 
        /// <para>
        /// The maximum number message requests per diagnostic trouble code per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? DtcRequestIntervalSeconds
        {
            get { return this._dtcRequestIntervalSeconds; }
            set { this._dtcRequestIntervalSeconds = value; }
        }

        // Check to see if DtcRequestIntervalSeconds property is set
        internal bool IsSetDtcRequestIntervalSeconds()
        {
            return this._dtcRequestIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasTransmissionEcu. 
        /// <para>
        /// Whether the vehicle has a transmission control module (TCM).
        /// </para>
        /// </summary>
        public bool? HasTransmissionEcu
        {
            get { return this._hasTransmissionEcu; }
            set { this._hasTransmissionEcu = value; }
        }

        // Check to see if HasTransmissionEcu property is set
        internal bool IsSetHasTransmissionEcu()
        {
            return this._hasTransmissionEcu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObdStandard. 
        /// <para>
        /// The standard OBD II PID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ObdStandard
        {
            get { return this._obdStandard; }
            set { this._obdStandard = value; }
        }

        // Check to see if ObdStandard property is set
        internal bool IsSetObdStandard()
        {
            return this._obdStandard != null;
        }

        /// <summary>
        /// Gets and sets the property PidRequestIntervalSeconds. 
        /// <para>
        /// The maximum number message requests per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? PidRequestIntervalSeconds
        {
            get { return this._pidRequestIntervalSeconds; }
            set { this._pidRequestIntervalSeconds = value; }
        }

        // Check to see if PidRequestIntervalSeconds property is set
        internal bool IsSetPidRequestIntervalSeconds()
        {
            return this._pidRequestIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestMessageId. 
        /// <para>
        /// The ID of the message requesting vehicle data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? RequestMessageId
        {
            get { return this._requestMessageId; }
            set { this._requestMessageId = value; }
        }

        // Check to see if RequestMessageId property is set
        internal bool IsSetRequestMessageId()
        {
            return this._requestMessageId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseExtendedIds. 
        /// <para>
        /// Whether to use extended IDs in the message.
        /// </para>
        /// </summary>
        public bool? UseExtendedIds
        {
            get { return this._useExtendedIds; }
            set { this._useExtendedIds = value; }
        }

        // Check to see if UseExtendedIds property is set
        internal bool IsSetUseExtendedIds()
        {
            return this._useExtendedIds.HasValue; 
        }

    }
}