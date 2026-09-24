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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the PutComplianceInquiryFeedback operation. Submits
    /// feedback on a compliance inquiry response.
    /// </summary>
    public partial class PutComplianceInquiryFeedbackRequest : AmazonArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment for the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ComplianceInquiryId. 
        /// <para>
        /// The unique identifier for the compliance inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComplianceInquiryId { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceInquiryId property is set.
        /// </summary>
        internal bool IsSetComplianceInquiryId() => this.ComplianceInquiryId != null;

        /// <summary>
        /// Gets and sets the property QueryIdentifier. 
        /// <para>
        /// The sequential identifier of the query to provide feedback on.
        /// </para>
        /// </summary>
        public int? QueryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QueryIdentifier property is set.
        /// </summary>
        internal bool IsSetQueryIdentifier() => this.QueryIdentifier.HasValue;

        /// <summary>
        /// Gets and sets the property Rating. 
        /// <para>
        /// The rating for the feedback. Valid values are THUMBS_UP and THUMBS_DOWN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FeedbackRating Rating { get; set; }

        /// <summary>
        /// Checks to see if the Rating property is set.
        /// </summary>
        internal bool IsSetRating() => this.Rating != null;

        /// <summary>
        /// Gets and sets the property ReasonCodes. 
        /// <para>
        /// The reason codes that describe why you rated the response. Valid values are OTHER,
        /// PARTIAL_RESPONSE, and IRRELEVANT_RESPONSE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReasonCodes property is set.
        /// </summary>
        internal bool IsSetReasonCodes() => this.ReasonCodes != null && (this.ReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseRevisionId. 
        /// <para>
        /// The response revision ID. Use this value to prevent submitting feedback on a stale
        /// response.
        /// </para>
        /// </summary>
        public int? ResponseRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the ResponseRevisionId property is set.
        /// </summary>
        internal bool IsSetResponseRevisionId() => this.ResponseRevisionId.HasValue;
    }
}
