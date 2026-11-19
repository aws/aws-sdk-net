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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Configuration information about a public key that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">signed
    /// URLs and signed cookies</a>, or with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/field-level-encryption.html">field-level
    /// encryption</a>.
    /// 
    ///  
    /// <para>
    /// CloudFront supports signed URLs and signed cookies with RSA 2048 or ECDSA 256 key
    /// signatures. Field-level encryption is only compatible with RSA 2048 key signatures.
    /// </para>
    /// </summary>
    public partial class PublicKeyConfig
    {
        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A string included in the request to help make sure that the request can't be replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment to describe the public key. The comment cannot be longer than 128 characters.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property EncodedKey. 
        /// <para>
        /// The public key that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">signed
        /// URLs and signed cookies</a>, or with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/field-level-encryption.html">field-level
        /// encryption</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EncodedKey { get; set; }

        /// <summary>
        /// Checks to see if the EncodedKey property is set.
        /// </summary>
        internal bool IsSetEncodedKey() => this.EncodedKey != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to help identify the public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
