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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _arn;
        private AwsEcrRepositoryImageScanningConfigurationDetails _imageScanningConfiguration;
        private string _imageTagMutability;
        private AwsEcrRepositoryLifecyclePolicyDetails _lifecyclePolicy;
        private string _repositoryName;
        private string _repositoryPolicyText;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the repository.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// The image scanning configuration for a repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryImageScanningConfigurationDetails ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The tag mutability setting for the repository. Valid values are <c>IMMUTABLE</c> or
        /// <c>MUTABLE</c>.
        /// </para>
        /// </summary>
        public string ImageTagMutability
        {
            get { return this._imageTagMutability; }
            set { this._imageTagMutability = value; }
        }

        // Check to see if ImageTagMutability property is set
        internal bool IsSetImageTagMutability()
        {
            return this._imageTagMutability != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// Information about the lifecycle policy for the repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryLifecyclePolicyDetails LifecyclePolicy
        {
            get { return this._lifecyclePolicy; }
            set { this._lifecyclePolicy = value; }
        }

        // Check to see if LifecyclePolicy property is set
        internal bool IsSetLifecyclePolicy()
        {
            return this._lifecyclePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryPolicyText. 
        /// <para>
        /// The text of the repository policy.
        /// </para>
        /// </summary>
        public string RepositoryPolicyText
        {
            get { return this._repositoryPolicyText; }
            set { this._repositoryPolicyText = value; }
        }

        // Check to see if RepositoryPolicyText property is set
        internal bool IsSetRepositoryPolicyText()
        {
            return this._repositoryPolicyText != null;
        }

    }
}