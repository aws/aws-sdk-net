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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the VerifyMac operation.
    /// </summary>
    public partial class VerifyMacResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private MacAlgorithmSpec _macAlgorithm;
        private bool? _macValid;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The HMAC KMS key used in the verification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm used in the verification.
        /// </para>
        /// </summary>
        public MacAlgorithmSpec MacAlgorithm
        {
            get { return this._macAlgorithm; }
            set { this._macAlgorithm = value; }
        }

        // Check to see if MacAlgorithm property is set
        internal bool IsSetMacAlgorithm()
        {
            return this._macAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property MacValid. 
        /// <para>
        /// A Boolean value that indicates whether the HMAC was verified. A value of <c>True</c>
        /// indicates that the HMAC (<c>Mac</c>) was generated with the specified <c>Message</c>,
        /// HMAC KMS key (<c>KeyID</c>) and <c>MacAlgorithm.</c>.
        /// </para>
        ///  
        /// <para>
        /// If the HMAC is not verified, the <c>VerifyMac</c> operation fails with a <c>KMSInvalidMacException</c>
        /// exception. This exception indicates that one or more of the inputs changed since the
        /// HMAC was computed.
        /// </para>
        /// </summary>
        public bool? MacValid
        {
            get { return this._macValid; }
            set { this._macValid = value; }
        }

        // Check to see if MacValid property is set
        internal bool IsSetMacValid()
        {
            return this._macValid.HasValue; 
        }

    }
}