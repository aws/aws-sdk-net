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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// This is the response object from the GetMonitor operation.
    /// </summary>
    public partial class GetMonitorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HealthEventsConfig. 
        /// <para>
        /// The list of health event threshold configurations. The threshold percentage for a
        /// health score determines, along with other configuration information, when Internet
        /// Monitor creates a health event when there's an internet issue that affects your application
        /// end users.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-overview.html#IMUpdateThresholdFromOverview">
        /// Change health event thresholds</a> in the Internet Monitor section of the <i>CloudWatch
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public HealthEventsConfig HealthEventsConfig { get; set; }

        /// <summary>
        /// Checks to see if the HealthEventsConfig property is set.
        /// </summary>
        internal bool IsSetHealthEventsConfig() => this.HealthEventsConfig != null;

        /// <summary>
        /// Gets and sets the property InternetMeasurementsLogDelivery. 
        /// <para>
        /// Publish internet measurements for Internet Monitor to another location, such as an
        /// Amazon S3 bucket. The measurements are also published to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public InternetMeasurementsLogDelivery InternetMeasurementsLogDelivery { get; set; }

        /// <summary>
        /// Checks to see if the InternetMeasurementsLogDelivery property is set.
        /// </summary>
        internal bool IsSetInternetMeasurementsLogDelivery() => this.InternetMeasurementsLogDelivery != null;

        /// <summary>
        /// Gets and sets the property MaxCityNetworksToMonitor. 
        /// <para>
        /// The maximum number of city-networks to monitor for your resources. A city-network
        /// is the location (city) where clients access your application resources from and the
        /// ASN or network provider, such as an internet service provider (ISP), that clients
        /// access the resources through. This limit can help control billing costs.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value </a> in the Amazon CloudWatch Internet Monitor section
        /// of the <i>CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500000)]
        public int? MaxCityNetworksToMonitor { get; set; }

        /// <summary>
        /// Checks to see if the MaxCityNetworksToMonitor property is set.
        /// </summary>
        internal bool IsSetMaxCityNetworksToMonitor() => this.MaxCityNetworksToMonitor.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The last time that the monitor was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 512)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The health of the data processing for the monitor.
        /// </para>
        /// </summary>
        public MonitorProcessingStatusCode ProcessingStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingStatus property is set.
        /// </summary>
        internal bool IsSetProcessingStatus() => this.ProcessingStatus != null;

        /// <summary>
        /// Gets and sets the property ProcessingStatusInfo. 
        /// <para>
        /// Additional information about the health of the data processing for the monitor.
        /// </para>
        /// </summary>
        public string ProcessingStatusInfo { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingStatusInfo property is set.
        /// </summary>
        internal bool IsSetProcessingStatusInfo() => this.ProcessingStatusInfo != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources monitored by the monitor. Resources are listed by their Amazon Resource
        /// Names (ARNs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitorConfigState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that have been added to monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficPercentageToMonitor. 
        /// <para>
        /// The percentage of the internet-facing traffic for your application to monitor with
        /// this monitor. If you set a city-networks maximum, that limit overrides the traffic
        /// percentage that you set.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMTrafficPercentage.html">Choosing
        /// an application traffic percentage to monitor </a> in the Amazon CloudWatch Internet
        /// Monitor section of the <i>CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? TrafficPercentageToMonitor { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPercentageToMonitor property is set.
        /// </summary>
        internal bool IsSetTrafficPercentageToMonitor() => this.TrafficPercentageToMonitor.HasValue;
    }
}
