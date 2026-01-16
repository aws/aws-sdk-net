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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Metadata information about an evaluation review.
    /// </summary>
    public partial class EvaluationReviewMetadata
    {
        private string _createdBy;
        private DateTime? _createdTime;
        private string _reviewId;
        private List<EvaluationReviewRequestComment> _reviewRequestComments = AWSConfigs.InitializeCollections ? new List<EvaluationReviewRequestComment>() : null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the evaluation review.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the evaluation review was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReviewId. 
        /// <para>
        /// The unique identifier for the evaluation review.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ReviewId
        {
            get { return this._reviewId; }
            set { this._reviewId = value; }
        }

        // Check to see if ReviewId property is set
        internal bool IsSetReviewId()
        {
            return this._reviewId != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewRequestComments. 
        /// <para>
        /// Comments provided when requesting the evaluation review.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1)]
        public List<EvaluationReviewRequestComment> ReviewRequestComments
        {
            get { return this._reviewRequestComments; }
            set { this._reviewRequestComments = value; }
        }

        // Check to see if ReviewRequestComments property is set
        internal bool IsSetReviewRequestComments()
        {
            return this._reviewRequestComments != null && (this._reviewRequestComments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}