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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the criteria used to filter investigations.
    /// </summary>
    public partial class InvestigationFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property Criterion. 
        /// <para>
        /// A map of investigation attributes to the conditions that they must match. When you
        /// specify more than one attribute, an investigation must match the conditions for every
        /// attribute. Valid attributes and values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STATUS</c> – <c>RUNNING</c>, <c>COMPLETED</c>, and <c>FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RISK_LEVEL</c> – <c>Info</c>, <c>Low</c>, <c>Medium</c>, <c>High</c>, and <c>Critical</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFIDENCE</c> – <c>Unknown</c>, <c>Low</c>, <c>Medium</c>, and <c>High</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINDING_ID</c> – A finding ID, which is 32 lowercase hexadecimal characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVESTIGATION_TYPE</c> – <c>FINDING</c>, <c>ACCOUNT</c>, and <c>ORGANIZATION</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Values are case sensitive. GuardDuty sets the risk level, confidence, and investigation
        /// type of an investigation only when the investigation completes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, InvestigationFilterCondition> Criterion { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, InvestigationFilterCondition>() : null;

        /// <summary>
        /// Checks to see if the Criterion property is set.
        /// </summary>
        internal bool IsSetCriterion() => this.Criterion != null && (this.Criterion.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
