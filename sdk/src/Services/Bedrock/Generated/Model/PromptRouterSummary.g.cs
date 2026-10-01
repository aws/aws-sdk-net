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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about a prompt router.
    /// </summary>
    public partial class PromptRouterSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the router was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The router's description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FallbackModel. 
        /// <para>
        /// The router's fallback model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptRouterTargetModel FallbackModel { get; set; }

        /// <summary>
        /// Checks to see if the FallbackModel property is set.
        /// </summary>
        internal bool IsSetFallbackModel() => this.FallbackModel != null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// The router's models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PromptRouterTargetModel> Models { get; set; } = AWSConfigs.InitializeCollections ? new List<PromptRouterTargetModel>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PromptRouterArn. 
        /// <para>
        /// The router's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PromptRouterArn { get; set; }

        /// <summary>
        /// Checks to see if the PromptRouterArn property is set.
        /// </summary>
        internal bool IsSetPromptRouterArn() => this.PromptRouterArn != null;

        /// <summary>
        /// Gets and sets the property PromptRouterName. 
        /// <para>
        /// The router's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PromptRouterName { get; set; }

        /// <summary>
        /// Checks to see if the PromptRouterName property is set.
        /// </summary>
        internal bool IsSetPromptRouterName() => this.PromptRouterName != null;

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// The router's routing criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RoutingCriteria property is set.
        /// </summary>
        internal bool IsSetRoutingCriteria() => this.RoutingCriteria != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The router's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptRouterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The summary's type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptRouterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// When the router was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
