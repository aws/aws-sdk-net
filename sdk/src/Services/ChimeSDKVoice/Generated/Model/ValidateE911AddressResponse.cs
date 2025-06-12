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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the ValidateE911Address operation.
    /// </summary>
    public partial class ValidateE911AddressResponse : AmazonWebServiceResponse
    {
        private Address _address;
        private string _addressExternalId;
        private List<CandidateAddress> _candidateAddressList = AWSConfigs.InitializeCollections ? new List<CandidateAddress>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CandidateAddress> CandidateAddressList
        {
            get { return this._candidateAddressList; }
            set { this._candidateAddressList = value; }
        }

        // Check to see if CandidateAddressList property is set
        internal bool IsSetCandidateAddressList()
        {
            return this._candidateAddressList != null && (this._candidateAddressList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationResult. 
        /// <para>
        /// Number indicating the result of address validation.
        /// </para>
        ///  
        /// <para>
        /// Each possible result is defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0</c> - Address validation succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1</c> - Address validation succeeded. The address was a close enough match and
        /// has been corrected as part of the address object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2</c> - Address validation failed. You should re-submit the validation request
        /// with candidates from the <c>CandidateAddressList</c> result, if it's a close match.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int? ValidationResult
        {
            get { return this._validationResult; }
            set { this._validationResult = value; }
        }

        // Check to see if ValidationResult property is set
        internal bool IsSetValidationResult()
        {
            return this._validationResult.HasValue; 
        }

    }
}