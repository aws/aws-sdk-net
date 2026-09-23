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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a severity level for findings that a custom data identifier produces. A
    /// severity level determines which severity is assigned to the findings, based on the
    /// number of occurrences of text that match the custom data identifier's detection criteria.
    /// </summary>
    public partial class SeverityLevel
    {
        /// <summary>
        /// Gets and sets the property OccurrencesThreshold. 
        /// <para>
        /// The minimum number of occurrences of text that must match the custom data identifier's
        /// detection criteria in order to produce a finding with the specified severity (severity).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? OccurrencesThreshold { get; set; }

        /// <summary>
        /// Checks to see if the OccurrencesThreshold property is set.
        /// </summary>
        internal bool IsSetOccurrencesThreshold() => this.OccurrencesThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity to assign to a finding: if the number of occurrences is greater than
        /// or equal to the specified threshold (occurrencesThreshold); and, if applicable, the
        /// number of occurrences is less than the threshold for the next consecutive severity
        /// level for the custom data identifier, moving from LOW to HIGH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataIdentifierSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
