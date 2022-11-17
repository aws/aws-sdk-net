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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlow operation.
    /// Updates an existing flow.
    /// </summary>
    public partial class UpdateFlowRequest : AmazonAppflowRequest
    {
        private string _description;
        private List<DestinationFlowConfig> _destinationFlowConfigList = new List<DestinationFlowConfig>();
        private string _flowName;
        private MetadataCatalogConfig _metadataCatalogConfig;
        private SourceFlowConfig _sourceFlowConfig;
        private List<Task> _tasks = new List<Task>();
        private TriggerConfig _triggerConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property DestinationFlowConfigList. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow transfers data to the destination
        /// connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DestinationFlowConfig> DestinationFlowConfigList
        {
            get { return this._destinationFlowConfigList; }
            set { this._destinationFlowConfigList = value; }
        }

        // Check to see if DestinationFlowConfigList property is set
        internal bool IsSetDestinationFlowConfigList()
        {
            return this._destinationFlowConfigList != null && this._destinationFlowConfigList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataCatalogConfig. 
        /// <para>
        /// Specifies the configuration that Amazon AppFlow uses when it catalogs the data that's
        /// transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow,
        /// it stores metadata in a data catalog.
        /// </para>
        /// </summary>
        public MetadataCatalogConfig MetadataCatalogConfig
        {
            get { return this._metadataCatalogConfig; }
            set { this._metadataCatalogConfig = value; }
        }

        // Check to see if MetadataCatalogConfig property is set
        internal bool IsSetMetadataCatalogConfig()
        {
            return this._metadataCatalogConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFlowConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceFlowConfig SourceFlowConfig
        {
            get { return this._sourceFlowConfig; }
            set { this._sourceFlowConfig = value; }
        }

        // Check to see if SourceFlowConfig property is set
        internal bool IsSetSourceFlowConfig()
        {
            return this._sourceFlowConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        ///  A list of tasks that Amazon AppFlow performs while transferring the data in the flow
        /// run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Task> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && this._tasks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        ///  The trigger settings that determine how and when the flow runs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TriggerConfig TriggerConfig
        {
            get { return this._triggerConfig; }
            set { this._triggerConfig = value; }
        }

        // Check to see if TriggerConfig property is set
        internal bool IsSetTriggerConfig()
        {
            return this._triggerConfig != null;
        }

    }
}