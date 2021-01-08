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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the SetVisibleToAllUsers operation.
    /// Sets the <a>Cluster$VisibleToAllUsers</a> value, which determines whether the cluster
    /// is visible to all IAM users of the AWS account associated with the cluster. Only the
    /// IAM user who created the cluster or the AWS account root user can call this action.
    /// The default value, <code>true</code>, indicates that all IAM users in the AWS account
    /// can perform cluster actions if they have the proper IAM policy permissions. If set
    /// to <code>false</code>, only the IAM user that created the cluster can perform actions.
    /// This action works on running clusters. You can override the default <code>true</code>
    /// setting when you create a cluster by using the <code>VisibleToAllUsers</code> parameter
    /// with <code>RunJobFlow</code>.
    /// </summary>
    public partial class SetVisibleToAllUsersRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = new List<string>();
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// The unique identifier of the job flow (cluster).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> JobFlowIds
        {
            get { return this._jobFlowIds; }
            set { this._jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this._jobFlowIds != null && this._jobFlowIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// A value of <code>true</code> indicates that all IAM users in the AWS account can perform
        /// cluster actions if they have the proper IAM policy permissions. This is the default.
        /// A value of <code>false</code> indicates that only the IAM user who created the cluster
        /// can perform actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}