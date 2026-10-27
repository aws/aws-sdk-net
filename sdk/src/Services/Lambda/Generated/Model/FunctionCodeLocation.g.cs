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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about a function's deployment package.
    /// </summary>
    public partial class FunctionCodeLocation
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An object that contains details about an error related to function deployment package
        /// retrieval.
        /// </para>
        /// </summary>
        public FunctionCodeLocationError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// URI of a container image in the Amazon ECR registry.
        /// </para>
        /// </summary>
        public string ImageUri { get; set; }

        /// <summary>
        /// Checks to see if the ImageUri property is set.
        /// </summary>
        internal bool IsSetImageUri() => this.ImageUri != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A presigned URL that you can use to download the deployment package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property RepositoryType. 
        /// <para>
        /// The service that's hosting the file.
        /// </para>
        /// </summary>
        public string RepositoryType { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryType property is set.
        /// </summary>
        internal bool IsSetRepositoryType() => this.RepositoryType != null;

        /// <summary>
        /// Gets and sets the property ResolvedImageUri. 
        /// <para>
        /// The resolved URI for the image.
        /// </para>
        /// </summary>
        public string ResolvedImageUri { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedImageUri property is set.
        /// </summary>
        internal bool IsSetResolvedImageUri() => this.ResolvedImageUri != null;

        /// <summary>
        /// Gets and sets the property ResolvedS3Object. 
        /// <para>
        /// The resolved Amazon S3 object that contains the deployment package.
        /// </para>
        /// </summary>
        public ResolvedS3Object ResolvedS3Object { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedS3Object property is set.
        /// </summary>
        internal bool IsSetResolvedS3Object() => this.ResolvedS3Object != null;

        /// <summary>
        /// Gets and sets the property SourceKMSKeyArn. 
        /// <para>
        /// The ARN of the Key Management Service (KMS) customer managed key that's used to encrypt
        /// your function's .zip deployment package. If you don't provide a customer managed key,
        /// Lambda uses an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
        /// Web Services owned key</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SourceKMSKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceKMSKeyArn property is set.
        /// </summary>
        internal bool IsSetSourceKMSKeyArn() => this.SourceKMSKeyArn != null;
    }
}
