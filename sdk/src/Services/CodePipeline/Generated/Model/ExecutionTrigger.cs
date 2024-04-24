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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The interaction or event that started a pipeline execution.
    /// </summary>
    public partial class ExecutionTrigger
    {
        private string _triggerDetail;
        private TriggerType _triggerType;

        /// <summary>
        /// Gets and sets the property TriggerDetail. 
        /// <para>
        /// Detail related to the event that started a pipeline execution, such as the webhook
        /// ARN of the webhook that triggered the pipeline execution or the user ARN for a user-initiated
        /// <c>start-pipeline-execution</c> CLI command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TriggerDetail
        {
            get { return this._triggerDetail; }
            set { this._triggerDetail = value; }
        }

        // Check to see if TriggerDetail property is set
        internal bool IsSetTriggerDetail()
        {
            return this._triggerDetail != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        /// The type of change-detection method, command, or user interaction that started a pipeline
        /// execution.
        /// </para>
        /// </summary>
        public TriggerType TriggerType
        {
            get { return this._triggerType; }
            set { this._triggerType = value; }
        }

        // Check to see if TriggerType property is set
        internal bool IsSetTriggerType()
        {
            return this._triggerType != null;
        }

    }
}