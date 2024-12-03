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
    /// Details about a function's deployment package.
    /// </summary>
    public partial class FunctionCodeLocation
    {
        private string _imageUri;
        private string _location;
        private string _repositoryType;
        private string _resolvedImageUri;
        private string _sourceKMSKeyArn;

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// URI of a container image in the Amazon ECR registry.
        /// </para>
        /// </summary>
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A presigned URL that you can use to download the deployment package.
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
        /// Gets and sets the property RepositoryType. 
        /// <para>
        /// The service that's hosting the file.
        /// </para>
        /// </summary>
        public string RepositoryType
        {
            get { return this._repositoryType; }
            set { this._repositoryType = value; }
        }

        // Check to see if RepositoryType property is set
        internal bool IsSetRepositoryType()
        {
            return this._repositoryType != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedImageUri. 
        /// <para>
        /// The resolved URI for the image.
        /// </para>
        /// </summary>
        public string ResolvedImageUri
        {
            get { return this._resolvedImageUri; }
            set { this._resolvedImageUri = value; }
        }

        // Check to see if ResolvedImageUri property is set
        internal bool IsSetResolvedImageUri()
        {
            return this._resolvedImageUri != null;
        }

        /// <summary>
        /// Gets and sets the property SourceKMSKeyArn. 
        /// <para>
        /// The ARN of the Key Management Service (KMS) customer managed key that's used to encrypt
        /// your function's .zip deployment package. If you don't provide a customer managed key,
        /// Lambda uses an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
        /// Web Services owned key</a>.
        /// </para>
        /// </summary>
        public string SourceKMSKeyArn
        {
            get { return this._sourceKMSKeyArn; }
            set { this._sourceKMSKeyArn = value; }
        }

        // Check to see if SourceKMSKeyArn property is set
        internal bool IsSetSourceKMSKeyArn()
        {
            return this._sourceKMSKeyArn != null;
        }

    }
}