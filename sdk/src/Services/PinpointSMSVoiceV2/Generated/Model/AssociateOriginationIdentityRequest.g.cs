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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateOriginationIdentity operation. Associates
    /// the specified origination identity with a pool. <para> If the origination identity
    /// is a phone number and is already associated with another pool, an error is returned.
    /// A sender ID can be associated with multiple pools. </para> <para> If the origination
    /// identity configuration doesn't match the pool's configuration, an error is returned.
    /// </para>
    /// </summary>
    public partial class AssociateOriginationIdentityRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don't specify a client token, a randomly generated token is used for
        /// the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The new two-character code, in ISO 3166-1 alpha-2 format, for the country or region
        /// of the origination identity. This field is optional and is not required for origination
        /// identity types that are not country-specific, such as RCS agents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use, such as PhoneNumberId, PhoneNumberArn, SenderId,
        /// or SenderIdArn. You can use <a>DescribePhoneNumbers</a> to find the values for PhoneNumberId
        /// and PhoneNumberArn, while <a>DescribeSenderIds</a> can be used to get the values for
        /// SenderId and SenderIdArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The pool to update with the new Identity. This value can be either the PoolId or PoolArn,
        /// and you can find these values using <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference_smsvoicev2/API_DescribePools.html">DescribePools</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS; resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;
    }
}
