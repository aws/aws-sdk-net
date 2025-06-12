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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// A list of phone numbers and their metadata.
    /// </summary>
    public partial class PhoneNumberInformation
    {
        private DateTime? _createdAt;
        private string _iso2CountryCode;
        private List<string> _numberCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _phoneNumber;
        private RouteType _routeType;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the phone number was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iso2CountryCode. 
        /// <para>
        /// The two-character code for the country or region, in ISO 3166-1 alpha-2 format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public string Iso2CountryCode
        {
            get { return this._iso2CountryCode; }
            set { this._iso2CountryCode = value; }
        }

        // Check to see if Iso2CountryCode property is set
        internal bool IsSetIso2CountryCode()
        {
            return this._iso2CountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// The capabilities of each phone number.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NumberCapabilities
        {
            get { return this._numberCapabilities; }
            set { this._numberCapabilities = value; }
        }

        // Check to see if NumberCapabilities property is set
        internal bool IsSetNumberCapabilities()
        {
            return this._numberCapabilities != null && (this._numberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The list of supported routes.
        /// </para>
        /// </summary>
        public RouteType RouteType
        {
            get { return this._routeType; }
            set { this._routeType = value; }
        }

        // Check to see if RouteType property is set
        internal bool IsSetRouteType()
        {
            return this._routeType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the phone number.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}