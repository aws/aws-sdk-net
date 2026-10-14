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
    /// Summary information about an AI workload configuration.
    /// </summary>
    public partial class AIWorkloadConfigSummary
    {
        /// <summary>
        /// Gets and sets the property AIWorkloadConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI workload configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AIWorkloadConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigArn property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigArn() => this.AIWorkloadConfigArn != null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigName. 
        /// <para>
        /// The name of the AI workload configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AIWorkloadConfigName { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigName property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigName() => this.AIWorkloadConfigName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the configuration was created.
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
