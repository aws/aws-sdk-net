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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the SetUnhealthyNodeReplacement operation.
    /// Specify whether to enable unhealthy node replacement, which lets Amazon EMR gracefully
    /// replace core nodes on a cluster if any nodes become unhealthy. For example, a node
    /// becomes unhealthy if disk usage is above 90%. If unhealthy node replacement is on
    /// and <c>TerminationProtected</c> are off, Amazon EMR immediately terminates the unhealthy
    /// core nodes. To use unhealthy node replacement and retain unhealthy core nodes, use
    /// to turn on termination protection. In such cases, Amazon EMR adds the unhealthy nodes
    /// to a denylist, reducing job interruptions and failures.
    /// 
    ///  
    /// <para>
    /// If unhealthy node replacement is on, Amazon EMR notifies YARN and other applications
    /// on the cluster to stop scheduling tasks with these nodes, moves the data, and then
    /// terminates the nodes.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-node-replacement.html">graceful
    /// node replacement</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetUnhealthyNodeReplacementRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _unhealthyNodeReplacement;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// The list of strings that uniquely identify the clusters for which to turn on unhealthy
        /// node replacement. You can get these identifiers by running the <a>RunJobFlow</a> or
        /// the <a>DescribeJobFlows</a> operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._jobFlowIds != null && (this._jobFlowIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyNodeReplacement. 
        /// <para>
        /// Indicates whether to turn on or turn off graceful unhealthy node replacement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? UnhealthyNodeReplacement
        {
            get { return this._unhealthyNodeReplacement; }
            set { this._unhealthyNodeReplacement = value; }
        }

        // Check to see if UnhealthyNodeReplacement property is set
        internal bool IsSetUnhealthyNodeReplacement()
        {
            return this._unhealthyNodeReplacement.HasValue; 
        }

    }
}