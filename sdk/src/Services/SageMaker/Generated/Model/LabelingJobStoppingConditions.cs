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
    /// A set of conditions for stopping a labeling job. If any of the conditions are met,
    /// the job is automatically stopped. You can use these conditions to control the cost
    /// of data labeling.
    /// 
    ///  <note> 
    /// <para>
    /// Labeling jobs fail after 30 days with an appropriate client error message.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LabelingJobStoppingConditions
    {
        private int? _maxHumanLabeledObjectCount;
        private int? _maxPercentageOfInputDatasetLabeled;

        /// <summary>
        /// Gets and sets the property MaxHumanLabeledObjectCount. 
        /// <para>
        /// The maximum number of objects that can be labeled by human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxHumanLabeledObjectCount
        {
            get { return this._maxHumanLabeledObjectCount; }
            set { this._maxHumanLabeledObjectCount = value; }
        }

        // Check to see if MaxHumanLabeledObjectCount property is set
        internal bool IsSetMaxHumanLabeledObjectCount()
        {
            return this._maxHumanLabeledObjectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPercentageOfInputDatasetLabeled. 
        /// <para>
        /// The maximum number of input data objects that should be labeled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxPercentageOfInputDatasetLabeled
        {
            get { return this._maxPercentageOfInputDatasetLabeled; }
            set { this._maxPercentageOfInputDatasetLabeled = value; }
        }

        // Check to see if MaxPercentageOfInputDatasetLabeled property is set
        internal bool IsSetMaxPercentageOfInputDatasetLabeled()
        {
            return this._maxPercentageOfInputDatasetLabeled.HasValue; 
        }

    }
}