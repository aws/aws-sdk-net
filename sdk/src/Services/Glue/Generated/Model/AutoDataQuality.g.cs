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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies configuration options for automatic data quality evaluation in Glue jobs.
    /// This structure enables automated data quality checks and monitoring during ETL operations,
    /// helping to ensure data integrity and reliability without manual intervention.
    /// </summary>
    public partial class AutoDataQuality
    {
        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context for the automatic data quality checks. This defines the scope
        /// and parameters for the data quality evaluation.
        /// </para>
        /// </summary>
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Specifies whether automatic data quality evaluation is enabled. When set to <c>true</c>,
        /// data quality checks are performed automatically.
        /// </para>
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;
    }
}
