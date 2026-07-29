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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the PutComplianceInquiryFeedback operation.
    /// Submits feedback on a compliance inquiry response.
    /// </summary>
    public partial class PutComplianceInquiryFeedbackRequest : AmazonArtifactRequest
    {
        private string _clientToken;
        private string _comment;
        private string _complianceInquiryId;
        private int? _queryIdentifier;
        private FeedbackRating _rating;
        private List<string> _reasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _responseRevisionId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment for the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceInquiryId. 
        /// <para>
        /// The unique identifier for the compliance inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComplianceInquiryId
        {
            get { return this._complianceInquiryId; }
            set { this._complianceInquiryId = value; }
        }

        // Check to see if ComplianceInquiryId property is set
        internal bool IsSetComplianceInquiryId()
        {
            return this._complianceInquiryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryIdentifier. 
        /// <para>
        /// The sequential identifier of the query to provide feedback on.
        /// </para>
        /// </summary>
        public int? QueryIdentifier
        {
            get { return this._queryIdentifier; }
            set { this._queryIdentifier = value; }
        }

        // Check to see if QueryIdentifier property is set
        internal bool IsSetQueryIdentifier()
        {
            return this._queryIdentifier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rating. 
        /// <para>
        /// The rating for the feedback. Valid values are THUMBS_UP and THUMBS_DOWN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackRating Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }

        // Check to see if Rating property is set
        internal bool IsSetRating()
        {
            return this._rating != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCodes. 
        /// <para>
        /// The reason codes that describe why you rated the response. Valid values are OTHER,
        /// PARTIAL_RESPONSE, and IRRELEVANT_RESPONSE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReasonCodes
        {
            get { return this._reasonCodes; }
            set { this._reasonCodes = value; }
        }

        // Check to see if ReasonCodes property is set
        internal bool IsSetReasonCodes()
        {
            return this._reasonCodes != null && (this._reasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseRevisionId. 
        /// <para>
        /// The response revision ID. Use this value to prevent submitting feedback on a stale
        /// response.
        /// </para>
        /// </summary>
        public int? ResponseRevisionId
        {
            get { return this._responseRevisionId; }
            set { this._responseRevisionId = value; }
        }

        // Check to see if ResponseRevisionId property is set
        internal bool IsSetResponseRevisionId()
        {
            return this._responseRevisionId.HasValue; 
        }

    }
}