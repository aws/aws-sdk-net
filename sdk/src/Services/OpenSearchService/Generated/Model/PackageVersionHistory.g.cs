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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Details about a package version.
    /// </summary>
    public partial class PackageVersionHistory
    {
        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// A message associated with the package version when it was uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 160)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the package was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        /// The configuration details for a specific version of a package.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PackageConfiguration property is set.
        /// </summary>
        internal bool IsSetPackageConfiguration() => this.PackageConfiguration != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The package version.
        /// </para>
        /// </summary>
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property PluginProperties. 
        /// <para>
        /// Additional information about plugin properties if the package is a <c>ZIP-PLUGIN</c>
        /// package.
        /// </para>
        /// </summary>
        public PluginProperties PluginProperties { get; set; }

        /// <summary>
        /// Checks to see if the PluginProperties property is set.
        /// </summary>
        internal bool IsSetPluginProperties() => this.PluginProperties != null;
    }
}
