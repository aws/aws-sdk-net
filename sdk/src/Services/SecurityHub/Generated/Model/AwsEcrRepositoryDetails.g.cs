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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about an Amazon Elastic Container Registry repository.
    /// </summary>
    public partial class AwsEcrRepositoryDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the repository.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// The image scanning configuration for a repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryImageScanningConfigurationDetails ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. Valid values are <c>IMMUTABLE</c> or
        /// <c>MUTABLE</c>.
        /// </para>
        /// </summary>
        public string ImageTagMutability { get; set; }

        /// <summary>
        /// Checks to see if the ImageTagMutability property is set.
        /// </summary>
        internal bool IsSetImageTagMutability() => this.ImageTagMutability != null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// Information about the lifecycle policy for the repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryLifecyclePolicyDetails LifecyclePolicy { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicy property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicy() => this.LifecyclePolicy != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryPolicyText. 
        /// <para>
        /// The text of the repository policy.
        /// </para>
        /// </summary>
        public string RepositoryPolicyText { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryPolicyText property is set.
        /// </summary>
        internal bool IsSetRepositoryPolicyText() => this.RepositoryPolicyText != null;
    }
}
