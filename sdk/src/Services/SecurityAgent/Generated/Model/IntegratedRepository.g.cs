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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a code repository that is integrated with the service through a third-party
    /// provider.
    /// </summary>
    public partial class IntegratedRepository
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// An optional override for the repository branch.
        /// </para>
        /// </summary>
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The unique identifier of the integration that provides access to the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property ProviderResourceId. 
        /// <para>
        /// The provider-specific resource identifier for the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderResourceId property is set.
        /// </summary>
        internal bool IsSetProviderResourceId() => this.ProviderResourceId != null;
    }
}
