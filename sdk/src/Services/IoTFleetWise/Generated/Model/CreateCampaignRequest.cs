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
    /// Container for the parameters to the CreateCampaign operation.
    /// Creates an orchestration of data collection rules. The Amazon Web Services IoT FleetWise
    /// Edge Agent software running in vehicles uses campaigns to decide how to collect and
    /// transfer data to the cloud. You create campaigns in the cloud. After you or your team
    /// approve campaigns, Amazon Web Services IoT FleetWise automatically deploys them to
    /// vehicles. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/campaigns.html">Collect
    /// and transfer data with campaigns</a> in the <i>Amazon Web Services IoT FleetWise Developer
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateCampaignRequest : AmazonIoTFleetWiseRequest
    {
        private CollectionScheme _collectionScheme;
        private Compression _compression;
        private List<DataDestinationConfig> _dataDestinationConfigs = AWSConfigs.InitializeCollections ? new List<DataDestinationConfig>() : null;
        private List<string> _dataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataPartition> _dataPartitions = AWSConfigs.InitializeCollections ? new List<DataPartition>() : null;
        private string _description;
        private DiagnosticsMode _diagnosticsMode;
        private DateTime? _expiryTime;
        private string _name;
        private long? _postTriggerCollectionDuration;
        private int? _priority;
        private string _signalCatalogArn;
        private List<SignalInformation> _signalsToCollect = AWSConfigs.InitializeCollections ? new List<SignalInformation>() : null;
        private List<SignalFetchInformation> _signalsToFetch = AWSConfigs.InitializeCollections ? new List<SignalFetchInformation>() : null;
        private SpoolingMode _spoolingMode;
        private DateTime? _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property CollectionScheme. 
        /// <para>
        ///  The data collection scheme associated with the campaign. You can specify a scheme
        /// that collects data based on time or an event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CollectionScheme CollectionScheme
        {
            get { return this._collectionScheme; }
            set { this._collectionScheme = value; }
        }

        // Check to see if CollectionScheme property is set
        internal bool IsSetCollectionScheme()
        {
            return this._collectionScheme != null;
        }

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// Determines whether to compress signals before transmitting data to Amazon Web Services
        /// IoT FleetWise. If you don't want to compress the signals, use <c>OFF</c>. If it's
        /// not specified, <c>SNAPPY</c> is used. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>SNAPPY</c> 
        /// </para>
        /// </summary>
        public Compression Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }

        // Check to see if Compression property is set
        internal bool IsSetCompression()
        {
            return this._compression != null;
        }

        /// <summary>
        /// Gets and sets the property DataDestinationConfigs. 
        /// <para>
        /// The destination where the campaign sends data. You can send data to an MQTT topic,
        /// or store it in Amazon S3 or Amazon Timestream.
        /// </para>
        ///  
        /// <para>
        /// MQTT is the publish/subscribe messaging protocol used by Amazon Web Services IoT to
        /// communicate with your devices.
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 optimizes the cost of data storage and provides additional mechanisms to
        /// use vehicle data, such as data lakes, centralized data storage, data processing pipelines,
        /// and analytics. Amazon Web Services IoT FleetWise supports at-least-once file delivery
        /// to S3. Your vehicle data is stored on multiple Amazon Web Services IoT FleetWise servers
        /// for redundancy and high availability.
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon Timestream to access and analyze time series data, and Timestream
        /// to query vehicle data so that you can identify trends and patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<DataDestinationConfig> DataDestinationConfigs
        {
            get { return this._dataDestinationConfigs; }
            set { this._dataDestinationConfigs = value; }
        }

        // Check to see if DataDestinationConfigs property is set
        internal bool IsSetDataDestinationConfigs()
        {
            return this._dataDestinationConfigs != null && (this._dataDestinationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes to associate with a campaign. 
        /// </para>
        ///  
        /// <para>
        /// Enrich the data with specified vehicle attributes. For example, add <c>make</c> and
        /// <c>model</c> to the campaign, and Amazon Web Services IoT FleetWise will associate
        /// the data with those attributes as dimensions in Amazon Timestream. You can then query
        /// the data against <c>make</c> and <c>model</c>.
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
        [AWSProperty(Sensitive=true, Min=0, Max=5)]
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
        /// Gets and sets the property DataPartitions. 
        /// <para>
        /// The data partitions associated with the signals collected from the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<DataPartition> DataPartitions
        {
            get { return this._dataPartitions; }
            set { this._dataPartitions = value; }
        }

        // Check to see if DataPartitions property is set
        internal bool IsSetDataPartitions()
        {
            return this._dataPartitions != null && (this._dataPartitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the campaign to help identify its purpose.
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
        /// Gets and sets the property DiagnosticsMode. 
        /// <para>
        /// Option for a vehicle to send diagnostic trouble codes to Amazon Web Services IoT FleetWise.
        /// If you want to send diagnostic trouble codes, use <c>SEND_ACTIVE_DTCS</c>. If it's
        /// not specified, <c>OFF</c> is used.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>OFF</c> 
        /// </para>
        /// </summary>
        public DiagnosticsMode DiagnosticsMode
        {
            get { return this._diagnosticsMode; }
            set { this._diagnosticsMode = value; }
        }

        // Check to see if DiagnosticsMode property is set
        internal bool IsSetDiagnosticsMode()
        {
            return this._diagnosticsMode != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The time the campaign expires, in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). Vehicle data isn't collected after the campaign expires. 
        /// </para>
        ///  
        /// <para>
        /// Default: 253402214400 (December 31, 9999, 00:00:00 UTC)
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }

        // Check to see if ExpiryTime property is set
        internal bool IsSetExpiryTime()
        {
            return this._expiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the campaign to create. 
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
        /// Gets and sets the property PostTriggerCollectionDuration. 
        /// <para>
        /// How long (in milliseconds) to collect raw data after a triggering event initiates
        /// the collection. If it's not specified, <c>0</c> is used.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long? PostTriggerCollectionDuration
        {
            get { return this._postTriggerCollectionDuration; }
            set { this._postTriggerCollectionDuration = value; }
        }

        // Check to see if PostTriggerCollectionDuration property is set
        internal bool IsSetPostTriggerCollectionDuration()
        {
            return this._postTriggerCollectionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// A number indicating the priority of one campaign over another campaign for a certain
        /// vehicle or fleet. A campaign with the lowest value is deployed to vehicles before
        /// any other campaigns. If it's not specified, <c>0</c> is used. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        [Obsolete("priority is no longer used or needed as input")]
        [AWSProperty(Min=0)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signal catalog to associate with the campaign.
        /// 
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
        /// Gets and sets the property SignalsToCollect. 
        /// <para>
        /// A list of information about signals to collect. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you upload a signal as a condition in a data partition for a campaign, then those
        /// same signals must be included in <c>signalsToCollect</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public List<SignalInformation> SignalsToCollect
        {
            get { return this._signalsToCollect; }
            set { this._signalsToCollect = value; }
        }

        // Check to see if SignalsToCollect property is set
        internal bool IsSetSignalsToCollect()
        {
            return this._signalsToCollect != null && (this._signalsToCollect.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SignalsToFetch. 
        /// <para>
        /// A list of information about signals to fetch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2)]
        public List<SignalFetchInformation> SignalsToFetch
        {
            get { return this._signalsToFetch; }
            set { this._signalsToFetch = value; }
        }

        // Check to see if SignalsToFetch property is set
        internal bool IsSetSignalsToFetch()
        {
            return this._signalsToFetch != null && (this._signalsToFetch.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpoolingMode. 
        /// <para>
        /// Determines whether to store collected data after a vehicle lost a connection with
        /// the cloud. After a connection is re-established, the data is automatically forwarded
        /// to Amazon Web Services IoT FleetWise. If you want to store collected data when a vehicle
        /// loses connection with the cloud, use <c>TO_DISK</c>. If it's not specified, <c>OFF</c>
        /// is used.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>OFF</c> 
        /// </para>
        /// </summary>
        public SpoolingMode SpoolingMode
        {
            get { return this._spoolingMode; }
            set { this._spoolingMode = value; }
        }

        // Check to see if SpoolingMode property is set
        internal bool IsSetSpoolingMode()
        {
            return this._spoolingMode != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time, in milliseconds, to deliver a campaign after it was approved. If it's not
        /// specified, <c>0</c> is used.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the campaign.
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

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        ///  The ARN of the vehicle or fleet to deploy a campaign to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}