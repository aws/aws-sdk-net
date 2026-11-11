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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstanceTpmEkPub operation. Gets the public
    /// endorsement key associated with the Nitro Trusted Platform Module (NitroTPM) for the
    /// specified instance.
    /// </summary>
    public partial class GetInstanceTpmEkPubRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specify this parameter to verify whether the request will succeed, without actually
        /// making the request. If the request will succeed, the response is <c>DryRunOperation</c>.
        /// Otherwise, the response is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance for which to get the public endorsement key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property KeyFormat. 
        /// <para>
        /// The required public endorsement key format. Specify <c>der</c> for a DER-encoded public
        /// key that is compatible with OpenSSL. Specify <c>tpmt</c> for a TPM 2.0 format that
        /// is compatible with tpm2-tools. The returned key is base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EkPubKeyFormat KeyFormat { get; set; }

        /// <summary>
        /// Checks to see if the KeyFormat property is set.
        /// </summary>
        internal bool IsSetKeyFormat() => this.KeyFormat != null;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The required public endorsement key type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EkPubKeyType KeyType { get; set; }

        /// <summary>
        /// Checks to see if the KeyType property is set.
        /// </summary>
        internal bool IsSetKeyType() => this.KeyType != null;
    }
}
