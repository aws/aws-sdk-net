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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCheckLayerAvailability operation. Checks
    /// the availability of one or more image layers in a repository. <para> When an image
    /// is pushed to a repository, each image layer is checked to verify if it has been uploaded
    /// before. If it has been uploaded, then the image layer is skipped. </para> <note> <para>
    /// This operation is used by the Amazon ECR proxy and is not generally used by customers
    /// for pulling and pushing images. In most cases, you should use the <c>docker</c> CLI
    /// to pull, tag, and push images. </para> </note>
    /// </summary>
    public partial class BatchCheckLayerAvailabilityRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property LayerDigests. 
        /// <para>
        /// The digests of the image layers to check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> LayerDigests { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LayerDigests property is set.
        /// </summary>
        internal bool IsSetLayerDigests() => this.LayerDigests != null && (this.LayerDigests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// image layers to check. If you do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that is associated with the image layers to check.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
