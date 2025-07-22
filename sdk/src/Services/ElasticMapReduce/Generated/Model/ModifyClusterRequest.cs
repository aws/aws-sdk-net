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
    /// Container for the parameters to the ModifyCluster operation.
    /// Modifies the number of steps that can be executed concurrently for the cluster specified
    /// using ClusterID.
    /// </summary>
    public partial class ModifyClusterRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private bool? _extendedSupport;
        private int? _stepConcurrencyLevel;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedSupport. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public bool? ExtendedSupport
        {
            get { return this._extendedSupport; }
            set { this._extendedSupport = value; }
        }

        // Check to see if ExtendedSupport property is set
        internal bool IsSetExtendedSupport()
        {
            return this._extendedSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepConcurrencyLevel. 
        /// <para>
        /// The number of steps that can be executed concurrently. You can specify a minimum of
        /// 1 step and a maximum of 256 steps. We recommend that you do not change this parameter
        /// while steps are running or the <c>ActionOnFailure</c> setting may not behave as expected.
        /// For more information see <a>Step$ActionOnFailure</a>.
        /// </para>
        /// </summary>
        public int? StepConcurrencyLevel
        {
            get { return this._stepConcurrencyLevel; }
            set { this._stepConcurrencyLevel = value; }
        }

        // Check to see if StepConcurrencyLevel property is set
        internal bool IsSetStepConcurrencyLevel()
        {
            return this._stepConcurrencyLevel.HasValue; 
        }

    }
}