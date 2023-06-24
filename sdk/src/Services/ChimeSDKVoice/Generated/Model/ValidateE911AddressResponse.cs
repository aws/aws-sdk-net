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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the ValidateE911Address operation.
    /// </summary>
    public partial class ValidateE911AddressResponse : AmazonWebServiceResponse
    {
        private Address _address;
        private string _addressExternalId;
        private List<CandidateAddress> _candidateAddressList = new List<CandidateAddress>();
        private int? _validationResult;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The validated address.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AddressExternalId. 
        /// <para>
        /// The ID that represents the address.
        /// </para>
        /// </summary>
        public string AddressExternalId
        {
            get { return this._addressExternalId; }
            set { this._addressExternalId = value; }
        }

        // Check to see if AddressExternalId property is set
        internal bool IsSetAddressExternalId()
        {
            return this._addressExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateAddressList. 
        /// <para>
        /// The list of address suggestions..
        /// </para>
        /// </summary>
        public List<CandidateAddress> CandidateAddressList
        {
            get { return this._candidateAddressList; }
            set { this._candidateAddressList = value; }
        }

        // Check to see if CandidateAddressList property is set
        internal bool IsSetCandidateAddressList()
        {
            return this._candidateAddressList != null && this._candidateAddressList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationResult. 
        /// <para>
        /// Number indicating the result of address validation. <code>0</code> means the address
        /// was perfect as-is and successfully validated. <code>1</code> means the address was
        /// corrected. <code>2</code> means the address sent was not close enough and was not
        /// validated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int ValidationResult
        {
            get { return this._validationResult.GetValueOrDefault(); }
            set { this._validationResult = value; }
        }

        // Check to see if ValidationResult property is set
        internal bool IsSetValidationResult()
        {
            return this._validationResult.HasValue; 
        }

    }
}