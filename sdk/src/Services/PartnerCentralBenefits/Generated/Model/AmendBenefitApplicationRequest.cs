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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the AmendBenefitApplication operation.
    /// Modifies an existing benefit application by applying amendments to specific fields
    /// while maintaining revision control.
    /// </summary>
    public partial class AmendBenefitApplicationRequest : AmazonPartnerCentralBenefitsRequest
    {
        private string _amendmentReason;
        private List<Amendment> _amendments = AWSConfigs.InitializeCollections ? new List<Amendment>() : null;
        private string _catalog;
        private string _clientToken;
        private string _identifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property AmendmentReason. 
        /// <para>
        /// A descriptive reason explaining why the benefit application is being amended.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string AmendmentReason
        {
            get { return this._amendmentReason; }
            set { this._amendmentReason = value; }
        }

        // Check to see if AmendmentReason property is set
        internal bool IsSetAmendmentReason()
        {
            return this._amendmentReason != null;
        }

        /// <summary>
        /// Gets and sets the property Amendments. 
        /// <para>
        /// A list of specific field amendments to apply to the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Amendment> Amendments
        {
            get { return this._amendments; }
            set { this._amendments = value; }
        }

        // Check to see if Amendments property is set
        internal bool IsSetAmendments()
        {
            return this._amendments != null && (this._amendments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog the application belongs
        /// to.
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
        /// A unique, case-sensitive identifier to ensure idempotent processing of the amendment
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the benefit application to be amended.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the benefit application to ensure optimistic concurrency
        /// control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}