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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the GetExclusionsPreview operation. Retrieves the
    /// exclusions preview (a list of ExclusionPreview objects) specified by the preview token.
    /// You can obtain the preview token by running the CreateExclusionsPreview API.
    /// </summary>
    public partial class GetExclusionsPreviewRequest : AmazonInspectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentTemplateArn. 
        /// <para>
        /// The ARN that specifies the assessment template for which the exclusions preview was
        /// requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string AssessmentTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTemplateArn property is set.
        /// </summary>
        internal bool IsSetAssessmentTemplateArn() => this.AssessmentTemplateArn != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale into which you want to translate the exclusion's title, description, and
        /// recommendation.
        /// </para>
        /// </summary>
        public Locale Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items you want in the
        /// response. The default value is 100. The maximum value is 500.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// You can use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the GetExclusionsPreviewRequest action. Subsequent calls
        /// to the action fill nextToken in the request with the value of nextToken from the previous
        /// response to continue listing data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PreviewToken. 
        /// <para>
        /// The unique identifier associated of the exclusions preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PreviewToken { get; set; }

        /// <summary>
        /// Checks to see if the PreviewToken property is set.
        /// </summary>
        internal bool IsSetPreviewToken() => this.PreviewToken != null;
    }
}
