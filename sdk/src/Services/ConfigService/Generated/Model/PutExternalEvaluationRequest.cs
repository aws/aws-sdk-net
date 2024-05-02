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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutExternalEvaluation operation.
    /// Add or updates the evaluations for process checks. This API checks if the rule is
    /// a process check when the name of the Config rule is provided.
    /// </summary>
    public partial class PutExternalEvaluationRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;
        private ExternalEvaluation _externalEvaluation;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalEvaluation. 
        /// <para>
        /// An <c>ExternalEvaluation</c> object that provides details about compliance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExternalEvaluation ExternalEvaluation
        {
            get { return this._externalEvaluation; }
            set { this._externalEvaluation = value; }
        }

        // Check to see if ExternalEvaluation property is set
        internal bool IsSetExternalEvaluation()
        {
            return this._externalEvaluation != null;
        }

    }
}