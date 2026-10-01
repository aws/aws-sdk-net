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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains the result of an automated audit analysis, including the
    /// auditor name, description of findings, additional data, and severity level.
    /// </summary>
    public partial class AuditorResult
    {
        /// <summary>
        /// Gets and sets the property Auditor. 
        /// <para>
        /// The name of the auditor algorithm that generated this result.
        /// </para>
        /// </summary>
        public string Auditor { get; set; }

        /// <summary>
        /// Checks to see if the Auditor property is set.
        /// </summary>
        internal bool IsSetAuditor() => this.Auditor != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// This is a string-to-string map. It contains additional data about the result of an
        /// automated audit analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Data { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null && (this.Data.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the audit finding, explaining what was observed and potential
        /// implications.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10240)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of this audit finding, indicating the importance and potential
        /// impact of the issue.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
