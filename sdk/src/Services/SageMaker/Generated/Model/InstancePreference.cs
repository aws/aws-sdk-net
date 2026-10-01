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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A candidate instance type preference in an <c>InstancePreferences</c> list.
    /// </summary>
    public partial class InstancePreference
    {
        private int? _instanceCount;
        private TrainingInstanceType _instanceType;
        private List<string> _trainingPlanArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances to launch if this instance type is selected. Specify the instance
        /// count for the training job in one of the following two ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <b>Per preference</b> – Set <c>InstanceCount</c> on every preference in the <c>InstancePreferences</c>
        /// list and don't set <c>ResourceConfig$InstanceCount</c>. Use this when each instance
        /// type needs a different number of instances to deliver equivalent compute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>One count for the job</b> – Set <c>ResourceConfig$InstanceCount</c> and omit it
        /// from every preference. SageMaker applies this to all instance types in the list.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For example, in a list of five preferences, either all five specify <c>InstanceCount</c>
        /// or none of them do. SageMaker rejects requests that set <c>InstanceCount</c> on only
        /// some preferences, that set it both per preference and in <c>ResourceConfig</c>, or
        /// that omit it in both places.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type. An instance type can appear only once in an <c>InstancePreferences</c>
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a training plan to use if this instance type is
        /// selected. The plan's instance type must match <c>InstanceType</c>. A preference with
        /// a training plan uses that plan's reserved capacity; a preference without one uses
        /// on-demand capacity. Per-preference <c>TrainingPlanArns</c> is mutually exclusive with
        /// the job-level <c>TrainingPlanArn</c> in <c>ResourceConfig</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> TrainingPlanArns
        {
            get { return this._trainingPlanArns; }
            set { this._trainingPlanArns = value; }
        }

        // Check to see if TrainingPlanArns property is set
        internal bool IsSetTrainingPlanArns()
        {
            return this._trainingPlanArns != null && (this._trainingPlanArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}