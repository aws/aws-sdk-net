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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTasks operation.
    /// Describes a specified task or tasks.
    /// 
    ///  
    /// <para>
    /// Currently, stopped tasks appear in the returned results for at least one hour.
    /// </para>
    ///  
    /// <para>
    /// If you have tasks with tags, and then delete the cluster, the tagged tasks are returned
    /// in the response. If you create a new cluster with the same name as the deleted cluster,
    /// the tagged tasks are not included in the response.
    /// </para>
    /// </summary>
    public partial class DescribeTasksRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tasks = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the task
        /// or tasks to describe. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
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
        /// Specifies whether you want to see the resource tags for the task. If <c>TAGS</c> is
        /// specified, the tags are included in the response. If this field is omitted, tags aren't
        /// included in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// A list of up to 100 task IDs or full ARN entries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && (this._tasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}