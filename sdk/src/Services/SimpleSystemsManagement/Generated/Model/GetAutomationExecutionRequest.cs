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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetAutomationExecution operation.
    /// Get detailed information about a particular Automation execution.
    /// </summary>
    public partial class GetAutomationExecutionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _automationExecutionId;

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The unique identifier for an existing automation execution to examine. The execution
        /// ID is returned by StartAutomationExecution when the execution of an Automation document
        /// is initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AutomationExecutionId
        {
            get { return this._automationExecutionId; }
            set { this._automationExecutionId = value; }
        }

        // Check to see if AutomationExecutionId property is set
        internal bool IsSetAutomationExecutionId()
        {
            return this._automationExecutionId != null;
        }

    }
}