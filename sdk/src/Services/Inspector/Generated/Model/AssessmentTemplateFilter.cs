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
    /// Used as the request parameter in the <a>ListAssessmentTemplates</a> action.
    /// </summary>
    public partial class AssessmentTemplateFilter
    {
        private DurationRange _durationRange;
        private string _namePattern;
        private List<string> _rulesPackageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DurationRange. 
        /// <para>
        /// For a record to match a filter, the value specified for this data type property must
        /// inclusively match any value between the specified minimum and maximum values of the
        /// <b>durationInSeconds</b> property of the <a>AssessmentTemplate</a> data type.
        /// </para>
        /// </summary>
        public DurationRange DurationRange
        {
            get { return this._durationRange; }
            set { this._durationRange = value; }
        }

        // Check to see if DurationRange property is set
        internal bool IsSetDurationRange()
        {
            return this._durationRange != null;
        }

        /// <summary>
        /// Gets and sets the property NamePattern. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string that contains a wildcard
        /// that is specified for this data type property must match the value of the <b>assessmentTemplateName</b>
        /// property of the <a>AssessmentTemplate</a> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string NamePattern
        {
            get { return this._namePattern; }
            set { this._namePattern = value; }
        }

        // Check to see if NamePattern property is set
        internal bool IsSetNamePattern()
        {
            return this._namePattern != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// For a record to match a filter, the values that are specified for this data type property
        /// must be contained in the list of values of the <b>rulesPackageArns</b> property of
        /// the <a>AssessmentTemplate</a> data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && (this._rulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}