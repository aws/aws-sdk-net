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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssessment operation. Starts an assessment
    /// of a product entity against a framework. An <i>assessment</i> is the result of evaluating
    /// an entity against the controls of a framework. You choose the controls to run and
    /// provide the input that each control needs. <para> The assessment runs asynchronously.
    /// This action returns the ID of the assessment immediately. To get its status and the
    /// results of each control, use the <c>DescribeAssessment</c> action. To find assessments
    /// that you started earlier, use the <c>ListAssessments</c> action. </para>
    /// </summary>
    public partial class StartAssessmentRequest : AmazonMarketplaceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token to identify the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        /// The controls to provide input for. Every control in the framework is included in the
        /// assessment, and a control that you don't specify gets no input. You can specify 1–100
        /// controls.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ControlInput> Controls { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlInput>() : null;

        /// <summary>
        /// Checks to see if the Controls property is set.
        /// </summary>
        internal bool IsSetControls() => this.Controls != null && (this.Controls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique ID of the product entity to assess.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The unique identifier of the framework that defines the controls to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string FrameworkId { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkId property is set.
        /// </summary>
        internal bool IsSetFrameworkId() => this.FrameworkId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags to apply to the assessment when you create it. Each tag is a key-value
        /// pair. You can specify 1–200 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
