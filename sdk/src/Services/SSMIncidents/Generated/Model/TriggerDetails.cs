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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about what caused the incident to be created in Incident Manager.
    /// </summary>
    public partial class TriggerDetails
    {
        private string _rawData;
        private string _source;
        private DateTime? _timestamp;
        private string _triggerArn;

        /// <summary>
        /// Gets and sets the property RawData. 
        /// <para>
        /// Raw data passed from either Amazon EventBridge, Amazon CloudWatch, or Incident Manager
        /// when an incident is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string RawData
        {
            get { return this._rawData; }
            set { this._rawData = value; }
        }

        // Check to see if RawData property is set
        internal bool IsSetRawData()
        {
            return this._rawData != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Identifies the service that sourced the event. All events sourced from within Amazon
        /// Web Services begin with "<code>aws.</code>" Customer-generated events can have any
        /// value here, as long as it doesn't begin with "<code>aws.</code>" We recommend the
        /// use of Java package-name style reverse domain-name strings. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time that the incident was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source that detected the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string TriggerArn
        {
            get { return this._triggerArn; }
            set { this._triggerArn = value; }
        }

        // Check to see if TriggerArn property is set
        internal bool IsSetTriggerArn()
        {
            return this._triggerArn != null;
        }

    }
}