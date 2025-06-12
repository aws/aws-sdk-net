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
    /// Container for the parameters to the SetKeepJobFlowAliveWhenNoSteps operation.
    /// You can use the <c>SetKeepJobFlowAliveWhenNoSteps</c> to configure a cluster (job
    /// flow) to terminate after the step execution, i.e., all your steps are executed. If
    /// you want a transient cluster that shuts down after the last of the current executing
    /// steps are completed, you can configure <c>SetKeepJobFlowAliveWhenNoSteps</c> to false.
    /// If you want a long running cluster, configure <c>SetKeepJobFlowAliveWhenNoSteps</c>
    /// to true.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
    /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetKeepJobFlowAliveWhenNoStepsRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _keepJobFlowAliveWhenNoSteps;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// A list of strings that uniquely identify the clusters to protect. This identifier
        /// is returned by <a href="https://docs.aws.amazon.com/emr/latest/APIReference/API_RunJobFlow.html">RunJobFlow</a>
        /// and can also be obtained from <a href="https://docs.aws.amazon.com/emr/latest/APIReference/API_DescribeJobFlows.html">DescribeJobFlows</a>.
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
        /// Gets and sets the property KeepJobFlowAliveWhenNoSteps. 
        /// <para>
        /// A Boolean that indicates whether to terminate the cluster after all steps are executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? KeepJobFlowAliveWhenNoSteps
        {
            get { return this._keepJobFlowAliveWhenNoSteps; }
            set { this._keepJobFlowAliveWhenNoSteps = value; }
        }

        // Check to see if KeepJobFlowAliveWhenNoSteps property is set
        internal bool IsSetKeepJobFlowAliveWhenNoSteps()
        {
            return this._keepJobFlowAliveWhenNoSteps.HasValue; 
        }

    }
}