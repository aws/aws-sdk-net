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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// The details of a public registry.
    /// </summary>
    public partial class Registry
    {
        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// An array of objects that represents the aliases for a public registry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RegistryAlias> Aliases { get; set; } = AWSConfigs.InitializeCollections ? new List<RegistryAlias>() : null;

        /// <summary>
        /// Checks to see if the Aliases property is set.
        /// </summary>
        internal bool IsSetAliases() => this.Aliases != null && (this.Aliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the public registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the registry. If you do
        /// not specify a registry, the default public registry is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RegistryUri. 
        /// <para>
        /// The URI of a public registry. The URI contains a universal prefix and the registry
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistryUri { get; set; }

        /// <summary>
        /// Checks to see if the RegistryUri property is set.
        /// </summary>
        internal bool IsSetRegistryUri() => this.RegistryUri != null;

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Indicates whether the account is a verified Amazon Web Services Marketplace vendor.
        /// If an account is verified, each public repository receives a verified account badge
        /// on the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Checks to see if the Verified property is set.
        /// </summary>
        internal bool IsSetVerified() => this.Verified.HasValue;
    }
}
