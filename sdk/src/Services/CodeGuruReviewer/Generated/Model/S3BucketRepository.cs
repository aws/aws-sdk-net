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
    /// Information about an associated repository in an S3 bucket. The associated repository
    /// contains a source code .zip file and a build artifacts .zip file that contains .jar
    /// or .class files.
    /// </summary>
    public partial class S3BucketRepository
    {
        private S3RepositoryDetails _details;
        private string _name;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// An <c>S3RepositoryDetails</c> object that specifies the name of an S3 bucket and a
        /// <c>CodeArtifacts</c> object. The <c>CodeArtifacts</c> object includes the S3 object
        /// keys for a source code .zip file and for a build artifacts .zip file.
        /// </para>
        /// </summary>
        public S3RepositoryDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the repository when the <c>ProviderType</c> is <c>S3Bucket</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}