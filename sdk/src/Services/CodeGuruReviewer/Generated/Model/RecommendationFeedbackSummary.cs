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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about recommendation feedback summaries.
    /// </summary>
    public partial class RecommendationFeedbackSummary
    {
        private List<string> _reactions = new List<string>();
        private string _recommendationId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Reactions. 
        /// <para>
        /// List for storing reactions. Reactions are utf-8 text code for emojis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> Reactions
        {
            get { return this._reactions; }
            set { this._reactions = value; }
        }

        // Check to see if Reactions property is set
        internal bool IsSetReactions()
        {
            return this._reactions != null && this._reactions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The recommendation ID that can be used to track the provided recommendations. Later
        /// on it can be used to collect the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user that gave the feedback.
        /// </para>
        ///  
        /// <para>
        ///  The <code>UserId</code> is an IAM principal that can be specified as an Amazon Web
        /// Services account ID or an Amazon Resource Name (ARN). For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#Principal_specifying">
        /// Specifying a Principal</a> in the <i>Amazon Web Services Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}