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
    /// Container for the parameters to the ListTasks operation.
    /// Returns a list of tasks. You can filter the results by cluster, task definition family,
    /// container instance, launch type, what IAM principal started the task, or by the desired
    /// status of the task.
    /// 
    ///  
    /// <para>
    /// Recently stopped tasks might appear in the returned results. Currently, stopped tasks
    /// appear in the returned results for at least one hour.
    /// </para>
    /// </summary>
    public partial class ListTasksRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _containerInstance;
        private DesiredStatus _desiredStatus;
        private string _family;
        private LaunchType _launchType;
        private int? _maxResults;
        private string _nextToken;
        private string _serviceName;
        private string _startedBy;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to use when filtering
        /// the <code>ListTasks</code> results. If you do not specify a cluster, the default cluster
        /// is assumed.
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
        /// The container instance ID or full ARN of the container instance to use when filtering
        /// the <code>ListTasks</code> results. Specifying a <code>containerInstance</code> limits
        /// the results to tasks that belong to that container instance.
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
        /// The task desired status to use when filtering the <code>ListTasks</code> results.
        /// Specifying a <code>desiredStatus</code> of <code>STOPPED</code> limits the results
        /// to tasks that Amazon ECS has set the desired status to <code>STOPPED</code>. This
        /// can be useful for debugging tasks that aren't starting properly or have died or finished.
        /// The default status filter is <code>RUNNING</code>, which shows tasks that Amazon ECS
        /// has set the desired status to <code>RUNNING</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although you can filter results based on a desired status of <code>PENDING</code>,
        /// this doesn't return any results. Amazon ECS never sets the desired status of a task
        /// to that value (only a task's <code>lastStatus</code> may have a value of <code>PENDING</code>).
        /// </para>
        ///  </note>
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
        /// The name of the task definition family to use when filtering the <code>ListTasks</code>
        /// results. Specifying a <code>family</code> limits the results to tasks that belong
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type to use when filtering the <code>ListTasks</code> results.
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of task results that <code>ListTasks</code> returned in paginated
        /// output. When this parameter is used, <code>ListTasks</code> only returns <code>maxResults</code>
        /// results in a single page along with a <code>nextToken</code> response element. The
        /// remaining results of the initial request can be seen by sending another <code>ListTasks</code>
        /// request with the returned <code>nextToken</code> value. This value can be between
        /// 1 and 100. If this parameter isn't used, then <code>ListTasks</code> returns up to
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
        /// The <code>nextToken</code> value returned from a <code>ListTasks</code> request indicating
        /// that more results are available to fulfill the request and further calls will be needed.
        /// If <code>maxResults</code> was provided, it's possible the number of results to be
        /// fewer than <code>maxResults</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// The name of the service to use when filtering the <code>ListTasks</code> results.
        /// Specifying a <code>serviceName</code> limits the results to tasks that belong to that
        /// service.
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
        /// The <code>startedBy</code> value to filter the task results with. Specifying a <code>startedBy</code>
        /// value limits the results to tasks that were started with that value.
        /// </para>
        ///  
        /// <para>
        /// When you specify <code>startedBy</code> as the filter, it must be the only filter
        /// that you use.
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