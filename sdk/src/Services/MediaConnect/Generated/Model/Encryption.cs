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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    public partial class Encryption
    {
        private Algorithm _algorithm;
        private string _constantInitializationVector;
        private string _deviceId;
        private KeyType _keyType;
        private string _region;
        private string _resourceId;
        private string _roleArn;
        private string _secretArn;
        private string _url;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        ///  The type of algorithm that is used for the encryption (such as aes128, aes192, or
        /// aes256).
        /// </para>
        /// </summary>
        public Algorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. 
        /// <para>
        ///  A 128-bit, 16-byte hex value represented by a 32-character string, to be used with
        /// the key for encrypting content. This parameter is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string ConstantInitializationVector
        {
            get { return this._constantInitializationVector; }
            set { this._constantInitializationVector = value; }
        }

        // Check to see if ConstantInitializationVector property is set
        internal bool IsSetConstantInitializationVector()
        {
            return this._constantInitializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        ///  The value of one of the devices that you configured with your digital rights management
        /// (DRM) platform key provider. This parameter is required for SPEKE encryption and is
        /// not valid for static key encryption.
        /// </para>
        /// </summary>
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        ///  The type of key that is used for the encryption. If no keyType is provided, the service
        /// will use the default setting (static-key).
        /// </para>
        /// </summary>
        public KeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region that the API Gateway proxy endpoint was created in.
        /// This parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  An identifier for the content. The service sends this value to the key server to
        /// identify the current endpoint. The resource ID is also known as the content ID. This
        /// parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The ARN of the role that you created during setup (when you set up MediaConnect as
        /// a trusted entity).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        ///  The ARN of the secret that you created in Secrets Manager to store the encryption
        /// key. This parameter is required for static key encryption and is not valid for SPEKE
        /// encryption.
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        ///  The URL from the API Gateway proxy that you set up to talk to your key server. This
        /// parameter is required for SPEKE encryption and is not valid for static key encryption.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}