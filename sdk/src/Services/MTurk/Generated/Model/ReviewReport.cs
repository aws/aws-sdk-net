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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Contains both ReviewResult and ReviewAction elements for a particular HIT.
    /// </summary>
    public partial class ReviewReport
    {
        private List<ReviewActionDetail> _reviewActions = new List<ReviewActionDetail>();
        private List<ReviewResultDetail> _reviewResults = new List<ReviewResultDetail>();

        /// <summary>
        /// Gets and sets the property ReviewActions. 
        /// <para>
        ///  A list of ReviewAction objects for each action specified in the Review Policy. 
        /// </para>
        /// </summary>
        public List<ReviewActionDetail> ReviewActions
        {
            get { return this._reviewActions; }
            set { this._reviewActions = value; }
        }

        // Check to see if ReviewActions property is set
        internal bool IsSetReviewActions()
        {
            return this._reviewActions != null && this._reviewActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReviewResults. 
        /// <para>
        ///  A list of ReviewResults objects for each action specified in the Review Policy. 
        /// </para>
        /// </summary>
        public List<ReviewResultDetail> ReviewResults
        {
            get { return this._reviewResults; }
            set { this._reviewResults = value; }
        }

        // Check to see if ReviewResults property is set
        internal bool IsSetReviewResults()
        {
            return this._reviewResults != null && this._reviewResults.Count > 0; 
        }

    }
}