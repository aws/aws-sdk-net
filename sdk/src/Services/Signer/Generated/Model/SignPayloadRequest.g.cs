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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the SignPayload operation. Signs a binary payload
    /// and returns a signature envelope.
    /// </summary>
    public partial class SignPayloadRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Specifies the object digest (hash) to sign.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property PayloadFormat. 
        /// <para>
        /// Payload content type. The single valid type is <c>application/vnd.cncf.notary.payload.v1+json</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PayloadFormat { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFormat property is set.
        /// </summary>
        internal bool IsSetPayloadFormat() => this.PayloadFormat != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property ProfileOwner. 
        /// <para>
        /// The AWS account ID of the profile owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ProfileOwner { get; set; }

        /// <summary>
        /// Checks to see if the ProfileOwner property is set.
        /// </summary>
        internal bool IsSetProfileOwner() => this.ProfileOwner != null;
    }
}
