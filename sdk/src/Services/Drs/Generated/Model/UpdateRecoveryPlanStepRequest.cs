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
    /// Container for the parameters to the UpdateRecoveryPlanStep operation.
    /// Updates a Recovery Plan step's name or configuration. Step type is immutable.
    /// </summary>
    public partial class UpdateRecoveryPlanStepRequest : AmazonDrsRequest
    {
        private RecoveryPlanStepConfiguration _configuration;
        private string _recoveryPlanStepArn;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        public RecoveryPlanStepConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPlanStepArn. 
        /// <para>
        /// The ARN of the Recovery Plan step to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanStepArn
        {
            get { return this._recoveryPlanStepArn; }
            set { this._recoveryPlanStepArn = value; }
        }

        // Check to see if RecoveryPlanStepArn property is set
        internal bool IsSetRecoveryPlanStepArn()
        {
            return this._recoveryPlanStepArn != null;
        }

        /// <summary>
        /// Gets and sets the property StepName.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}