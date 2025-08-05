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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a logical scenario where claims can be evaluated as true or false, containing
    /// specific logical assignments.
    /// </summary>
    public partial class AutomatedReasoningCheckScenario
    {
        private List<AutomatedReasoningLogicStatement> _statements = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningLogicStatement>() : null;

        /// <summary>
        /// Gets and sets the property Statements. 
        /// <para>
        /// List of logical assignments and statements that define this scenario.
        /// </para>
        /// </summary>
        public List<AutomatedReasoningLogicStatement> Statements
        {
            get { return this._statements; }
            set { this._statements = value; }
        }

        // Check to see if Statements property is set
        internal bool IsSetStatements()
        {
            return this._statements != null && (this._statements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}