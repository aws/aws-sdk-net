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
    /// Container for the parameters to the UpdateImageStorageClass operation. Transitions
    /// an image between storage classes. You can transition images from Amazon ECR standard
    /// storage class to Amazon ECR archival storage class for long-term storage, or restore
    /// archived images back to Amazon ECR standard.
    /// </summary>
    public partial class UpdateImageStorageClassRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property ImageId.
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageIdentifier ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// image to transition. If you do not specify a registry, the default registry is assumed.
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
        /// The name of the repository that contains the image to transition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property TargetStorageClass. 
        /// <para>
        /// The target storage class for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetStorageClass TargetStorageClass { get; set; }

        /// <summary>
        /// Checks to see if the TargetStorageClass property is set.
        /// </summary>
        internal bool IsSetTargetStorageClass() => this.TargetStorageClass != null;
    }
}
