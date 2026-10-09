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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Contains an array of Amazon Web Services resource objects. Each object represents
    /// an Amazon S3 bucket, an Lambda function, or an Amazon Machine Image (AMI) based on
    /// Amazon EC2 that is associated with a particular job.
    /// </summary>
    public partial class JobResource
    {
        /// <summary>
        /// Gets and sets the property Ec2AmiResources. 
        /// <para>
        /// The Amazon Machine Images (AMIs) associated with this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ec2AmiResource> Ec2AmiResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Ec2AmiResource>() : null;

        /// <summary>
        /// Checks to see if the Ec2AmiResources property is set.
        /// </summary>
        internal bool IsSetEc2AmiResources() => this.Ec2AmiResources != null && (this.Ec2AmiResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LambdaResources. 
        /// <para>
        /// The Python-language Lambda functions for this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LambdaResource> LambdaResources { get; set; } = AWSConfigs.InitializeCollections ? new List<LambdaResource>() : null;

        /// <summary>
        /// Checks to see if the LambdaResources property is set.
        /// </summary>
        internal bool IsSetLambdaResources() => this.LambdaResources != null && (this.LambdaResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Resources. 
        /// <para>
        /// An array of <c>S3Resource</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Resource> S3Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Resource>() : null;

        /// <summary>
        /// Checks to see if the S3Resources property is set.
        /// </summary>
        internal bool IsSetS3Resources() => this.S3Resources != null && (this.S3Resources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
