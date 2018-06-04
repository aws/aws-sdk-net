/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for CMAF encryption
    /// </summary>
    public partial class CmafEncryptionSettings
    {
        private string _constantInitializationVector;
        private CmafEncryptionType _encryptionMethod;
        private CmafInitializationVectorInManifest _initializationVectorInManifest;
        private StaticKeyProvider _staticKeyProvider;
        private CmafKeyProviderType _type;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. This is a 128-bit, 16-byte
        /// hex value represented by a 32-character text string. If this parameter is not set
        /// then the Initialization Vector will follow the segment number by default.
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
        /// Gets and sets the property EncryptionMethod.
        /// </summary>
        public CmafEncryptionType EncryptionMethod
        {
            get { return this._encryptionMethod; }
            set { this._encryptionMethod = value; }
        }

        // Check to see if EncryptionMethod property is set
        internal bool IsSetEncryptionMethod()
        {
            return this._encryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationVectorInManifest.
        /// </summary>
        public CmafInitializationVectorInManifest InitializationVectorInManifest
        {
            get { return this._initializationVectorInManifest; }
            set { this._initializationVectorInManifest = value; }
        }

        // Check to see if InitializationVectorInManifest property is set
        internal bool IsSetInitializationVectorInManifest()
        {
            return this._initializationVectorInManifest != null;
        }

        /// <summary>
        /// Gets and sets the property StaticKeyProvider.
        /// </summary>
        public StaticKeyProvider StaticKeyProvider
        {
            get { return this._staticKeyProvider; }
            set { this._staticKeyProvider = value; }
        }

        // Check to see if StaticKeyProvider property is set
        internal bool IsSetStaticKeyProvider()
        {
            return this._staticKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public CmafKeyProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}