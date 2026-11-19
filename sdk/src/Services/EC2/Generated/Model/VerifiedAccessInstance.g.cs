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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Verified Access instance.
    /// </summary>
    public partial class VerifiedAccessInstance
    {
        /// <summary>
        /// Gets and sets the property CidrEndpointsCustomSubDomain. 
        /// <para>
        /// The custom subdomain.
        /// </para>
        /// </summary>
        public VerifiedAccessInstanceCustomSubDomain CidrEndpointsCustomSubDomain { get; set; }

        /// <summary>
        /// Checks to see if the CidrEndpointsCustomSubDomain property is set.
        /// </summary>
        internal bool IsSetCidrEndpointsCustomSubDomain() => this.CidrEndpointsCustomSubDomain != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FipsEnabled. 
        /// <para>
        /// Indicates whether support for Federal Information Processing Standards (FIPS) is enabled
        /// on the instance.
        /// </para>
        /// </summary>
        public bool? FipsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the FipsEnabled property is set.
        /// </summary>
        internal bool IsSetFipsEnabled() => this.FipsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessInstanceId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessInstanceId() => this.VerifiedAccessInstanceId != null;

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviders. 
        /// <para>
        /// The IDs of the Amazon Web Services Verified Access trust providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VerifiedAccessTrustProviderCondensed> VerifiedAccessTrustProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<VerifiedAccessTrustProviderCondensed>() : null;

        /// <summary>
        /// Checks to see if the VerifiedAccessTrustProviders property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessTrustProviders() => this.VerifiedAccessTrustProviders != null && (this.VerifiedAccessTrustProviders.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
