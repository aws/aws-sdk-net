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
    /// A RUM app monitor collects telemetry data from your application and sends that data
    /// to RUM. The data includes performance and reliability information such as page load
    /// time, client-side errors, and user behavior.
    /// </summary>
    public partial class AppMonitor
    {
        private AppMonitorConfiguration _appMonitorConfiguration;
        private string _created;
        private CustomEvents _customEvents;
        private DataStorage _dataStorage;
        private string _domain;
        private string _id;
        private string _lastModified;
        private string _name;
        private StateEnum _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AppMonitorConfiguration. 
        /// <para>
        /// A structure that contains much of the configuration data for the app monitor.
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
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time that this app monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created != null;
        }

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
        /// Gets and sets the property DataStorage. 
        /// <para>
        /// A structure that contains information about whether this app monitor stores a copy
        /// of the telemetry data that RUM collects using CloudWatch Logs.
        /// </para>
        /// </summary>
        public DataStorage DataStorage
        {
            get { return this._dataStorage; }
            set { this._dataStorage = value; }
        }

        // Check to see if DataStorage property is set
        internal bool IsSetDataStorage()
        {
            return this._dataStorage != null;
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time of the most recent changes to this app monitor's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the app monitor.
        /// </para>
        /// </summary>
        public StateEnum State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tag keys and values associated with this app monitor.
        /// </para>
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