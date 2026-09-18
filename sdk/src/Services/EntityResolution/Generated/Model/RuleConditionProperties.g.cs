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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The properties of a rule condition that provides the ability to use more complex syntax.
    /// </summary>
    public partial class RuleConditionProperties
    {
        /// <summary>
        /// Gets and sets the property MatchingConfig. 
        /// <para>
        /// An object that contains configuration settings for the matching process.
        /// </para>
        /// </summary>
        public MatchingConfig MatchingConfig { get; set; }

        /// <summary>
        /// Checks to see if the MatchingConfig property is set.
        /// </summary>
        internal bool IsSetMatchingConfig() => this.MatchingConfig != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  A list of rule objects, each of which have fields <c>ruleName</c> and <c>condition</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<RuleCondition> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleCondition>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
