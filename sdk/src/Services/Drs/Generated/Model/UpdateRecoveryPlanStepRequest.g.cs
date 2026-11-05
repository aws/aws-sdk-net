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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRecoveryPlanStep operation. Updates a Recovery
    /// Plan step's name or configuration. Step type is immutable.
    /// </summary>
    public partial class UpdateRecoveryPlanStepRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        public RecoveryPlanStepConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property RecoveryPlanStepArn. 
        /// <para>
        /// The ARN of the Recovery Plan step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RecoveryPlanStepArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPlanStepArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPlanStepArn() => this.RecoveryPlanStepArn != null;

        /// <summary>
        /// Gets and sets the property StepName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;
    }
}
