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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the PutTelemetryRecords operation.
    /// Used by the AWS X-Ray daemon to upload telemetry.
    /// </summary>
    public partial class PutTelemetryRecordsRequest : AmazonXRayRequest
    {
        private string _ec2InstanceId;
        private string _hostname;
        private string _resourceARN;
        private List<TelemetryRecord> _telemetryRecords = new List<TelemetryRecord>();

        /// <summary>
        /// Gets and sets the property EC2InstanceId. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string EC2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if EC2InstanceId property is set
        internal bool IsSetEC2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetryRecords. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public List<TelemetryRecord> TelemetryRecords
        {
            get { return this._telemetryRecords; }
            set { this._telemetryRecords = value; }
        }

        // Check to see if TelemetryRecords property is set
        internal bool IsSetTelemetryRecords()
        {
            return this._telemetryRecords != null && this._telemetryRecords.Count > 0; 
        }

    }
}