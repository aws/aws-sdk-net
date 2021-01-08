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
    /// Container for the parameters to the SetTerminationProtection operation.
    /// SetTerminationProtection locks a cluster (job flow) so the EC2 instances in the cluster
    /// cannot be terminated by user intervention, an API call, or in the event of a job-flow
    /// error. The cluster still terminates upon successful completion of the job flow. Calling
    /// <code>SetTerminationProtection</code> on a cluster is similar to calling the Amazon
    /// EC2 <code>DisableAPITermination</code> API on all EC2 instances in a cluster.
    /// 
    ///  
    /// <para>
    ///  <code>SetTerminationProtection</code> is used to prevent accidental termination of
    /// a cluster and to ensure that in the event of an error, the instances persist so that
    /// you can recover any data stored in their ephemeral instance storage.
    /// </para>
    ///  
    /// <para>
    ///  To terminate a cluster that has been locked by setting <code>SetTerminationProtection</code>
    /// to <code>true</code>, you must first unlock the job flow by a subsequent call to <code>SetTerminationProtection</code>
    /// in which you set the value to <code>false</code>. 
    /// </para>
    ///  
    /// <para>
    ///  For more information, see<a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
    /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
    /// </para>
    /// </summary>
    public partial class SetTerminationProtectionRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = new List<string>();
        private bool? _terminationProtected;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        ///  A list of strings that uniquely identify the clusters to protect. This identifier
        /// is returned by <a>RunJobFlow</a> and can also be obtained from <a>DescribeJobFlows</a>
        /// . 
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
        /// Gets and sets the property TerminationProtected. 
        /// <para>
        /// A Boolean that indicates whether to protect the cluster and prevent the Amazon EC2
        /// instances in the cluster from shutting down due to API calls, user intervention, or
        /// job-flow error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool TerminationProtected
        {
            get { return this._terminationProtected.GetValueOrDefault(); }
            set { this._terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this._terminationProtected.HasValue; 
        }

    }
}