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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the findings for an Amazon Web Services account in an organization
    /// unused access analyzer.
    /// </summary>
    public partial class FindingAggregationAccountDetails
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The ID of the Amazon Web Services account for which unused access finding details
        /// are provided.
        /// </para>
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Provides the number of active findings for each type of unused access for the specified
        /// Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> Details { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfActiveFindings. 
        /// <para>
        /// The number of active unused access findings for the specified Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        public int? NumberOfActiveFindings { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfActiveFindings property is set.
        /// </summary>
        internal bool IsSetNumberOfActiveFindings() => this.NumberOfActiveFindings.HasValue;
    }
}
