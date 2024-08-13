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
    /// Container for the parameters to the ListTasks operation.
    /// Returns a list of tasks. You can filter the results by cluster, task definition family,
    /// container instance, launch type, what IAM principal started the task, or by the desired
    /// status of the task.
    /// 
    ///  
    /// <para>
    /// Recently stopped tasks might appear in the returned results. 
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
        /// the <c>ListTasks</c> results. If you do not specify a cluster, the default cluster
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
        /// the <c>ListTasks</c> results. Specifying a <c>containerInstance</c> limits the results
        /// to tasks that belong to that container instance.
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
        /// The task desired status to use when filtering the <c>ListTasks</c> results. Specifying
        /// a <c>desiredStatus</c> of <c>STOPPED</c> limits the results to tasks that Amazon ECS
        /// has set the desired status to <c>STOPPED</c>. This can be useful for debugging tasks
        /// that aren't starting properly or have died or finished. The default status filter
        /// is <c>RUNNING</c>, which shows tasks that Amazon ECS has set the desired status to
        /// <c>RUNNING</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although you can filter results based on a desired status of <c>PENDING</c>, this
        /// doesn't return any results. Amazon ECS never sets the desired status of a task to
        /// that value (only a task's <c>lastStatus</c> may have a value of <c>PENDING</c>).
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
        /// The name of the task definition family to use when filtering the <c>ListTasks</c>
        /// results. Specifying a <c>family</c> limits the results to tasks that belong to that
        /// family.
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
        /// The launch type to use when filtering the <c>ListTasks</c> results.
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
        /// The maximum number of task results that <c>ListTasks</c> returned in paginated output.
        /// When this parameter is used, <c>ListTasks</c> only returns <c>maxResults</c> results
        /// in a single page along with a <c>nextToken</c> response element. The remaining results
        /// of the initial request can be seen by sending another <c>ListTasks</c> request with
        /// the returned <c>nextToken</c> value. This value can be between 1 and 100. If this
        /// parameter isn't used, then <c>ListTasks</c> returns up to 100 results and a <c>nextToken</c>
        /// value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The <c>nextToken</c> value returned from a <c>ListTasks</c> request indicating that
        /// more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it's possible the number of results to be fewer
        /// than <c>maxResults</c>.
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
        /// The name of the service to use when filtering the <c>ListTasks</c> results. Specifying
        /// a <c>serviceName</c> limits the results to tasks that belong to that service.
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
        /// The <c>startedBy</c> value to filter the task results with. Specifying a <c>startedBy</c>
        /// value limits the results to tasks that were started with that value.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>startedBy</c> as the filter, it must be the only filter that you
        /// use.
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