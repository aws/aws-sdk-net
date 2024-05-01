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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of an asset published in an Amazon DataZone catalog.
    /// </summary>
    public partial class AssetListingDetails
    {
        private string _listingId;
        private ListingStatus _listingStatus;

        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// The identifier of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ListingId
        {
            get { return this._listingId; }
            set { this._listingId = value; }
        }

        // Check to see if ListingId property is set
        internal bool IsSetListingId()
        {
            return this._listingId != null;
        }

        /// <summary>
        /// Gets and sets the property ListingStatus. 
        /// <para>
        /// The status of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListingStatus ListingStatus
        {
            get { return this._listingStatus; }
            set { this._listingStatus = value; }
        }

        // Check to see if ListingStatus property is set
        internal bool IsSetListingStatus()
        {
            return this._listingStatus != null;
        }

    }
}