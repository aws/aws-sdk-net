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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMonitor operation.
    /// Updates a monitor. You can update a monitor to change the maximum number of city-networks
    /// (locations and ASNs or internet service providers), to add or remove resources, or
    /// to change the status of the monitor. Note that you can't change the name of a monitor.
    /// 
    ///  
    /// <para>
    /// The city-network maximum that you choose is the limit, but you only pay for the number
    /// of city-networks that are actually monitored. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/IMCityNetworksMaximum.html">Choosing
    /// a city-network maximum value</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonInternetMonitorRequest
    {
        private string _clientToken;
        private InternetMeasurementsLogDelivery _internetMeasurementsLogDelivery;
        private int? _maxCityNetworksToMonitor;
        private string _monitorName;
        private List<string> _resourcesToAdd = new List<string>();
        private List<string> _resourcesToRemove = new List<string>();
        private MonitorConfigState _status;
        private int? _trafficPercentageToMonitor;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. You should not reuse the same client token for other API
        /// requests.
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
        /// Gets and sets the property InternetMeasurementsLogDelivery. 
        /// <para>
        /// Publish internet measurements for Internet Monitor to another location, such as an
        /// Amazon S3 bucket. The measurements are also published to Amazon CloudWatch Logs.
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
        /// network or ASN, such as an internet service provider, that clients access the resources
        /// through.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500000)]
        public int MaxCityNetworksToMonitor
        {
            get { return this._maxCityNetworksToMonitor.GetValueOrDefault(); }
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
        /// Gets and sets the property ResourcesToAdd. 
        /// <para>
        /// The resources to include in a monitor, which you provide as a set of Amazon Resource
        /// Names (ARNs).
        /// </para>
        ///  
        /// <para>
        /// You can add a combination of Amazon Virtual Private Clouds (VPCs) and Amazon CloudFront
        /// distributions, or you can add Amazon WorkSpaces directories. You can't add all three
        /// types of resources.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you add only VPC resources, at least one VPC must have an Internet Gateway attached
        /// to it, to make sure that it has internet connectivity.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> ResourcesToAdd
        {
            get { return this._resourcesToAdd; }
            set { this._resourcesToAdd = value; }
        }

        // Check to see if ResourcesToAdd property is set
        internal bool IsSetResourcesToAdd()
        {
            return this._resourcesToAdd != null && this._resourcesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourcesToRemove. 
        /// <para>
        /// The resources to remove from a monitor, which you provide as a set of Amazon Resource
        /// Names (ARNs).
        /// </para>
        /// </summary>
        public List<string> ResourcesToRemove
        {
            get { return this._resourcesToRemove; }
            set { this._resourcesToRemove = value; }
        }

        // Check to see if ResourcesToRemove property is set
        internal bool IsSetResourcesToRemove()
        {
            return this._resourcesToRemove != null && this._resourcesToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for a monitor. The accepted values for <code>Status</code> with the <code>UpdateMonitor</code>
        /// API call are the following: <code>ACTIVE</code> and <code>INACTIVE</code>. The following
        /// values are <i>not</i> accepted: <code>PENDING</code>, and <code>ERROR</code>.
        /// </para>
        /// </summary>
        public MonitorConfigState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPercentageToMonitor. 
        /// <para>
        /// The percentage of the internet-facing traffic for your application that you want to
        /// monitor with this monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int TrafficPercentageToMonitor
        {
            get { return this._trafficPercentageToMonitor.GetValueOrDefault(); }
            set { this._trafficPercentageToMonitor = value; }
        }

        // Check to see if TrafficPercentageToMonitor property is set
        internal bool IsSetTrafficPercentageToMonitor()
        {
            return this._trafficPercentageToMonitor.HasValue; 
        }

    }
}