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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The configurations that control how Customer Profiles retrieves data from the source,
    /// Amazon AppFlow. Customer Profiles uses this information to create an AppFlow flow
    /// on behalf of customers.
    /// </summary>
    public partial class FlowDefinition
    {
        private string _description;
        private string _flowName;
        private string _kmsArn;
        private SourceFlowConfig _sourceFlowConfig;
        private List<Task> _tasks = AWSConfigs.InitializeCollections ? new List<Task>() : null;
        private TriggerConfig _triggerConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the flow you want to create.
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
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The specified name of the flow. Use underscores (_) or hyphens (-) only. Spaces are
        /// not allowed.
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
        /// Gets and sets the property KmsArn. 
        /// <para>
        /// The Amazon Resource Name of the AWS Key Management Service (KMS) key you provide for
        /// encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string KmsArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KmsArn property is set
        internal bool IsSetKmsArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFlowConfig. 
        /// <para>
        /// The configuration that controls how Customer Profiles retrieves data from the source.
        /// </para>
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
        /// A list of tasks that Customer Profiles performs while transferring the data in the
        /// flow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tasks != null && (this._tasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        /// The trigger settings that determine how and when the flow runs.
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