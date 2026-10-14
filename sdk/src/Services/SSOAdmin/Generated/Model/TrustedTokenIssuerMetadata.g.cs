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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes a trusted token issuer.
    /// </summary>
    public partial class TrustedTokenIssuerMetadata
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trusted token issuer configuration in the instance of IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerArn. 
        /// <para>
        /// The ARN of the trusted token issuer configuration in the instance of IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string TrustedTokenIssuerArn { get; set; }

        /// <summary>
        /// Checks to see if the TrustedTokenIssuerArn property is set.
        /// </summary>
        internal bool IsSetTrustedTokenIssuerArn() => this.TrustedTokenIssuerArn != null;

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerType. 
        /// <para>
        /// The type of trusted token issuer.
        /// </para>
        /// </summary>
        public TrustedTokenIssuerType TrustedTokenIssuerType { get; set; }

        /// <summary>
        /// Checks to see if the TrustedTokenIssuerType property is set.
        /// </summary>
        internal bool IsSetTrustedTokenIssuerType() => this.TrustedTokenIssuerType != null;
    }
}
