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
    /// <important> 
    /// <para>
    /// The SetVisibleToAllUsers parameter is no longer supported. Your cluster may be visible
    /// to all users in your account. To restrict cluster access using an IAM policy, see
    /// <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-access-iam.html">Identity
    /// and Access Management for EMR</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// Sets the <a>Cluster$VisibleToAllUsers</a> value for an EMR cluster. When <code>true</code>,
    /// IAM principals in the Amazon Web Services account can perform EMR cluster actions
    /// that their IAM policies allow. When <code>false</code>, only the IAM principal that
    /// created the cluster and the Amazon Web Services account root user can perform EMR
    /// actions on the cluster, regardless of IAM permissions policies attached to other IAM
    /// principals.
    /// </para>
    ///  
    /// <para>
    /// This action works on running clusters. When you create a cluster, use the <a>RunJobFlowInput$VisibleToAllUsers</a>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_iam_emr-with-iam.html#security_set_visible_to_all_users">Understanding
    /// the EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMRManagement Guide</i>.
    /// </para>
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
        /// A value of <code>true</code> indicates that an IAM principal in the Amazon Web Services
        /// account can perform EMR actions on the cluster that the IAM policies attached to the
        /// principal allow. A value of <code>false</code> indicates that only the IAM principal
        /// that created the cluster and the Amazon Web Services root user can perform EMR actions
        /// on the cluster.
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