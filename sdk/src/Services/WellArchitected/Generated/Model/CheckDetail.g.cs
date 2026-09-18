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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Account details for a Well-Architected best practice in relation to Trusted Advisor
    /// checks.
    /// </summary>
    public partial class CheckDetail
    {
        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ChoiceId { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceId property is set.
        /// </summary>
        internal bool IsSetChoiceId() => this.ChoiceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Trusted Advisor check description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlaggedResources. 
        /// <para>
        /// Count of flagged resources associated to the check.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9999)]
        public int? FlaggedResources { get; set; }

        /// <summary>
        /// Checks to see if the FlaggedResources property is set.
        /// </summary>
        internal bool IsSetFlaggedResources() => this.FlaggedResources.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Trusted Advisor check ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// Well-Architected Lens ARN associated to the check.
        /// </para>
        /// </summary>
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Trusted Advisor check name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PillarId { get; set; }

        /// <summary>
        /// Checks to see if the PillarId property is set.
        /// </summary>
        internal bool IsSetPillarId() => this.PillarId != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// Provider of the check related to the best practice.
        /// </para>
        /// </summary>
        public CheckProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Reason associated to the check.
        /// </para>
        /// </summary>
        public CheckFailureReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status associated to the check.
        /// </para>
        /// </summary>
        public CheckStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the check was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
