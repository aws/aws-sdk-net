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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the InsightFeedback operation. Submits feedback for
    /// an existing insight in an Amazon OpenSearch Service domain. Allows users to provide
    /// a thumbs up or thumbs down rating and optional text feedback for a specific insight.
    /// </summary>
    public partial class InsightFeedbackRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity for which to submit insight feedback. Specifies the type and value of the
        /// entity, such as a domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightFeedbackEntity Entity { get; set; }

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null;

        /// <summary>
        /// Gets and sets the property FeedbackText. 
        /// <para>
        /// Optional text feedback providing additional details about the insight. Maximum length
        /// is 1000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string FeedbackText { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackText property is set.
        /// </summary>
        internal bool IsSetFeedbackText() => this.FeedbackText != null;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier of the insight for which to submit feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property Thumbs. 
        /// <para>
        /// The thumbs up or thumbs down feedback for the insight. Possible values are <c>Up</c>
        /// and <c>Down</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightFeedbackThumbs Thumbs { get; set; }

        /// <summary>
        /// Checks to see if the Thumbs property is set.
        /// </summary>
        internal bool IsSetThumbs() => this.Thumbs != null;
    }
}
