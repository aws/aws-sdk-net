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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetRuleSet operation.
    /// </summary>
    public partial class GetRuleSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date of when then rule set was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModificationDate. 
        /// <para>
        /// The date of when the rule set was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationDate property is set.
        /// </summary>
        internal bool IsSetLastModificationDate() => this.LastModificationDate.HasValue;

        /// <summary>
        /// Gets and sets the property RuleSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule set resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RuleSetArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetArn property is set.
        /// </summary>
        internal bool IsSetRuleSetArn() => this.RuleSetArn != null;

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of the rule set resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetId property is set.
        /// </summary>
        internal bool IsSetRuleSetId() => this.RuleSetId != null;

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A user-friendly name for the rule set resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RuleSetName { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetName property is set.
        /// </summary>
        internal bool IsSetRuleSetName() => this.RuleSetName != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules contained in the rule set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 40)]
        public List<Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
