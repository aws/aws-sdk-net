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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Use EvaluationContext to group independently initiated proactive resource evaluations.
    /// For example, CFN Stack. If you want to check just a resource definition, you do not
    /// need to provide evaluation context.
    /// </summary>
    public partial class EvaluationContext
    {
        private string _evaluationContextIdentifier;

        /// <summary>
        /// Gets and sets the property EvaluationContextIdentifier. 
        /// <para>
        /// A unique EvaluationContextIdentifier ID for an EvaluationContext.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EvaluationContextIdentifier
        {
            get { return this._evaluationContextIdentifier; }
            set { this._evaluationContextIdentifier = value; }
        }

        // Check to see if EvaluationContextIdentifier property is set
        internal bool IsSetEvaluationContextIdentifier()
        {
            return this._evaluationContextIdentifier != null;
        }

    }
}