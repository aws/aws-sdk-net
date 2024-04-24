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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutImageScanningConfiguration operation.
    /// <important> 
    /// <para>
    /// The <c>PutImageScanningConfiguration</c> API is being deprecated, in favor of specifying
    /// the image scanning configuration at the registry level. For more information, see
    /// <a>PutRegistryScanningConfiguration</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Updates the image scanning configuration for the specified repository.
    /// </para>
    /// </summary>
    public partial class PutImageScanningConfigurationRequest : AmazonECRRequest
    {
        private ImageScanningConfiguration _imageScanningConfiguration;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// The image scanning configuration for the repository. This setting determines whether
        /// images are scanned for known vulnerabilities after being pushed to the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageScanningConfiguration ImageScanningConfiguration
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository in which to update the image scanning configuration setting. If you do
        /// not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository in which to update the image scanning configuration setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
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

    }
}