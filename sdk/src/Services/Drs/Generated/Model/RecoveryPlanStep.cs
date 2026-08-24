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
    /// A Recovery Plan Step resource.
    /// </summary>
    public partial class RecoveryPlanStep
    {
        private RecoveryPlanStepConfiguration _configuration;
        private string _createdAt;
        private string _recoveryPlanStepArn;
        private string _stepName;
        private int? _stepOrder;
        private string _updatedAt;

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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the step was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPlanStepArn. 
        /// <para>
        /// The ARN of the Recovery Plan step.
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
        [AWSProperty(Required=true, Min=1, Max=20)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the step was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null;
        }

    }
}