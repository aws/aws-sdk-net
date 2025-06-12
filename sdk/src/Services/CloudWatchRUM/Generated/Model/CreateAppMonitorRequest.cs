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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the CreateAppMonitor operation.
    /// Creates a Amazon CloudWatch RUM app monitor, which collects telemetry data from your
    /// application and sends that data to RUM. The data includes performance and reliability
    /// information such as page load time, client-side errors, and user behavior.
    /// 
    ///  
    /// <para>
    /// You use this operation only to create a new app monitor. To update an existing app
    /// monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_UpdateAppMonitor.html">UpdateAppMonitor</a>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// After you create an app monitor, sign in to the CloudWatch RUM console to get the
    /// JavaScript code snippet to add to your web application. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
    /// do I find a code snippet that I've already generated?</a> 
    /// </para>
    /// </summary>
    public partial class CreateAppMonitorRequest : AmazonCloudWatchRUMRequest
    {
        private AppMonitorConfiguration _appMonitorConfiguration;
        private CustomEvents _customEvents;
        private bool? _cwLogEnabled;
        private DeobfuscationConfiguration _deobfuscationConfiguration;
        private string _domain;
        private List<string> _domainList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AppMonitorConfiguration. 
        /// <para>
        /// A structure that contains much of the configuration data for the app monitor. If you
        /// are using Amazon Cognito for authorization, you must include this structure in your
        /// request, and it must include the ID of the Amazon Cognito identity pool to use for
        /// authorization. If you don't include <c>AppMonitorConfiguration</c>, you must set up
        /// your own authorization method. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-get-started-authorization.html">Authorize
        /// your application to send data to Amazon Web Services</a>.
        /// </para>
        ///  
        /// <para>
        /// If you omit this argument, the sample rate used for RUM is set to 10% of the user
        /// sessions.
        /// </para>
        /// </summary>
        public AppMonitorConfiguration AppMonitorConfiguration
        {
            get { return this._appMonitorConfiguration; }
            set { this._appMonitorConfiguration = value; }
        }

        // Check to see if AppMonitorConfiguration property is set
        internal bool IsSetAppMonitorConfiguration()
        {
            return this._appMonitorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomEvents. 
        /// <para>
        /// Specifies whether this app monitor allows the web client to define and send custom
        /// events. If you omit this parameter, custom events are <c>DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about custom events, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-custom-events.html">Send
        /// custom events</a>.
        /// </para>
        /// </summary>
        public CustomEvents CustomEvents
        {
            get { return this._customEvents; }
            set { this._customEvents = value; }
        }

        // Check to see if CustomEvents property is set
        internal bool IsSetCustomEvents()
        {
            return this._customEvents != null;
        }

        /// <summary>
        /// Gets and sets the property CwLogEnabled. 
        /// <para>
        /// Data collected by RUM is kept by RUM for 30 days and then deleted. This parameter
        /// specifies whether RUM sends a copy of this telemetry data to Amazon CloudWatch Logs
        /// in your account. This enables you to keep the telemetry data for more than 30 days,
        /// but it does incur Amazon CloudWatch Logs charges.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? CwLogEnabled
        {
            get { return this._cwLogEnabled; }
            set { this._cwLogEnabled = value; }
        }

        // Check to see if CwLogEnabled property is set
        internal bool IsSetCwLogEnabled()
        {
            return this._cwLogEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeobfuscationConfiguration. 
        /// <para>
        ///  A structure that contains the configuration for how an app monitor can deobfuscate
        /// stack traces. 
        /// </para>
        /// </summary>
        public DeobfuscationConfiguration DeobfuscationConfiguration
        {
            get { return this._deobfuscationConfiguration; }
            set { this._deobfuscationConfiguration = value; }
        }

        // Check to see if DeobfuscationConfiguration property is set
        internal bool IsSetDeobfuscationConfiguration()
        {
            return this._deobfuscationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The top-level internet domain name for which your application has administrative authority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainList. 
        /// <para>
        ///  List the domain names for which your application has administrative authority. The
        /// <c>CreateAppMonitor</c> requires either the domain or the domain list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> DomainList
        {
            get { return this._domainList; }
            set { this._domainList = value; }
        }

        // Check to see if DomainList property is set
        internal bool IsSetDomainList()
        {
            return this._domainList != null && (this._domainList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the app monitor.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with an app monitor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}