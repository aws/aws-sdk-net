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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the GetCampaign operation.
    /// </summary>
    public partial class GetCampaignResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the campaign. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollectionScheme. 
        /// <para>
        ///  Information about the data collection scheme associated with the campaign. 
        /// </para>
        /// </summary>
        public CollectionScheme CollectionScheme { get; set; }

        /// <summary>
        /// Checks to see if the CollectionScheme property is set.
        /// </summary>
        internal bool IsSetCollectionScheme() => this.CollectionScheme != null;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        ///  Whether to compress signals before transmitting data to Amazon Web Services IoT FleetWise.
        /// If <c>OFF</c> is specified, the signals aren't compressed. If it's not specified,
        /// <c>SNAPPY</c> is used. 
        /// </para>
        /// </summary>
        public Compression Compression { get; set; }

        /// <summary>
        /// Checks to see if the Compression property is set.
        /// </summary>
        internal bool IsSetCompression() => this.Compression != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time the campaign was created in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). 
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// and analytics. 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon Timestream to access and analyze time series data, and Timestream
        /// to query vehicle data so that you can identify trends and patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<DataDestinationConfig> DataDestinationConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<DataDestinationConfig>() : null;

        /// <summary>
        /// Checks to see if the DataDestinationConfigs property is set.
        /// </summary>
        internal bool IsSetDataDestinationConfigs() => this.DataDestinationConfigs != null && (this.DataDestinationConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        ///  A list of vehicle attributes associated with the campaign. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5)]
        public List<string> DataExtraDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataExtraDimensions property is set.
        /// </summary>
        internal bool IsSetDataExtraDimensions() => this.DataExtraDimensions != null && (this.DataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataPartitions. 
        /// <para>
        /// The data partitions associated with the signals collected from the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<DataPartition> DataPartitions { get; set; } = AWSConfigs.InitializeCollections ? new List<DataPartition>() : null;

        /// <summary>
        /// Checks to see if the DataPartitions property is set.
        /// </summary>
        internal bool IsSetDataPartitions() => this.DataPartitions != null && (this.DataPartitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiagnosticsMode. 
        /// <para>
        ///  Option for a vehicle to send diagnostic trouble codes to Amazon Web Services IoT
        /// FleetWise. 
        /// </para>
        /// </summary>
        public DiagnosticsMode DiagnosticsMode { get; set; }

        /// <summary>
        /// Checks to see if the DiagnosticsMode property is set.
        /// </summary>
        internal bool IsSetDiagnosticsMode() => this.DiagnosticsMode != null;

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        ///  The time the campaign expires, in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). Vehicle data won't be collected after the campaign expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the campaign was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PostTriggerCollectionDuration. 
        /// <para>
        ///  How long (in seconds) to collect raw data after a triggering event initiates the
        /// collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4294967295)]
        public long? PostTriggerCollectionDuration { get; set; }

        /// <summary>
        /// Checks to see if the PostTriggerCollectionDuration property is set.
        /// </summary>
        internal bool IsSetPostTriggerCollectionDuration() => this.PostTriggerCollectionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        ///  A number indicating the priority of one campaign over another campaign for a certain
        /// vehicle or fleet. A campaign with the lowest value is deployed to vehicles before
        /// any other campaigns.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        ///  The ARN of a signal catalog. 
        /// </para>
        /// </summary>
        public string SignalCatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the SignalCatalogArn property is set.
        /// </summary>
        internal bool IsSetSignalCatalogArn() => this.SignalCatalogArn != null;

        /// <summary>
        /// Gets and sets the property SignalsToCollect. 
        /// <para>
        ///  Information about a list of signals to collect data on. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1000)]
        public List<SignalInformation> SignalsToCollect { get; set; } = AWSConfigs.InitializeCollections ? new List<SignalInformation>() : null;

        /// <summary>
        /// Checks to see if the SignalsToCollect property is set.
        /// </summary>
        internal bool IsSetSignalsToCollect() => this.SignalsToCollect != null && (this.SignalsToCollect.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalsToFetch. 
        /// <para>
        /// Information about a list of signals to fetch data from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2)]
        public List<SignalFetchInformation> SignalsToFetch { get; set; } = AWSConfigs.InitializeCollections ? new List<SignalFetchInformation>() : null;

        /// <summary>
        /// Checks to see if the SignalsToFetch property is set.
        /// </summary>
        internal bool IsSetSignalsToFetch() => this.SignalsToFetch != null && (this.SignalsToFetch.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpoolingMode. 
        /// <para>
        ///  Whether to store collected data after a vehicle lost a connection with the cloud.
        /// After a connection is re-established, the data is automatically forwarded to Amazon
        /// Web Services IoT FleetWise. 
        /// </para>
        /// </summary>
        public SpoolingMode SpoolingMode { get; set; }

        /// <summary>
        /// Checks to see if the SpoolingMode property is set.
        /// </summary>
        internal bool IsSetSpoolingMode() => this.SpoolingMode != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The time, in milliseconds, to deliver a campaign after it was approved.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the campaign. The status can be one of: <c>CREATING</c>, <c>WAITING_FOR_APPROVAL</c>,
        /// <c>RUNNING</c>, and <c>SUSPENDED</c>. 
        /// </para>
        /// </summary>
        public CampaignStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        ///  The ARN of the vehicle or the fleet targeted by the campaign. 
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
