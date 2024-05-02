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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSiteAddress operation.
    /// Updates the address of the specified site.
    /// 
    ///  
    /// <para>
    /// You can't update a site address if there is an order in progress. You must wait for
    /// the order to complete or cancel the order.
    /// </para>
    ///  
    /// <para>
    /// You can update the operating address before you place an order at the site, or after
    /// all Outposts that belong to the site have been deactivated.
    /// </para>
    /// </summary>
    public partial class UpdateSiteAddressRequest : AmazonOutpostsRequest
    {
        private Address _address;
        private AddressType _addressType;
        private string _siteId;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        ///  The address for the site. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property AddressType. 
        /// <para>
        ///  The type of the address. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AddressType AddressType
        {
            get { return this._addressType; }
            set { this._addressType = value; }
        }

        // Check to see if AddressType property is set
        internal bool IsSetAddressType()
        {
            return this._addressType != null;
        }

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the site. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

    }
}