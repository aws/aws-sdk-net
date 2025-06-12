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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private List<AgentVersion> _agentVersions = AWSConfigs.InitializeCollections ? new List<AgentVersion>() : null;
        private string _description;
        private string _deviceFleetArn;
        private string _deviceFleetName;
        private DeviceStats _deviceStats;
        private List<EdgeModelStat> _modelStats = AWSConfigs.InitializeCollections ? new List<EdgeModelStat>() : null;
        private EdgeOutputConfig _outputConfig;
        private DateTime? _reportGenerated;

        /// <summary>
        /// Gets and sets the property AgentVersions. 
        /// <para>
        /// The versions of Edge Manager agent deployed on the fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentVersion> AgentVersions
        {
            get { return this._agentVersions; }
            set { this._agentVersions = value; }
        }

        // Check to see if AgentVersions property is set
        internal bool IsSetAgentVersions()
        {
            return this._agentVersions != null && (this._agentVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceFleetArn
        {
            get { return this._deviceFleetArn; }
            set { this._deviceFleetArn = value; }
        }

        // Check to see if DeviceFleetArn property is set
        internal bool IsSetDeviceFleetArn()
        {
            return this._deviceFleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceStats. 
        /// <para>
        /// Status of devices.
        /// </para>
        /// </summary>
        public DeviceStats DeviceStats
        {
            get { return this._deviceStats; }
            set { this._deviceStats = value; }
        }

        // Check to see if DeviceStats property is set
        internal bool IsSetDeviceStats()
        {
            return this._deviceStats != null;
        }

        /// <summary>
        /// Gets and sets the property ModelStats. 
        /// <para>
        /// Status of model on device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeModelStat> ModelStats
        {
            get { return this._modelStats; }
            set { this._modelStats = value; }
        }

        // Check to see if ModelStats property is set
        internal bool IsSetModelStats()
        {
            return this._modelStats != null && (this._modelStats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for storing sample data collected by the fleet.
        /// </para>
        /// </summary>
        public EdgeOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ReportGenerated. 
        /// <para>
        /// Timestamp of when the report was generated.
        /// </para>
        /// </summary>
        public DateTime? ReportGenerated
        {
            get { return this._reportGenerated; }
            set { this._reportGenerated = value; }
        }

        // Check to see if ReportGenerated property is set
        internal bool IsSetReportGenerated()
        {
            return this._reportGenerated.HasValue; 
        }

    }
}