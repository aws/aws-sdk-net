/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTasks operation.
    /// Returns a list of tasks for a specified cluster. You can filter the results by family
    /// name, by a particular container instance, or by the desired status of the task with
    /// the <code>family</code>, <code>containerInstance</code>, and <code>desiredStatus</code>
    /// parameters.
    /// </summary>
    public partial class ListTasksRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _containerInstance;
        private DesiredStatus _desiredStatus;
        private string _family;
        private int? _maxResults;
        private string _nextToken;
        private string _serviceName;
        private string _startedBy;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the tasks
        /// you want to list. If you do not specify a cluster, the default cluster is assumed..
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
        /// Gets and sets the property ContainerInstance. 
        /// <para>
        /// The container instance UUID or full Amazon Resource Name (ARN) of the container instance
        /// that you want to filter the <code>ListTasks</code> results with. Specifying a <code>containerInstance</code>
        /// will limit the results to tasks that belong to that container instance.
        /// </para>
        /// </summary>
        public string ContainerInstance
        {
            get { return this._containerInstance; }
            set { this._containerInstance = value; }
        }

        // Check to see if ContainerInstance property is set
        internal bool IsSetContainerInstance()
        {
            return this._containerInstance != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredStatus. 
        /// <para>
        /// The task status that you want to filter the <code>ListTasks</code> results with. Specifying
        /// a <code>desiredStatus</code> of <code>STOPPED</code> will limit the results to tasks
        /// that are in the <code>STOPPED</code> status, which can be useful for debugging tasks
        /// that are not starting properly or have died or finished. The default status filter
        /// is <code>RUNNING</code>.
        /// </para>
        /// </summary>
        public DesiredStatus DesiredStatus
        {
            get { return this._desiredStatus; }
            set { this._desiredStatus = value; }
        }

        // Check to see if DesiredStatus property is set
        internal bool IsSetDesiredStatus()
        {
            return this._desiredStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The name of the family that you want to filter the <code>ListTasks</code> results
        /// with. Specifying a <code>family</code> will limit the results to tasks that belong
        /// to that family.
        /// </para>
        /// </summary>
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }

        // Check to see if Family property is set
        internal bool IsSetFamily()
        {
            return this._family != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of task results returned by <code>ListTasks</code> in paginated
        /// output. When this parameter is used, <code>ListTasks</code> only returns <code>maxResults</code>
        /// results in a single page along with a <code>nextToken</code> response element. The
        /// remaining results of the initial request can be seen by sending another <code>ListTasks</code>
        /// request with the returned <code>nextToken</code> value. This value can be between
        /// 1 and 100. If this parameter is not used, then <code>ListTasks</code> returns up to
        /// 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListTasks</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that you want to filter the <code>ListTasks</code> results
        /// with. Specifying a <code>serviceName</code> will limit the results to tasks that belong
        /// to that service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The <code>startedBy</code> value that you want to filter the task results with. Specifying
        /// a <code>startedBy</code> value will limit the results to tasks that were started with
        /// that value.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

    }
}