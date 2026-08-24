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
    /// Container for the parameters to the CreateRecoveryPlanStep operation.
    /// Creates a step in a Recovery Plan. A step is either <c>SERVER</c> type (servers to
    /// recover in parallel) or <c>WAIT</c> type (timed pause between steps).
    /// </summary>
    public partial class CreateRecoveryPlanStepRequest : AmazonDrsRequest
    {
        private string _clientToken;
        private RecoveryPlanStepConfiguration _configuration;
        private string _recoveryPlanArn;
        private string _stepName;
        private int? _stepOrder;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string provided to ensure request idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RecoveryPlanArn. 
        /// <para>
        /// The ARN of the Recovery Plan to add the step to.
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

        /// <summary>
        /// Gets and sets the property StepName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property StepOrder.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? StepOrder
        {
            get { return this._stepOrder; }
            set { this._stepOrder = value; }
        }

        // Check to see if StepOrder property is set
        internal bool IsSetStepOrder()
        {
            return this._stepOrder.HasValue; 
        }

    }
}