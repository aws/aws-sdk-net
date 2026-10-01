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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A summary of the collaboration privacy budgets. This summary includes the collaboration
    /// information, creation information, epsilon provided, and utility in terms of aggregations.
    /// </summary>
    public partial class CollaborationPrivacyBudgetSummary
    {
        /// <summary>
        /// Gets and sets the property Budget. 
        /// <para>
        /// The includes epsilon provided and utility in terms of aggregations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivacyBudget Budget { get; set; }

        /// <summary>
        /// Checks to see if the Budget property is set.
        /// </summary>
        internal bool IsSetBudget() => this.Budget != null;

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The ARN of the collaboration that includes this privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string CollaborationArn { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationArn property is set.
        /// </summary>
        internal bool IsSetCollaborationArn() => this.CollaborationArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique identifier of the collaboration that includes this privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the privacy budget was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The unique identifier of the account that created this privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collaboration privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateArn. 
        /// <para>
        /// The ARN of the collaboration privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string PrivacyBudgetTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyBudgetTemplateArn property is set.
        /// </summary>
        internal bool IsSetPrivacyBudgetTemplateArn() => this.PrivacyBudgetTemplateArn != null;

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateId. 
        /// <para>
        /// The unique identifier of the collaboration privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PrivacyBudgetTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyBudgetTemplateId property is set.
        /// </summary>
        internal bool IsSetPrivacyBudgetTemplateId() => this.PrivacyBudgetTemplateId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivacyBudgetType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the privacy budget was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
