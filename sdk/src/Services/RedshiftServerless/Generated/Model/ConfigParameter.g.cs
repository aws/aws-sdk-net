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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// An array of key-value pairs to set for advanced control over Amazon Redshift Serverless.
    /// </summary>
    public partial class ConfigParameter
    {
        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The key of the parameter. The options are <c>auto_mv</c>, <c>datestyle</c>, <c>enable_case_sensitive_identifier</c>,
        /// <c>enable_user_activity_logging</c>, <c>query_group</c>, <c>search_path</c>, <c>require_ssl</c>,
        /// <c>use_fips_ssl</c>, and either <c>wlm_json_configuration</c> or query monitoring
        /// metrics that let you define performance boundaries. You can either specify individual
        /// query monitoring metrics (such as <c>max_scan_row_count</c>, <c>max_query_execution_time</c>)
        /// or use <c>wlm_json_configuration</c> to define query queues with rules, but not both.
        /// If you're using <c>wlm_json_configuration</c>, the maximum size of <c>parameterValue</c>
        /// is 8000 characters. For more information about query monitoring rules and available
        /// metrics, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/cm-c-wlm-query-monitoring-rules.html#cm-c-wlm-query-monitoring-metrics-serverless">Query
        /// monitoring metrics for Amazon Redshift Serverless</a>.
        /// </para>
        /// </summary>
        public string ParameterKey { get; set; }

        /// <summary>
        /// Checks to see if the ParameterKey property is set.
        /// </summary>
        internal bool IsSetParameterKey() => this.ParameterKey != null;

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value of the parameter to set.
        /// </para>
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// Checks to see if the ParameterValue property is set.
        /// </summary>
        internal bool IsSetParameterValue() => this.ParameterValue != null;
    }
}
