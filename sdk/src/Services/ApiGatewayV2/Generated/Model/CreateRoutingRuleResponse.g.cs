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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreateRoutingRule operation.
    /// </summary>
    public partial class CreateRoutingRuleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// Represents a routing rule action. The only supported action is invokeApi.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingRuleAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingRuleAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// Represents a condition. Conditions can contain up to two matchHeaders conditions and
        /// one matchBasePaths conditions. API Gateway evaluates header conditions and base path
        /// conditions together. You can only use AND between header and base path conditions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingRuleCondition> Conditions { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingRuleCondition>() : null;

        /// <summary>
        /// Checks to see if the Conditions property is set.
        /// </summary>
        internal bool IsSetConditions() => this.Conditions != null && (this.Conditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. 
        /// &lt;para&gt;
        /// Represents the priority of the routing rule.
        /// &lt;para&gt;
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RoutingRuleArn. 
        /// &lt;para&gt;
        /// The ARN of the domain name.
        /// &lt;para&gt;
        /// </summary>
        public string RoutingRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoutingRuleArn property is set.
        /// </summary>
        internal bool IsSetRoutingRuleArn() => this.RoutingRuleArn != null;

        /// <summary>
        /// Gets and sets the property RoutingRuleId. 
        /// <para>
        /// The routing rule ID.
        /// </para>
        /// </summary>
        public string RoutingRuleId { get; set; }

        /// <summary>
        /// Checks to see if the RoutingRuleId property is set.
        /// </summary>
        internal bool IsSetRoutingRuleId() => this.RoutingRuleId != null;
    }
}
