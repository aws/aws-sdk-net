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
    /// Provides summary information about an algorithm.
    /// </summary>
    public partial class AlgorithmSummary
    {
        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AlgorithmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmArn property is set.
        /// </summary>
        internal bool IsSetAlgorithmArn() => this.AlgorithmArn != null;

        /// <summary>
        /// Gets and sets the property AlgorithmDescription. 
        /// <para>
        /// A brief description of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AlgorithmDescription { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmDescription property is set.
        /// </summary>
        internal bool IsSetAlgorithmDescription() => this.AlgorithmDescription != null;

        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm that is described by the summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmName property is set.
        /// </summary>
        internal bool IsSetAlgorithmName() => this.AlgorithmName != null;

        /// <summary>
        /// Gets and sets the property AlgorithmStatus. 
        /// <para>
        /// The overall status of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AlgorithmStatus AlgorithmStatus { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmStatus property is set.
        /// </summary>
        internal bool IsSetAlgorithmStatus() => this.AlgorithmStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the algorithm was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;
    }
}
