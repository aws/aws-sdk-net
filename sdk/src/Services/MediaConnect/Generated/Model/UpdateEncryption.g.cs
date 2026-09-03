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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Information about the encryption of the flow.
    /// </summary>
    public partial class UpdateEncryption
    {
        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        ///  The type of algorithm that is used for the encryption (such as aes128, aes192, or
        /// aes256).
        /// </para>
        /// </summary>
        public Algorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. 
        /// <para>
        ///  A 128-bit, 16-byte hex value represented by a 32-character string, to be used with
        /// the key for encrypting content. This parameter is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string ConstantInitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the ConstantInitializationVector property is set.
        /// </summary>
        internal bool IsSetConstantInitializationVector() => this.ConstantInitializationVector != null;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        ///  The value of one of the devices that you configured with your digital rights management
        /// (DRM) platform key provider. This parameter is required for SPEKE encryption and is
        /// not valid for static key encryption.
        /// </para>
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        ///  The type of key that is used for the encryption. If no keyType is provided, the service
        /// will use the default setting (static-key).
        /// </para>
        /// </summary>
        public KeyType KeyType { get; set; }

        /// <summary>
        /// Checks to see if the KeyType property is set.
        /// </summary>
        internal bool IsSetKeyType() => this.KeyType != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region that the API Gateway proxy endpoint was created in.
        /// This parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  An identifier for the content. The service sends this value to the key server to
        /// identify the current endpoint. The resource ID is also known as the content ID. This
        /// parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// 
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The ARN of the role that you created during setup (when you set up MediaConnect as
        /// a trusted entity).
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        ///  The ARN of the secret that you created in Secrets Manager to store the encryption
        /// key. This parameter is required for static key encryption and is not valid for SPEKE
        /// encryption.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        ///  The URL from the API Gateway proxy that you set up to talk to your key server. This
        /// parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
