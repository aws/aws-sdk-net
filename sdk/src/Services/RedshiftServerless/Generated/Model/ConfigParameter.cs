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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// An array of key-value pairs to set for advanced control over Amazon Redshift Serverless.
    /// </summary>
    public partial class ConfigParameter
    {
        private string _parameterKey;
        private string _parameterValue;

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The key of the parameter. The options are <code>auto_mv</code>, <code>datestyle</code>,
        /// <code>enable_case_sensitivity_identifier</code>, <code>enable_user_activity_logging</code>,
        /// <code>query_group</code>, <code>search_path</code>, and query monitoring metrics that
        /// let you define performance boundaries. For more information about query monitoring
        /// rules and available metrics, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/cm-c-wlm-query-monitoring-rules.html#cm-c-wlm-query-monitoring-metrics-serverless">Query
        /// monitoring metrics for Amazon Redshift Serverless</a>.
        /// </para>
        /// </summary>
        public string ParameterKey
        {
            get { return this._parameterKey; }
            set { this._parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this._parameterKey != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value of the parameter to set.
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

    }
}