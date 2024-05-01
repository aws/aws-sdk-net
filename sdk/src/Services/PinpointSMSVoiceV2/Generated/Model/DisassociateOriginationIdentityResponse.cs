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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DisassociateOriginationIdentity operation.
    /// </summary>
    public partial class DisassociateOriginationIdentityResponse : AmazonWebServiceResponse
    {
        private string _isoCountryCode;
        private string _originationIdentity;
        private string _originationIdentityArn;
        private string _poolArn;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string IsoCountryCode
        {
            get { return this._isoCountryCode; }
            set { this._isoCountryCode = value; }
        }

        // Check to see if IsoCountryCode property is set
        internal bool IsSetIsoCountryCode()
        {
            return this._isoCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The PhoneNumberId or SenderId of the origination identity.
        /// </para>
        /// </summary>
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentityArn. 
        /// <para>
        /// The PhoneNumberArn or SenderIdArn of the origination identity.
        /// </para>
        /// </summary>
        public string OriginationIdentityArn
        {
            get { return this._originationIdentityArn; }
            set { this._originationIdentityArn = value; }
        }

        // Check to see if OriginationIdentityArn property is set
        internal bool IsSetOriginationIdentityArn()
        {
            return this._originationIdentityArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pool.
        /// </para>
        /// </summary>
        public string PoolArn
        {
            get { return this._poolArn; }
            set { this._poolArn = value; }
        }

        // Check to see if PoolArn property is set
        internal bool IsSetPoolArn()
        {
            return this._poolArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The PoolId of the pool no longer associated with the origination identity.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}