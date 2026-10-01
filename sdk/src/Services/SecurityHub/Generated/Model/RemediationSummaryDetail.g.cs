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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A summary of the remediation target.
    /// </summary>
    public partial class RemediationSummaryDetail
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// A summarized action to take for the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the remediation target.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsImmediate. 
        /// <para>
        /// Specifies whether the effect of this target is immediate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsImmediate { get; set; }

        /// <summary>
        /// Checks to see if the IsImmediate property is set.
        /// </summary>
        internal bool IsSetIsImmediate() => this.IsImmediate.HasValue;

        /// <summary>
        /// Gets and sets the property KbArticles. 
        /// <para>
        /// An array of <c>KbArticle</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<KbArticle> KbArticles { get; set; } = AWSConfigs.InitializeCollections ? new List<KbArticle>() : null;

        /// <summary>
        /// Checks to see if the KbArticles property is set.
        /// </summary>
        internal bool IsSetKbArticles() => this.KbArticles != null && (this.KbArticles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PostRemediationSteps. 
        /// <para>
        /// An array of steps to be taken after remediation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> PostRemediationSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PostRemediationSteps property is set.
        /// </summary>
        internal bool IsSetPostRemediationSteps() => this.PostRemediationSteps != null && (this.PostRemediationSteps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
