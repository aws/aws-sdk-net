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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Defines an instance group for heterogeneous cluster training. When requesting a training
    /// job using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
    /// API, you can configure multiple instance groups .
    /// </summary>
    public partial class InstanceGroup
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Specifies the number of instances of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// Specifies the name of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;
    }
}
