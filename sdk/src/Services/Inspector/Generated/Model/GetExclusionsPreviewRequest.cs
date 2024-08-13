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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
    /// Container for the parameters to the GetExclusionsPreview operation.
    /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
    /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
    /// API.
    /// </summary>
    public partial class GetExclusionsPreviewRequest : AmazonInspectorRequest
    {
        private string _assessmentTemplateArn;
        private Locale _locale;
        private int? _maxResults;
        private string _nextToken;
        private string _previewToken;

        /// <summary>
        /// Gets and sets the property AssessmentTemplateArn. 
        /// <para>
        /// The ARN that specifies the assessment template for which the exclusions preview was
        /// requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentTemplateArn
        {
            get { return this._assessmentTemplateArn; }
            set { this._assessmentTemplateArn = value; }
        }

        // Check to see if AssessmentTemplateArn property is set
        internal bool IsSetAssessmentTemplateArn()
        {
            return this._assessmentTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale into which you want to translate the exclusion's title, description, and
        /// recommendation.
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items you want in the
        /// response. The default value is 100. The maximum value is 500.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// You can use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the GetExclusionsPreviewRequest action. Subsequent calls
        /// to the action fill nextToken in the request with the value of nextToken from the previous
        /// response to continue listing data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PreviewToken. 
        /// <para>
        /// The unique identifier associated of the exclusions preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PreviewToken
        {
            get { return this._previewToken; }
            set { this._previewToken = value; }
        }

        // Check to see if PreviewToken property is set
        internal bool IsSetPreviewToken()
        {
            return this._previewToken != null;
        }

    }
}