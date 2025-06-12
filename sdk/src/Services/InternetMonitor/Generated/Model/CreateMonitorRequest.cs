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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
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
    /// Container for the parameters to the CreateMonitor operation.
    /// Creates a monitor in Amazon CloudWatch Internet Monitor. A monitor is built based
    /// on information from the application resources that you add: VPCs, Network Load Balancers
    /// (NLBs), Amazon CloudFront distributions, and Amazon WorkSpaces directories. Internet
    /// Monitor then publishes internet measurements from Amazon Web Services that are specific
    /// to the <i>city-networks</i>. That is, the locations and ASNs (typically internet service
    /// providers or ISPs), where clients access your application. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">Using
    /// Amazon CloudWatch Internet Monitor</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you create a monitor, you choose the percentage of traffic that you want to monitor.
    /// You can also set a maximum limit for the number of city-networks where client traffic
    /// is monitored, that caps the total traffic that Internet Monitor monitors. A city-network
    /// maximum is the limit of city-networks, but you only pay for the number of city-networks
    /// that are actually monitored. You can update your monitor at any time to change the
    /// percentage of traffic to monitor or the city-networks maximum. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
    /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateMonitorRequest : AmazonInternetMonitorRequest
    {
        private string _clientToken;
        private HealthEventsConfig _healthEventsConfig;
        private InternetMeasurementsLogDelivery _internetMeasurementsLogDelivery;
        private int? _maxCityNetworksToMonitor;
        private string _monitorName;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _trafficPercentageToMonitor;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. Don't reuse the same client token for other API requests.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property HealthEventsConfig. 
        /// <para>
        /// Defines the threshold percentages and other configuration information for when Amazon
        /// CloudWatch Internet Monitor creates a health event. Internet Monitor creates a health
        /// event when an internet issue that affects your application end users has a health
        /// score percentage that is at or below a specific threshold, and, sometimes, when other
        /// criteria are met.
        /// </para>
        ///  
        /// <para>
        /// If you don't set a health event threshold, the default value is 95%.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-overview.html#IMUpdateThresholdFromOverview">
        /// Change health event thresholds</a> in the Internet Monitor section of the <i>CloudWatch
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public HealthEventsConfig HealthEventsConfig
        {
            get { return this._healthEventsConfig; }
            set { this._healthEventsConfig = value; }
        }

        // Check to see if HealthEventsConfig property is set
        internal bool IsSetHealthEventsConfig()
        {
            return this._healthEventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InternetMeasurementsLogDelivery. 
        /// <para>
        /// Publish internet measurements for Internet Monitor to an Amazon S3 bucket in addition
        /// to CloudWatch Logs.
        /// </para>
        /// </summary>
        public InternetMeasurementsLogDelivery InternetMeasurementsLogDelivery
        {
            get { return this._internetMeasurementsLogDelivery; }
            set { this._internetMeasurementsLogDelivery = value; }
        }

        // Check to see if InternetMeasurementsLogDelivery property is set
        internal bool IsSetInternetMeasurementsLogDelivery()
        {
            return this._internetMeasurementsLogDelivery != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCityNetworksToMonitor. 
        /// <para>
        /// The maximum number of city-networks to monitor for your resources. A city-network
        /// is the location (city) where clients access your application resources from and the
        /// ASN or network provider, such as an internet service provider (ISP), that clients
        /// access the resources through. Setting this limit can help control billing costs.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
        /// a city-network maximum value </a> in the Amazon CloudWatch Internet Monitor section
        /// of the <i>CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500000)]
        public int? MaxCityNetworksToMonitor
        {
            get { return this._maxCityNetworksToMonitor; }
            set { this._maxCityNetworksToMonitor = value; }
        }

        // Check to see if MaxCityNetworksToMonitor property is set
        internal bool IsSetMaxCityNetworksToMonitor()
        {
            return this._maxCityNetworksToMonitor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
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
        /// If you add only Amazon VPC resources, at least one VPC must have an Internet Gateway
        /// attached to it, to make sure that it has internet connectivity.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a monitor. You can add a maximum of 50 tags in Internet Monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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
        [AWSProperty(Min=1, Max=100)]
        public int? TrafficPercentageToMonitor
        {
            get { return this._trafficPercentageToMonitor; }
            set { this._trafficPercentageToMonitor = value; }
        }

        // Check to see if TrafficPercentageToMonitor property is set
        internal bool IsSetTrafficPercentageToMonitor()
        {
            return this._trafficPercentageToMonitor.HasValue; 
        }

    }
}