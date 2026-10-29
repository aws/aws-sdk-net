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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GenerateMac operation.
    /// </summary>
    public partial class GenerateMacResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The HMAC KMS key used in the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Mac. 
        /// <para>
        /// The hash-based message authentication code (HMAC) that was generated for the specified
        /// message, HMAC KMS key, and MAC algorithm.
        /// </para>
        ///  
        /// <para>
        /// This is the standard, raw HMAC defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC
        /// 2104</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6144)]
        public MemoryStream Mac { get; set; }

        /// <summary>
        /// Checks to see if the Mac property is set.
        /// </summary>
        internal bool IsSetMac() => this.Mac != null;

        /// <summary>
        /// Gets and sets the property MacAlgorithm. 
        /// <para>
        /// The MAC algorithm that was used to generate the HMAC.
        /// </para>
        /// </summary>
        public MacAlgorithmSpec MacAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the MacAlgorithm property is set.
        /// </summary>
        internal bool IsSetMacAlgorithm() => this.MacAlgorithm != null;
    }
}
