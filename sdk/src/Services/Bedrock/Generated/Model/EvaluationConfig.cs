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
    /// The configuration details of either an automated or human-based evaluation job.
    /// </summary>
    public partial class EvaluationConfig
    {
        private AutomatedEvaluationConfig _automated;
        private HumanEvaluationConfig _human;

        /// <summary>
        /// Gets and sets the property Automated. 
        /// <para>
        /// Contains the configuration details of an automated evaluation job that computes metrics.
        /// </para>
        /// </summary>
        public AutomatedEvaluationConfig Automated
        {
            get { return this._automated; }
            set { this._automated = value; }
        }

        // Check to see if Automated property is set
        internal bool IsSetAutomated()
        {
            return this._automated != null;
        }

        /// <summary>
        /// Gets and sets the property Human. 
        /// <para>
        /// Contains the configuration details of an evaluation job that uses human workers.
        /// </para>
        /// </summary>
        public HumanEvaluationConfig Human
        {
            get { return this._human; }
            set { this._human = value; }
        }

        // Check to see if Human property is set
        internal bool IsSetHuman()
        {
            return this._human != null;
        }

    }
}