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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateE911Address operation.
    /// Validates an address to be used for 911 calls made with Amazon Chime Voice Connectors.
    /// You can use validated addresses in a Presence Information Data Format Location Object
    /// file that you include in SIP requests. That helps ensure that addresses are routed
    /// to the appropriate Public Safety Answering Point.
    /// </summary>
    public partial class ValidateE911AddressRequest : AmazonChimeRequest
    {
        private string _awsAccountId;
        private string _city;
        private string _country;
        private string _postalCode;
        private string _state;
        private string _streetInfo;
        private string _streetNumber;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The address city, such as <code>Portland</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The address country, such as <code>US</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The address postal code, such as <code>04352</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The address state, such as <code>ME</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StreetInfo. 
        /// <para>
        /// The address street information, such as <code>8th Avenue</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string StreetInfo
        {
            get { return this._streetInfo; }
            set { this._streetInfo = value; }
        }

        // Check to see if StreetInfo property is set
        internal bool IsSetStreetInfo()
        {
            return this._streetInfo != null;
        }

        /// <summary>
        /// Gets and sets the property StreetNumber. 
        /// <para>
        /// The address street number, such as <code>200</code> or <code>2121</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string StreetNumber
        {
            get { return this._streetNumber; }
            set { this._streetNumber = value; }
        }

        // Check to see if StreetNumber property is set
        internal bool IsSetStreetNumber()
        {
            return this._streetNumber != null;
        }

    }
}