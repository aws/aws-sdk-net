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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBudget operation. Creates a budget to set
    /// spending thresholds for your rendering activity.
    /// </summary>
    public partial class CreateBudgetRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. The budget actions to specify what happens when
        /// the budget runs out.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<BudgetActionToAdd> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<BudgetActionToAdd>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApproximateDollarLimit. The dollar limit based on consumed
        /// usage.
        /// </summary>
        [AWSProperty(Required = true)]
        public float? ApproximateDollarLimit { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateDollarLimit property is set.
        /// </summary>
        internal bool IsSetApproximateDollarLimit() => this.ApproximateDollarLimit.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. The unique token which the server uses to
        /// recognize retries of the same request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the budget.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the budget.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID to include in this budget.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property Schedule. The schedule to associate with this budget.
        /// </summary>
        [AWSProperty(Required = true)]
        public BudgetSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Tags. Each tag consists of a tag key and a tag value. Tag
        /// keys and values are both required, but tag values can be empty strings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageTrackingResource. The queue ID provided to this budget
        /// to track usage.
        /// </summary>
        [AWSProperty(Required = true)]
        public UsageTrackingResource UsageTrackingResource { get; set; }

        /// <summary>
        /// Checks to see if the UsageTrackingResource property is set.
        /// </summary>
        internal bool IsSetUsageTrackingResource() => this.UsageTrackingResource != null;
    }
}
