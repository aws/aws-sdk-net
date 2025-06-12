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
    /// Container for the parameters to the CreateStateTemplate operation.
    /// Creates a state template. State templates contain state properties, which are signals
    /// that belong to a signal catalog that is synchronized between the Amazon Web Services
    /// IoT FleetWise Edge and the Amazon Web Services Cloud.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateStateTemplateRequest : AmazonIoTFleetWiseRequest
    {
        private List<string> _dataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private List<string> _metadataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _signalCatalogArn;
        private List<string> _stateTemplateProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes to associate with the payload published on the state
        /// template's MQTT topic. (See <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/process-visualize-data.html#process-last-known-state-vehicle-data">
        /// Processing last known state vehicle data using MQTT messaging</a>). For example, if
        /// you add <c>Vehicle.Attributes.Make</c> and <c>Vehicle.Attributes.Model</c> attributes,
        /// Amazon Web Services IoT FleetWise will enrich the protobuf encoded payload with those
        /// attributes in the <c>extraDimensions</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> DataExtraDimensions
        {
            get { return this._dataExtraDimensions; }
            set { this._dataExtraDimensions = value; }
        }

        // Check to see if DataExtraDimensions property is set
        internal bool IsSetDataExtraDimensions()
        {
            return this._dataExtraDimensions != null && (this._dataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property MetadataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes to associate with user properties of the messages published
        /// on the state template's MQTT topic. (See <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/process-visualize-data.html#process-last-known-state-vehicle-data">
        /// Processing last known state vehicle data using MQTT messaging</a>). For example, if
        /// you add <c>Vehicle.Attributes.Make</c> and <c>Vehicle.Attributes.Model</c> attributes,
        /// Amazon Web Services IoT FleetWise will include these attributes as User Properties
        /// with the MQTT message.
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> MetadataExtraDimensions
        {
            get { return this._metadataExtraDimensions; }
            set { this._metadataExtraDimensions = value; }
        }

        // Check to see if MetadataExtraDimensions property is set
        internal bool IsSetMetadataExtraDimensions()
        {
            return this._metadataExtraDimensions != null && (this._metadataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state template.
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
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        /// The ARN of the signal catalog associated with the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SignalCatalogArn
        {
            get { return this._signalCatalogArn; }
            set { this._signalCatalogArn = value; }
        }

        // Check to see if SignalCatalogArn property is set
        internal bool IsSetSignalCatalogArn()
        {
            return this._signalCatalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateTemplateProperties. 
        /// <para>
        /// A list of signals from which data is collected. The state template properties contain
        /// the fully qualified names of the signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<string> StateTemplateProperties
        {
            get { return this._stateTemplateProperties; }
            set { this._stateTemplateProperties = value; }
        }

        // Check to see if StateTemplateProperties property is set
        internal bool IsSetStateTemplateProperties()
        {
            return this._stateTemplateProperties != null && (this._stateTemplateProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the state template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}