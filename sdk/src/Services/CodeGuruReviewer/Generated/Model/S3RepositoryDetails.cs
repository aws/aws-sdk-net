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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
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
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Specifies the name of an S3 bucket and a <c>CodeArtifacts</c> object that contains
    /// the S3 object keys for a source code .zip file and for a build artifacts .zip file
    /// that contains .jar or .class files.
    /// </summary>
    public partial class S3RepositoryDetails
    {
        private string _bucketName;
        private CodeArtifacts _codeArtifacts;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket used for associating a new S3 repository. It must begin
        /// with <c>codeguru-reviewer-</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property CodeArtifacts. 
        /// <para>
        /// A <c>CodeArtifacts</c> object. The <c>CodeArtifacts</c> object includes the S3 object
        /// key for a source code .zip file and for a build artifacts .zip file that contains
        /// .jar or .class files.
        /// </para>
        /// </summary>
        public CodeArtifacts CodeArtifacts
        {
            get { return this._codeArtifacts; }
            set { this._codeArtifacts = value; }
        }

        // Check to see if CodeArtifacts property is set
        internal bool IsSetCodeArtifacts()
        {
            return this._codeArtifacts != null;
        }

    }
}