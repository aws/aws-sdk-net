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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A RUM app monitor collects telemetry data from your application and sends that data
    /// to RUM. The data includes performance and reliability information such as page load
    /// time, client-side errors, and user behavior.
    /// </summary>
    public partial class AppMonitor
    {
        /// <summary>
        /// Gets and sets the property AppMonitorConfiguration. 
        /// <para>
        /// A structure that contains much of the configuration data for the app monitor.
        /// </para>
        /// </summary>
        public AppMonitorConfiguration AppMonitorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AppMonitorConfiguration property is set.
        /// </summary>
        internal bool IsSetAppMonitorConfiguration() => this.AppMonitorConfiguration != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time that this app monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created != null;

        /// <summary>
        /// Gets and sets the property CustomEvents. 
        /// <para>
        /// Specifies whether this app monitor allows the web client to define and send custom
        /// events.
        /// </para>
        ///  
        /// <para>
        /// For more information about custom events, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-custom-events.html">Send
        /// custom events</a>.
        /// </para>
        /// </summary>
        public CustomEvents CustomEvents { get; set; }

        /// <summary>
        /// Checks to see if the CustomEvents property is set.
        /// </summary>
        internal bool IsSetCustomEvents() => this.CustomEvents != null;

        /// <summary>
        /// Gets and sets the property DataStorage. 
        /// <para>
        /// A structure that contains information about whether this app monitor stores a copy
        /// of the telemetry data that RUM collects using CloudWatch Logs.
        /// </para>
        /// </summary>
        public DataStorage DataStorage { get; set; }

        /// <summary>
        /// Checks to see if the DataStorage property is set.
        /// </summary>
        internal bool IsSetDataStorage() => this.DataStorage != null;

        /// <summary>
        /// Gets and sets the property DeobfuscationConfiguration. 
        /// <para>
        ///  A structure that contains the configuration for how an app monitor can deobfuscate
        /// stack traces. 
        /// </para>
        /// </summary>
        public DeobfuscationConfiguration DeobfuscationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeobfuscationConfiguration property is set.
        /// </summary>
        internal bool IsSetDeobfuscationConfiguration() => this.DeobfuscationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The top-level internet domain name for which your application has administrative authority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainList. 
        /// <para>
        ///  List the domain names for which your application has administrative authority. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> DomainList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainList property is set.
        /// </summary>
        internal bool IsSetDomainList() => this.DomainList != null && (this.DomainList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time of the most recent changes to this app monitor's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform type for this app monitor. Valid values are <c>Web</c> for web applications
        /// , <c>Android</c> for Android applications, and <c>iOS</c> for IOS applications.
        /// </para>
        /// </summary>
        public AppMonitorPlatform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the app monitor.
        /// </para>
        /// </summary>
        public StateEnum State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tag keys and values associated with this app monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
