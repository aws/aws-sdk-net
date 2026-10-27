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
    /// This is the response object from the PutImageTagMutability operation.
    /// </summary>
    public partial class PutImageTagMutabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageTagMutability. 
        /// <para>
        /// The image tag mutability setting for the repository.
        /// </para>
        /// </summary>
        public ImageTagMutability ImageTagMutability { get; set; }

        /// <summary>
        /// Checks to see if the ImageTagMutability property is set.
        /// </summary>
        internal bool IsSetImageTagMutability() => this.ImageTagMutability != null;

        /// <summary>
        /// Gets and sets the property ImageTagMutabilityExclusionFilters. 
        /// <para>
        /// The list of filters that specify which image tags are excluded from the repository's
        /// image tag mutability setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<ImageTagMutabilityExclusionFilter> ImageTagMutabilityExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageTagMutabilityExclusionFilter>() : null;

        /// <summary>
        /// Checks to see if the ImageTagMutabilityExclusionFilters property is set.
        /// </summary>
        internal bool IsSetImageTagMutabilityExclusionFilters() => this.ImageTagMutabilityExclusionFilters != null && (this.ImageTagMutabilityExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
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
        /// The repository name associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
