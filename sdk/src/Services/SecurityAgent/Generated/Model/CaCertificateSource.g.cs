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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The source of a trusted CA certificate. Exactly one member must be set.
    /// </summary>
    public partial class CaCertificateSource
    {
        /// <summary>
        /// Gets and sets the property ArtifactId. 
        /// <para>
        /// The artifact ID of an uploaded certificate file.
        /// </para>
        /// </summary>
        public string ArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactId property is set.
        /// </summary>
        internal bool IsSetArtifactId() => this.ArtifactId != null;

        /// <summary>
        /// Gets and sets the property InlinePem. 
        /// <para>
        /// A PEM-encoded X.509 certificate supplied inline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8192)]
        public string InlinePem { get; set; }

        /// <summary>
        /// Checks to see if the InlinePem property is set.
        /// </summary>
        internal bool IsSetInlinePem() => this.InlinePem != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The Amazon S3 location URI of a customer-staged certificate.
        /// </para>
        /// </summary>
        public string S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;
    }
}
