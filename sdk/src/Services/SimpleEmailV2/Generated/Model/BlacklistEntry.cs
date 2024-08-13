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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about a blacklisting event that impacts one of
    /// the dedicated IP addresses that is associated with your account.
    /// </summary>
    public partial class BlacklistEntry
    {
        private string _description;
        private DateTime? _listingTime;
        private string _rblName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Additional information about the blacklisting event, as provided by the blacklist
        /// maintainer.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ListingTime. 
        /// <para>
        /// The time when the blacklisting event occurred.
        /// </para>
        /// </summary>
        public DateTime? ListingTime
        {
            get { return this._listingTime; }
            set { this._listingTime = value; }
        }

        // Check to see if ListingTime property is set
        internal bool IsSetListingTime()
        {
            return this._listingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RblName. 
        /// <para>
        /// The name of the blacklist that the IP address appears on.
        /// </para>
        /// </summary>
        public string RblName
        {
            get { return this._rblName; }
            set { this._rblName = value; }
        }

        // Check to see if RblName property is set
        internal bool IsSetRblName()
        {
            return this._rblName != null;
        }

    }
}