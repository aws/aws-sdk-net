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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the CreateEngagementContext operation.
    /// </summary>
    public partial class CreateEngagementContextResponse : AmazonWebServiceResponse
    {
        private string _contextId;
        private string _engagementArn;
        private string _engagementId;
        private DateTime? _engagementLastModifiedAt;

        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// The unique identifier assigned to the newly created engagement context. This ID can
        /// be used to reference the specific context within the engagement for future operations.
        /// </para>
        /// </summary>
        public string ContextId
        {
            get { return this._contextId; }
            set { this._contextId = value; }
        }

        // Check to see if ContextId property is set
        internal bool IsSetContextId()
        {
            return this._contextId != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement to which the context was added. This
        /// globally unique identifier can be used for cross-service references and IAM policies.
        /// </para>
        /// </summary>
        public string EngagementArn
        {
            get { return this._engagementArn; }
            set { this._engagementArn = value; }
        }

        // Check to see if EngagementArn property is set
        internal bool IsSetEngagementArn()
        {
            return this._engagementArn != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The unique identifier of the engagement to which the context was added. This ID confirms
        /// the successful association of the context with the specified engagement.
        /// </para>
        /// </summary>
        public string EngagementId
        {
            get { return this._engagementId; }
            set { this._engagementId = value; }
        }

        // Check to see if EngagementId property is set
        internal bool IsSetEngagementId()
        {
            return this._engagementId != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementLastModifiedAt. 
        /// <para>
        /// The timestamp indicating when the engagement was last modified as a result of adding
        /// the context, in ISO 8601 format (UTC). Example: "2023-05-01T20:37:46Z".
        /// </para>
        /// </summary>
        public DateTime EngagementLastModifiedAt
        {
            get { return this._engagementLastModifiedAt.GetValueOrDefault(); }
            set { this._engagementLastModifiedAt = value; }
        }

        // Check to see if EngagementLastModifiedAt property is set
        internal bool IsSetEngagementLastModifiedAt()
        {
            return this._engagementLastModifiedAt.HasValue; 
        }

    }
}