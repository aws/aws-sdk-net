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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The Amazon S3 location where artifacts are stored for the pipeline. If this Amazon
    /// S3 bucket is created manually, it must meet the requirements for AWS CodePipeline.
    /// For more information, see the <ulink url="http://docs.aws.amazon.com/codepipeline/latest/UserGuide/concepts.html">Concepts</ulink>.
    /// </summary>
    public partial class ArtifactStore
    {
        private EncryptionKey _encryptionKey;
        private string _location;
        private ArtifactStoreType _type;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key used to encrypt the data in the artifact
        /// store. If this is undefined, the default key for Amazon S3 is used.
        /// </para>
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location for storing the artifacts for a pipeline, such as an S3 bucket or folder.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the artifact store, such as S3.
        /// </para>
        /// </summary>
        public ArtifactStoreType Type
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