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
    /// Container for the parameters to the StartAgentRecommendationGeneration operation.
    /// Starts a recommendation generation process for the specified agent profile. This asynchronous
    /// operation returns immediately. Use <c>GetAgentRecommendationGeneration</c> to check
    /// the status of the generation. <para> Currently, only the <c>ARCHITECTURE</c> recommendation
    /// type is supported. <c>RESOURCE</c> and <c>APPLICATION</c> recommendations are generated
    /// only by the scheduled generation cycle and cannot be started with this operation.
    /// </para> <para> For the <c>ARCHITECTURE</c> type, the generation analyzes the infrastructure
    /// as code (IaC) template that you specify in <c>additionalContext</c>, and returns updated
    /// templates with best practice fixes applied. You must specify <c>scope</c> and <c>additionalContext</c>.
    /// You can optionally specify <c>name</c>. </para> <para> Architecture review generations
    /// are subject to a daily quota for each profile. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/agent-quotas.html">Quotas
    /// and limits</a> in the Amazon Web Services Well-Architected User Guide. </para>
    /// </summary>
    public partial class StartAgentRecommendationGenerationRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// The location of the infrastructure as code (IaC) template to review, and the lenses
        /// to review it against. Required for the <c>ARCHITECTURE</c> type. Must be absent for
        /// other types. Specify a JSON object with the following members:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3Uri</c>: The Amazon S3 URI of the IaC template, .zip archive, or folder to review.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3VersionId</c>: The version ID of the Amazon S3 object. If you omit this member,
        /// the current version is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lensArns</c>: The ARNs of the lenses to review against. Only <c>arn:aws:wellarchitected::aws:lens/wellarchitected</c>
        /// is supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document AdditionalContext { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalContext property is set.
        /// </summary>
        internal bool IsSetAdditionalContext() => !this.AdditionalContext.IsNull();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for this generation that identifies the architecture review in the
        /// console and in <c>ListAgentRecommendationGenerations</c> results. Applies to <c>ARCHITECTURE</c>
        /// type only. Must be absent for other types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization profile to use for generating recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Defines which pillars, goals, and items the review covers. Required for the <c>ARCHITECTURE</c>
        /// type. Must be absent for other types.
        /// </para>
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The types of recommendations to generate. You can specify up to two types in a single
        /// request. Currently, only <c>ARCHITECTURE</c> is supported for this operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
