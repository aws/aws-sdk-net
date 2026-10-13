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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the GetDeviceFleetReport operation.
    /// </summary>
    public partial class GetDeviceFleetReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentVersions. 
        /// <para>
        /// The versions of Edge Manager agent deployed on the fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentVersion> AgentVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentVersion>() : null;

        /// <summary>
        /// Checks to see if the AgentVersions property is set.
        /// </summary>
        internal bool IsSetAgentVersions() => this.AgentVersions != null && (this.AgentVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceFleetArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetArn property is set.
        /// </summary>
        internal bool IsSetDeviceFleetArn() => this.DeviceFleetArn != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property DeviceStats. 
        /// <para>
        /// Status of devices.
        /// </para>
        /// </summary>
        public DeviceStats DeviceStats { get; set; }

        /// <summary>
        /// Checks to see if the DeviceStats property is set.
        /// </summary>
        internal bool IsSetDeviceStats() => this.DeviceStats != null;

        /// <summary>
        /// Gets and sets the property ModelStats. 
        /// <para>
        /// Status of model on device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeModelStat> ModelStats { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeModelStat>() : null;

        /// <summary>
        /// Checks to see if the ModelStats property is set.
        /// </summary>
        internal bool IsSetModelStats() => this.ModelStats != null && (this.ModelStats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for storing sample data collected by the fleet.
        /// </para>
        /// </summary>
        public EdgeOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property ReportGenerated. 
        /// <para>
        /// Timestamp of when the report was generated.
        /// </para>
        /// </summary>
        public DateTime? ReportGenerated { get; set; }

        /// <summary>
        /// Checks to see if the ReportGenerated property is set.
        /// </summary>
        internal bool IsSetReportGenerated() => this.ReportGenerated.HasValue;
    }
}
