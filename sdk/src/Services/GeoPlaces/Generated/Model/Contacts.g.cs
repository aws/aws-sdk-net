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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Emails. 
        /// <para>
        /// List of emails for contacts of the result. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ContactDetails> Emails { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;

        /// <summary>
        /// Checks to see if the Emails property is set.
        /// </summary>
        internal bool IsSetEmails() => this.Emails != null && (this.Emails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Faxes. 
        /// <para>
        /// List of fax addresses for the result contact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ContactDetails> Faxes { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;

        /// <summary>
        /// Checks to see if the Faxes property is set.
        /// </summary>
        internal bool IsSetFaxes() => this.Faxes != null && (this.Faxes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phones. 
        /// <para>
        /// List of phone numbers for the results contact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ContactDetails> Phones { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;

        /// <summary>
        /// Checks to see if the Phones property is set.
        /// </summary>
        internal bool IsSetPhones() => this.Phones != null && (this.Phones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Websites. 
        /// <para>
        /// List of website URLs that belong to the result. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ContactDetails> Websites { get; set; } = AWSConfigs.InitializeCollections ? new List<ContactDetails>() : null;

        /// <summary>
        /// Checks to see if the Websites property is set.
        /// </summary>
        internal bool IsSetWebsites() => this.Websites != null && (this.Websites.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
