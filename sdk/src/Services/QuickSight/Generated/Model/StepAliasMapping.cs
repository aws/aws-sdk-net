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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A mapping between a step identifier and its alias in a flow.
    /// </summary>
    public partial class StepAliasMapping
    {
        private string _stepAlias;
        private string _stepId;

        /// <summary>
        /// Gets and sets the property StepAlias. 
        /// <para>
        /// The alias for the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StepAlias
        {
            get { return this._stepAlias; }
            set { this._stepAlias = value; }
        }

        // Check to see if StepAlias property is set
        internal bool IsSetStepAlias()
        {
            return this._stepAlias != null;
        }

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The unique identifier of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

    }
}