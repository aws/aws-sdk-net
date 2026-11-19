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
    /// Contains a recommended action.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the recommendation. Possible values are <c>ENABLE_PROTECTION</c>,
        /// <c>FURTHER_INVESTIGATION</c>, <c>SUPPRESSION_RULE</c>, <c>HARDENING</c>, and <c>MONITORING</c>.
        /// </para>
        /// </summary>
        public RecommendationCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CliCommands. 
        /// <para>
        /// CLI commands that you can run to carry out the recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> CliCommands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CliCommands property is set.
        /// </summary>
        internal bool IsSetCliCommands() => this.CliCommands != null && (this.CliCommands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the recommendation. Possible values are <c>IMMEDIATE</c>, <c>SHORT_TERM</c>,
        /// and <c>STRATEGIC</c>.
        /// </para>
        /// </summary>
        public ActionPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property Rationale. 
        /// <para>
        /// The reason for the recommendation.
        /// </para>
        /// </summary>
        public string Rationale { get; set; }

        /// <summary>
        /// Checks to see if the Rationale property is set.
        /// </summary>
        internal bool IsSetRationale() => this.Rationale != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title for the recommendation.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
