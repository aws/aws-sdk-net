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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// This is the response object from the CreateTemplate operation.
    /// </summary>
    public partial class CreateTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags added to the migration workflow template.
        /// </para>
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
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the migration workflow template. The format for
        /// an Migration Hub Orchestrator template ARN is <c>arn:aws:migrationhub-orchestrator:region:account:template/template-abcd1234</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the migration workflow template.
        /// </para>
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
