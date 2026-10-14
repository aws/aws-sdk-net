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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePartnerAppPresignedUrl operation. Creates
    /// a presigned URL to access an Amazon SageMaker Partner AI App.
    /// </summary>
    public partial class CreatePartnerAppPresignedUrlRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SageMaker Partner AI App to create the presigned URL for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// The time that will pass before the presigned URL expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 300)]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresInSeconds property is set.
        /// </summary>
        internal bool IsSetExpiresInSeconds() => this.ExpiresInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// Indicates how long the Amazon SageMaker Partner AI App session can be accessed for
        /// after logging in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1800, Max = 43200)]
        public int? SessionExpirationDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpirationDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetSessionExpirationDurationInSeconds() => this.SessionExpirationDurationInSeconds.HasValue;
    }
}
