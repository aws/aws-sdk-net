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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// The attack information for the specified SubResource.
    /// </summary>
    public partial class SubResourceSummary
    {
        /// <summary>
        /// Gets and sets the property AttackVectors. 
        /// <para>
        /// The list of attack types and associated counters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedAttackVector> AttackVectors { get; set; } = AWSConfigs.InitializeCollections ? new List<SummarizedAttackVector>() : null;

        /// <summary>
        /// Checks to see if the AttackVectors property is set.
        /// </summary>
        internal bool IsSetAttackVectors() => this.AttackVectors != null && (this.AttackVectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Counters. 
        /// <para>
        /// The counters that describe the details of the attack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedCounter> Counters { get; set; } = AWSConfigs.InitializeCollections ? new List<SummarizedCounter>() : null;

        /// <summary>
        /// Checks to see if the Counters property is set.
        /// </summary>
        internal bool IsSetCounters() => this.Counters != null && (this.Counters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of the <c>SubResource</c>.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The <c>SubResource</c> type.
        /// </para>
        /// </summary>
        public SubResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
