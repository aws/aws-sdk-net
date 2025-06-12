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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// A list of potential contact methods for the result/place.
    /// </summary>
    public partial class Contacts
    {
        private List<ContactDetails> _emails = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;
        private List<ContactDetails> _faxes = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;
        private List<ContactDetails> _phones = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;
        private List<ContactDetails> _websites = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;

        /// <summary>
        /// Gets and sets the property Emails. 
        /// <para>
        /// List of emails for contacts of the result. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ContactDetails> Emails
        {
            get { return this._emails; }
            set { this._emails = value; }
        }

        // Check to see if Emails property is set
        internal bool IsSetEmails()
        {
            return this._emails != null && (this._emails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Faxes. 
        /// <para>
        /// List of fax addresses for the result contact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ContactDetails> Faxes
        {
            get { return this._faxes; }
            set { this._faxes = value; }
        }

        // Check to see if Faxes property is set
        internal bool IsSetFaxes()
        {
            return this._faxes != null && (this._faxes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phones. 
        /// <para>
        /// List of phone numbers for the results contact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ContactDetails> Phones
        {
            get { return this._phones; }
            set { this._phones = value; }
        }

        // Check to see if Phones property is set
        internal bool IsSetPhones()
        {
            return this._phones != null && (this._phones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Websites. 
        /// <para>
        /// List of website URLs that belong to the result. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ContactDetails> Websites
        {
            get { return this._websites; }
            set { this._websites = value; }
        }

        // Check to see if Websites property is set
        internal bool IsSetWebsites()
        {
            return this._websites != null && (this._websites.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}