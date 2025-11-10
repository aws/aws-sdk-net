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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// This is the response object from the GetDelegatedAccessToken operation.
    /// </summary>
    public partial class GetDelegatedAccessTokenResponse : AmazonWebServiceResponse
    {
        private string _assumedPrincipal;
        private Credentials _credentials;
        private int? _packedPolicySize;

        /// <summary>
        /// Gets and sets the property AssumedPrincipal.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AssumedPrincipal
        {
            get { return this._assumedPrincipal; }
            set { this._assumedPrincipal = value; }
        }

        // Check to see if AssumedPrincipal property is set
        internal bool IsSetAssumedPrincipal()
        {
            return this._assumedPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials.
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property PackedPolicySize.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PackedPolicySize
        {
            get { return this._packedPolicySize; }
            set { this._packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }

    }
}