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
    /// Metadata for an integrated Bitbucket repository.
    /// </summary>
    public partial class BitbucketRepositoryMetadata
    {
        /// <summary>
        /// Gets and sets the property AccessType.
        /// </summary>
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderResourceId.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderResourceId property is set.
        /// </summary>
        internal bool IsSetProviderResourceId() => this.ProviderResourceId != null;

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The workspace slug that owns the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Workspace { get; set; }

        /// <summary>
        /// Checks to see if the Workspace property is set.
        /// </summary>
        internal bool IsSetWorkspace() => this.Workspace != null;
    }
}
