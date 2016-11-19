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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the CancelSteps operation.
    /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
    /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
    /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
    /// guarantee a step will be canceled, even if the request is successfully submitted.
    /// You can only cancel steps that are in a <code>PENDING</code> state.
    /// </summary>
    public partial class CancelStepsRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private List<string> _stepIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The <code>ClusterID</code> for which specified steps will be canceled. Use <a>RunJobFlow</a>
        /// and <a>ListClusters</a> to get ClusterIDs. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StepIds. 
        /// <para>
        /// The list of <code>StepIDs</code> to cancel. Use <a>ListSteps</a> to get steps and
        /// their states for the specified cluster.
        /// </para>
        /// </summary>
        public List<string> StepIds
        {
            get { return this._stepIds; }
            set { this._stepIds = value; }
        }

        // Check to see if StepIds property is set
        internal bool IsSetStepIds()
        {
            return this._stepIds != null && this._stepIds.Count > 0; 
        }

    }
}