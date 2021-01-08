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
    /// This is the response object from the GetAutomationExecution operation.
    /// </summary>
    public partial class GetAutomationExecutionResponse : AmazonWebServiceResponse
    {
        private AutomationExecution _automationExecution;

        /// <summary>
        /// Gets and sets the property AutomationExecution. 
        /// <para>
        /// Detailed information about the current state of an automation execution.
        /// </para>
        /// </summary>
        public AutomationExecution AutomationExecution
        {
            get { return this._automationExecution; }
            set { this._automationExecution = value; }
        }

        // Check to see if AutomationExecution property is set
        internal bool IsSetAutomationExecution()
        {
            return this._automationExecution != null;
        }

    }
}