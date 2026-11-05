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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEvaluationForm operation. Updates details
    /// about a specific evaluation form version in the specified Connect Customer instance.
    /// Question and section identifiers cannot be duplicated within the same evaluation form.
    /// <para> This operation does not support partial updates. Instead it does a full update
    /// of evaluation form content. </para>
    /// </summary>
    public partial class UpdateEvaluationFormRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AIVersion. 
        /// <para>
        /// The AI version to use for the evaluation form. This specifies which AI model version
        /// is used for automated evaluations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AIVersion { get; set; }

        /// <summary>
        /// Checks to see if the AIVersion property is set.
        /// </summary>
        internal bool IsSetAIVersion() => this.AIVersion != null;

        /// <summary>
        /// Gets and sets the property AsDraft. 
        /// <para>
        /// A boolean flag indicating whether to update evaluation form to draft state.
        /// </para>
        /// </summary>
        public bool? AsDraft { get; set; }

        /// <summary>
        /// Checks to see if the AsDraft property is set.
        /// </summary>
        internal bool IsSetAsDraft() => this.AsDraft.HasValue;

        /// <summary>
        /// Gets and sets the property AutoEvaluationConfiguration. 
        /// <para>
        /// Whether automated evaluations are enabled.
        /// </para>
        /// </summary>
        public EvaluationFormAutoEvaluationConfiguration AutoEvaluationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationConfiguration() => this.AutoEvaluationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreateNewVersion. 
        /// <para>
        /// A flag indicating whether the operation must create a new version.
        /// </para>
        /// </summary>
        public bool? CreateNewVersion { get; set; }

        /// <summary>
        /// Checks to see if the CreateNewVersion property is set.
        /// </summary>
        internal bool IsSetCreateNewVersion() => this.CreateNewVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the evaluation form.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EvaluationFormVersion { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormVersion property is set.
        /// </summary>
        internal bool IsSetEvaluationFormVersion() => this.EvaluationFormVersion.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Items that are part of the evaluation form. The total number of sections and questions
        /// must not exceed 100 each. Questions must be contained in a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EvaluationFormItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageConfiguration. 
        /// <para>
        /// Configuration for language settings of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageConfiguration LanguageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LanguageConfiguration property is set.
        /// </summary>
        internal bool IsSetLanguageConfiguration() => this.LanguageConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReviewConfiguration. 
        /// <para>
        /// Configuration for evaluation review settings of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationReviewConfiguration ReviewConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReviewConfiguration property is set.
        /// </summary>
        internal bool IsSetReviewConfiguration() => this.ReviewConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScoringStrategy. 
        /// <para>
        /// A scoring strategy of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormScoringStrategy ScoringStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ScoringStrategy property is set.
        /// </summary>
        internal bool IsSetScoringStrategy() => this.ScoringStrategy != null;

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Configuration that specifies the target for the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormTargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
