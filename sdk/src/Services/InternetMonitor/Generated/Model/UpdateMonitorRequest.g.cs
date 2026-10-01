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
    /// Container for the parameters to the UpdateMonitor operation. Updates a monitor. You
    /// can update a monitor to change the percentage of traffic to monitor or the maximum
    /// number of city-networks (locations and ASNs), to add or remove resources, or to change
    /// the status of the monitor. Note that you can't change the name of a monitor. <para>
    /// The city-network maximum that you choose is the limit, but you only pay for the number
    /// of city-networks that are actually monitored. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
    /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>. </para>
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonInternetMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property HealthEventsConfig. 
        /// <para>
        /// The list of health score thresholds. A threshold percentage for health scores, along
        /// with other configuration information, determines when Internet Monitor creates a health
        /// event when there's an internet issue that affects your application end users.
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
        /// The maximum number of city-networks to monitor for your application. A city-network
        /// is the location (city) where clients access your application resources from and the
        /// ASN or network provider, such as an internet service provider (ISP), that clients
        /// access the resources through. Setting this limit can help control billing costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500000)]
        public int? MaxCityNetworksToMonitor { get; set; }

        /// <summary>
        /// Checks to see if the MaxCityNetworksToMonitor property is set.
        /// </summary>
        internal bool IsSetMaxCityNetworksToMonitor() => this.MaxCityNetworksToMonitor.HasValue;

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
        /// Gets and sets the property ResourcesToAdd. 
        /// <para>
        /// The resources to include in a monitor, which you provide as a set of Amazon Resource
        /// Names (ARNs). Resources can be VPCs, NLBs, Amazon CloudFront distributions, or Amazon
        /// WorkSpaces directories.
        /// </para>
        ///  
        /// <para>
        /// You can add a combination of VPCs and CloudFront distributions, or you can add WorkSpaces
        /// directories, or you can add NLBs. You can't add NLBs or WorkSpaces directories together
        /// with any other resources.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you add only Amazon Virtual Private Clouds resources, at least one VPC must have
        /// an Internet Gateway attached to it, to make sure that it has internet connectivity.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourcesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourcesToAdd property is set.
        /// </summary>
        internal bool IsSetResourcesToAdd() => this.ResourcesToAdd != null && (this.ResourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcesToRemove. 
        /// <para>
        /// The resources to remove from a monitor, which you provide as a set of Amazon Resource
        /// Names (ARNs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourcesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourcesToRemove property is set.
        /// </summary>
        internal bool IsSetResourcesToRemove() => this.ResourcesToRemove != null && (this.ResourcesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for a monitor. The accepted values for <c>Status</c> with the <c>UpdateMonitor</c>
        /// API call are the following: <c>ACTIVE</c> and <c>INACTIVE</c>. The following values
        /// are <i>not</i> accepted: <c>PENDING</c>, and <c>ERROR</c>.
        /// </para>
        /// </summary>
        public MonitorConfigState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrafficPercentageToMonitor. 
        /// <para>
        /// The percentage of the internet-facing traffic for your application that you want to
        /// monitor with this monitor. If you set a city-networks maximum, that limit overrides
        /// the traffic percentage that you set.
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
