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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTaskSets operation.
    /// Describes the task sets in the specified cluster and service. This is used when a
    /// service uses the <code>EXTERNAL</code> deployment controller type. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
    /// ECS Deployment Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class DescribeTaskSetsRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _include = new List<string>();
        private string _service;
        private List<string> _taskSets = new List<string>();

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// that the task sets exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies whether to see the resource tags for the task set. If <code>TAGS</code>
        /// is specified, the tags are included in the response. If this field is omitted, tags
        /// aren't included in the response.
        /// </para>
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && this._include.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the service that the task sets
        /// exist in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property TaskSets. 
        /// <para>
        /// The ID or full Amazon Resource Name (ARN) of task sets to describe.
        /// </para>
        /// </summary>
        public List<string> TaskSets
        {
            get { return this._taskSets; }
            set { this._taskSets = value; }
        }

        // Check to see if TaskSets property is set
        internal bool IsSetTaskSets()
        {
            return this._taskSets != null && this._taskSets.Count > 0; 
        }

    }
}