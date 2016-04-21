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
    /// <zonbook/> <xhtml/>
    /// </summary>
    public partial class DescribeAssessmentTargetsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentTarget> _assessmentTargets = new List<AssessmentTarget>();
        private Dictionary<string, FailedItemDetails> _failedItems = new Dictionary<string, FailedItemDetails>();

        /// <summary>
        /// Gets and sets the property AssessmentTargets. 
        /// <para>
        /// Information about the assessment targets.
        /// </para>
        /// </summary>
        public List<AssessmentTarget> AssessmentTargets
        {
            get { return this._assessmentTargets; }
            set { this._assessmentTargets = value; }
        }

        // Check to see if AssessmentTargets property is set
        internal bool IsSetAssessmentTargets()
        {
            return this._assessmentTargets != null && this._assessmentTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Assessment target details that cannot be described. An error code is provided for
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