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

namespace Amazon.BCMRecommendedActions.Model
{
    /// <summary>
    /// Describes a specific recommended action.
    /// </summary>
    public partial class RecommendedAction
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that the recommended action is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Context that applies to the recommended action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Context { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null && (this.Context.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature associated with the recommended action.
        /// </para>
        /// </summary>
        public Feature Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the recommended action.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time when the recommended action status was last updated.
        /// </para>
        /// </summary>
        public string LastUpdatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimeStamp() => this.LastUpdatedTimeStamp != null;

        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        /// The possible next steps to execute the recommended action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NextSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NextSteps property is set.
        /// </summary>
        internal bool IsSetNextSteps() => this.NextSteps != null && (this.NextSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity associated with the recommended action.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of action you can take by adopting the recommended action.
        /// </para>
        /// </summary>
        public ActionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
