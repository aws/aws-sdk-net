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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The S3 bucket where artifacts for the pipeline are stored.
    /// 
    ///  <note> 
    /// <para>
    /// You must include either <c>artifactStore</c> or <c>artifactStores</c> in your pipeline,
    /// but you cannot use both. If you create a cross-region action in your pipeline, you
    /// must use <c>artifactStores</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ArtifactStore
    {
        private EncryptionKey _encryptionKey;
        private string _location;
        private ArtifactStoreType _type;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The encryption key used to encrypt the data in the artifact store, such as an Amazon
        /// Web Services Key Management Service key. If this is undefined, the default key for
        /// Amazon S3 is used.
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
        /// The S3 bucket used for storing the artifacts for a pipeline. You can specify the name
        /// of an S3 bucket but not a folder in the bucket. A folder to contain the pipeline artifacts
        /// is created for you based on the name of the pipeline. You can use any S3 bucket in
        /// the same Amazon Web Services Region as the pipeline to store your pipeline artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        [AWSProperty(Required=true)]
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