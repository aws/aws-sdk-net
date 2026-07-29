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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTask operation.
    /// Creates a new task in the specified workspace. A task defines a reusable containerized
    /// compute workload that can be referenced by one or more pipeline compute nodes.
    /// 
    ///  
    /// <para>
    /// Specify a <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ContainerTaskConfiguration.html"><c>containerTaskConfiguration</c></a>
    /// for custom container workloads with configurable ECR image, processing type, processing
    /// unit, and environment variables.
    /// </para>
    /// </summary>
    public partial class CreateTaskRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private string _description;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TaskConfiguration _taskConfiguration;
        private string _taskName;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token, the server returns the cached result from the original successful request without
        /// performing the operation again.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the task. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your AWS IoT SiteWise resources</a> in the AWS IoT SiteWise User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property TaskConfiguration. 
        /// <para>
        /// The task execution configuration. Specify a <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ContainerTaskConfiguration.html">containerTaskConfiguration</a>
        /// for custom container workloads.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskConfiguration TaskConfiguration
        {
            get { return this._taskConfiguration; }
            set { this._taskConfiguration = value; }
        }

        // Check to see if TaskConfiguration property is set
        internal bool IsSetTaskConfiguration()
        {
            return this._taskConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the task to create. Must be unique within the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}