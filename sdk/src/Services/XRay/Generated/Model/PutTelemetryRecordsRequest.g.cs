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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the PutTelemetryRecords operation. Used by the Amazon
    /// Web Services X-Ray daemon to upload telemetry.
    /// </summary>
    public partial class PutTelemetryRecordsRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property EC2InstanceId. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public string EC2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the EC2InstanceId property is set.
        /// </summary>
        internal bool IsSetEC2InstanceId() => this.EC2InstanceId != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property TelemetryRecords. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TelemetryRecord> TelemetryRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<TelemetryRecord>() : null;

        /// <summary>
        /// Checks to see if the TelemetryRecords property is set.
        /// </summary>
        internal bool IsSetTelemetryRecords() => this.TelemetryRecords != null && (this.TelemetryRecords.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
