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
    /// Container for the parameters to the UpdateEngagementContext operation.
    /// Updates the context information for an existing engagement with new or modified data.
    /// </summary>
    public partial class UpdateEngagementContextRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _contextIdentifier;
        private string _engagementIdentifier;
        private DateTime? _engagementLastModifiedAt;
        private UpdateEngagementContextPayload _payload;
        private EngagementContextType _type;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the engagement context update request. This
        /// field takes a string value from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The
        /// catalog determines which environment the engagement context is updated in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ContextIdentifier. 
        /// <para>
        /// The unique identifier of the specific engagement context to be updated. This ensures
        /// that the correct context within the engagement is modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContextIdentifier
        {
            get { return this._contextIdentifier; }
            set { this._contextIdentifier = value; }
        }

        // Check to see if ContextIdentifier property is set
        internal bool IsSetContextIdentifier()
        {
            return this._contextIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the <c>Engagement</c> containing the context to be updated.
        /// This parameter ensures the context update is applied to the correct engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngagementIdentifier
        {
            get { return this._engagementIdentifier; }
            set { this._engagementIdentifier = value; }
        }

        // Check to see if EngagementIdentifier property is set
        internal bool IsSetEngagementIdentifier()
        {
            return this._engagementIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementLastModifiedAt. 
        /// <para>
        /// The timestamp when the engagement was last modified, used for optimistic concurrency
        /// control. This helps prevent conflicts when multiple users attempt to update the same
        /// engagement simultaneously.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EngagementLastModifiedAt
        {
            get { return this._engagementLastModifiedAt; }
            set { this._engagementLastModifiedAt = value; }
        }

        // Check to see if EngagementLastModifiedAt property is set
        internal bool IsSetEngagementLastModifiedAt()
        {
            return this._engagementLastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Contains the updated contextual information for the engagement. The structure of this
        /// payload varies based on the context type specified in the Type field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateEngagementContextPayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of context being updated within the engagement. This field determines
        /// the structure and content of the context payload being modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngagementContextType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}