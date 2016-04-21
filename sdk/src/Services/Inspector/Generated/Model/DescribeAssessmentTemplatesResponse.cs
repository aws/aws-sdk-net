/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssessmentTemplates operation.
    /// </summary>
    public partial class DescribeAssessmentTemplatesResponse : AmazonWebServiceResponse
    {
        private List<AssessmentTemplate> _assessmentTemplates = new List<AssessmentTemplate>();
        private Dictionary<string, FailedItemDetails> _failedItems = new Dictionary<string, FailedItemDetails>();

        /// <summary>
        /// Gets and sets the property AssessmentTemplates. 
        /// <para>
        /// Information about the assessment template(s).
        /// </para>
        /// </summary>
        public List<AssessmentTemplate> AssessmentTemplates
        {
            get { return this._assessmentTemplates; }
            set { this._assessmentTemplates = value; }
        }

        // Check to see if AssessmentTemplates property is set
        internal bool IsSetAssessmentTemplates()
        {
            return this._assessmentTemplates != null && this._assessmentTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Assessment template details that cannot be described. An error code is provided for
        /// each failed item.
        /// </para>
        /// </summary>
        public Dictionary<string, FailedItemDetails> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && this._failedItems.Count > 0; 
        }

    }
}