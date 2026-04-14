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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// An engagement option available to potential buyers of a product, such as requesting
    /// a private offer or a demo.
    /// </summary>
    public partial class SellerEngagement
    {
        private SellerEngagementContentType _contentType;
        private SellerEngagementType _engagementType;
        private string _value;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The format of the engagement value, such as a URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SellerEngagementContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementType. 
        /// <para>
        /// The type of engagement, such as <c>REQUEST_FOR_PRIVATE_OFFER</c> or <c>REQUEST_FOR_DEMO</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SellerEngagementType EngagementType
        {
            get { return this._engagementType; }
            set { this._engagementType = value; }
        }

        // Check to see if EngagementType property is set
        internal bool IsSetEngagementType()
        {
            return this._engagementType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The engagement value, such as a URL to the engagement form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}