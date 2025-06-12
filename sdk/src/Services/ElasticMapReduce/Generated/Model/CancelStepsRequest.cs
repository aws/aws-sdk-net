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
    /// Container for the parameters to the CancelSteps operation.
    /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
    /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
    /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
    /// guarantee that a step will be canceled, even if the request is successfully submitted.
    /// When you use Amazon EMR releases 5.28.0 and later, you can cancel steps that are in
    /// a <c>PENDING</c> or <c>RUNNING</c> state. In earlier versions of Amazon EMR, you can
    /// only cancel steps that are in a <c>PENDING</c> state.
    /// </summary>
    public partial class CancelStepsRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private StepCancellationOption _stepCancellationOption;
        private List<string> _stepIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The <c>ClusterID</c> for the specified steps that will be canceled. Use <a>RunJobFlow</a>
        /// and <a>ListClusters</a> to get ClusterIDs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property StepCancellationOption. 
        /// <para>
        /// The option to choose to cancel <c>RUNNING</c> steps. By default, the value is <c>SEND_INTERRUPT</c>.
        /// </para>
        /// </summary>
        public StepCancellationOption StepCancellationOption
        {
            get { return this._stepCancellationOption; }
            set { this._stepCancellationOption = value; }
        }

        // Check to see if StepCancellationOption property is set
        internal bool IsSetStepCancellationOption()
        {
            return this._stepCancellationOption != null;
        }

        /// <summary>
        /// Gets and sets the property StepIds. 
        /// <para>
        /// The list of <c>StepIDs</c> to cancel. Use <a>ListSteps</a> to get steps and their
        /// states for the specified cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StepIds
        {
            get { return this._stepIds; }
            set { this._stepIds = value; }
        }

        // Check to see if StepIds property is set
        internal bool IsSetStepIds()
        {
            return this._stepIds != null && (this._stepIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}