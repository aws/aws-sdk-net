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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about the metadata for an Amazon ECR resource.
    /// </summary>
    public partial class ResourceScanMetadata
    {
        private Ec2Metadata _ec2;
        private EcrContainerImageMetadata _ecrImage;
        private EcrRepositoryMetadata _ecrRepository;
        private LambdaFunctionMetadata _lambdaFunction;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// An object that contains metadata details for an Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Metadata Ec2
        {
            get { return this._ec2; }
            set { this._ec2 = value; }
        }

        // Check to see if Ec2 property is set
        internal bool IsSetEc2()
        {
            return this._ec2 != null;
        }

        /// <summary>
        /// Gets and sets the property EcrImage. 
        /// <para>
        /// An object that contains details about the container metadata for an Amazon ECR image.
        /// </para>
        /// </summary>
        public EcrContainerImageMetadata EcrImage
        {
            get { return this._ecrImage; }
            set { this._ecrImage = value; }
        }

        // Check to see if EcrImage property is set
        internal bool IsSetEcrImage()
        {
            return this._ecrImage != null;
        }

        /// <summary>
        /// Gets and sets the property EcrRepository. 
        /// <para>
        /// An object that contains details about the repository an Amazon ECR image resides in.
        /// </para>
        /// </summary>
        public EcrRepositoryMetadata EcrRepository
        {
            get { return this._ecrRepository; }
            set { this._ecrRepository = value; }
        }

        // Check to see if EcrRepository property is set
        internal bool IsSetEcrRepository()
        {
            return this._ecrRepository != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// An object that contains metadata details for an AWS Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunctionMetadata LambdaFunction
        {
            get { return this._lambdaFunction; }
            set { this._lambdaFunction = value; }
        }

        // Check to see if LambdaFunction property is set
        internal bool IsSetLambdaFunction()
        {
            return this._lambdaFunction != null;
        }

    }
}