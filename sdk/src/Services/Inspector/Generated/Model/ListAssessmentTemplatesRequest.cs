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
    /// Container for the parameters to the ListAssessmentTemplates operation.
    /// Lists the assessment templates that correspond to the assessment targets that are
    /// specified by the ARNs of the assessment targets.
    /// </summary>
    public partial class ListAssessmentTemplatesRequest : AmazonInspectorRequest
    {
        private List<string> _assessmentTargetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssessmentTemplateFilter _filter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArns. 
        /// <para>
        /// A list of ARNs that specifies the assessment targets whose assessment templates you
        /// want to list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> AssessmentTargetArns
        {
            get { return this._assessmentTargetArns; }
            set { this._assessmentTargetArns = value; }
        }

        // Check to see if AssessmentTargetArns property is set
        internal bool IsSetAssessmentTargetArns()
        {
            return this._assessmentTargetArns != null && (this._assessmentTargetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// You can use this parameter to specify a subset of data to be included in the action's
        /// response.
        /// </para>
        ///  
        /// <para>
        /// For a record to match a filter, all specified filter attributes must match. When multiple
        /// values are specified for a filter attribute, any of the values can match.
        /// </para>
        /// </summary>
        public AssessmentTemplateFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items you want in the
        /// response. The default value is 10. The maximum value is 500.
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
        /// to null on your first call to the <b>ListAssessmentTemplates</b> action. Subsequent
        /// calls to the action fill <b>nextToken</b> in the request with the value of <b>NextToken</b>
        /// from the previous response to continue listing data.
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

    }
}