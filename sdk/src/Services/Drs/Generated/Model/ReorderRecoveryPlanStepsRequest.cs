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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
    /// Container for the parameters to the ReorderRecoveryPlanSteps operation.
    /// Reorders steps in a Recovery Plan. Accepts a complete ordered list of step ARNs.
    /// </summary>
    public partial class ReorderRecoveryPlanStepsRequest : AmazonDrsRequest
    {
        private List<string> _orderedStepArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recoveryPlanArn;

        /// <summary>
        /// Gets and sets the property OrderedStepArns. 
        /// <para>
        /// Ordered list of all step ARNs representing the desired sequence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> OrderedStepArns
        {
            get { return this._orderedStepArns; }
            set { this._orderedStepArns = value; }
        }

        // Check to see if OrderedStepArns property is set
        internal bool IsSetOrderedStepArns()
        {
            return this._orderedStepArns != null && (this._orderedStepArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPlanArn. 
        /// <para>
        /// The ARN of the Recovery Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanArn
        {
            get { return this._recoveryPlanArn; }
            set { this._recoveryPlanArn = value; }
        }

        // Check to see if RecoveryPlanArn property is set
        internal bool IsSetRecoveryPlanArn()
        {
            return this._recoveryPlanArn != null;
        }

    }
}