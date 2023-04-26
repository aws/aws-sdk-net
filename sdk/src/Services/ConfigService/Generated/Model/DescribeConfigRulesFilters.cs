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
    /// Returns a filtered list of Detective or Proactive Config rules. By default, if the
    /// filter is not defined, this API returns an unfiltered list. For more information on
    /// Detective or Proactive Config rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config-rules.html">
    /// <b>Evaluation Mode</b> </a> in the Config Developer Guide.
    /// </summary>
    public partial class DescribeConfigRulesFilters
    {
        private EvaluationMode _evaluationMode;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation. The valid values are Detective or Proactive.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode
        {
            get { return this._evaluationMode; }
            set { this._evaluationMode = value; }
        }

        // Check to see if EvaluationMode property is set
        internal bool IsSetEvaluationMode()
        {
            return this._evaluationMode != null;
        }

    }
}