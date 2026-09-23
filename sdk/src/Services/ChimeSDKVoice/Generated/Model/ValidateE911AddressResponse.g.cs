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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the ValidateE911Address operation.
    /// </summary>
    public partial class ValidateE911AddressResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The validated address.
        /// </para>
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AddressExternalId. 
        /// <para>
        /// The ID that represents the address.
        /// </para>
        /// </summary>
        public string AddressExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AddressExternalId property is set.
        /// </summary>
        internal bool IsSetAddressExternalId() => this.AddressExternalId != null;

        /// <summary>
        /// Gets and sets the property CandidateAddressList. 
        /// <para>
        /// The list of address suggestions..
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CandidateAddress> CandidateAddressList { get; set; } = AWSConfigs.InitializeCollections ? new List<CandidateAddress>() : null;

        /// <summary>
        /// Checks to see if the CandidateAddressList property is set.
        /// </summary>
        internal bool IsSetCandidateAddressList() => this.CandidateAddressList != null && (this.CandidateAddressList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 2)]
        public int? ValidationResult { get; set; }

        /// <summary>
        /// Checks to see if the ValidationResult property is set.
        /// </summary>
        internal bool IsSetValidationResult() => this.ValidationResult.HasValue;
    }
}
