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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>.
    /// </summary>
    public partial class LayerVersionContentOutput
    {
        private string _codeSha256;
        private long? _codeSize;
        private string _location;
        private string _signingJobArn;
        private string _signingProfileVersionArn;

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// The SHA-256 hash of the layer archive.
        /// </para>
        /// </summary>
        public string CodeSha256
        {
            get { return this._codeSha256; }
            set { this._codeSha256 = value; }
        }

        // Check to see if CodeSha256 property is set
        internal bool IsSetCodeSha256()
        {
            return this._codeSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size of the layer archive in bytes.
        /// </para>
        /// </summary>
        public long? CodeSize
        {
            get { return this._codeSize; }
            set { this._codeSize = value; }
        }

        // Check to see if CodeSize property is set
        internal bool IsSetCodeSize()
        {
            return this._codeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A link to the layer archive in Amazon S3 that is valid for 10 minutes.
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
        /// Gets and sets the property SigningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a signing job.
        /// </para>
        /// </summary>
        public string SigningJobArn
        {
            get { return this._signingJobArn; }
            set { this._signingJobArn = value; }
        }

        // Check to see if SigningJobArn property is set
        internal bool IsSetSigningJobArn()
        {
            return this._signingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProfileVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a signing profile version.
        /// </para>
        /// </summary>
        public string SigningProfileVersionArn
        {
            get { return this._signingProfileVersionArn; }
            set { this._signingProfileVersionArn = value; }
        }

        // Check to see if SigningProfileVersionArn property is set
        internal bool IsSetSigningProfileVersionArn()
        {
            return this._signingProfileVersionArn != null;
        }

    }
}