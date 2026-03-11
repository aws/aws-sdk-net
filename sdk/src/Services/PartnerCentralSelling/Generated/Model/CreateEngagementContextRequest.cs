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
    /// Container for the parameters to the CreateEngagementContext operation.
    /// Creates a new context within an existing engagement. This action allows you to add
    /// contextual information such as customer projects or documents to an engagement, providing
    /// additional details that help facilitate collaboration between engagement members.
    /// </summary>
    public partial class CreateEngagementContextRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _clientToken;
        private string _engagementIdentifier;
        private EngagementContextPayload _payload;
        private EngagementContextType _type;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the engagement context request. This field takes
        /// a string value from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines
        /// which environment the engagement context is created in. Use <c>AWS</c> to create contexts
        /// in the production environment, and <c>Sandbox</c> for testing in secure, isolated
        /// environments.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier provided by the client to ensure that the request
        /// is handled exactly once. This token helps prevent duplicate context creations and
        /// must not exceed sixty-four alphanumeric characters. Use a UUID or other unique string
        /// to ensure idempotency.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the <c>Engagement</c> for which the context is being created.
        /// This parameter ensures the context is associated with the correct engagement and provides
        /// the necessary linkage between the engagement and its contextual information.
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
        /// Gets and sets the property Payload.
        /// </summary>
        [AWSProperty(Required=true)]
        public EngagementContextPayload Payload
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
        /// Specifies the type of context being created for the engagement. This field determines
        /// the structure and content of the context payload. Valid values include <c>CustomerProject</c>
        /// for customer project-related contexts. The type field ensures that the context is
        /// properly categorized and processed according to its intended purpose.
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