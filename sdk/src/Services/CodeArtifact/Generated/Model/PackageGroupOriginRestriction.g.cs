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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Contains information about the configured restrictions of the origin controls of a
    /// package group.
    /// </summary>
    public partial class PackageGroupOriginRestriction
    {
        /// <summary>
        /// Gets and sets the property EffectiveMode. 
        /// <para>
        /// The effective package group origin restriction setting. If the value of <c>mode</c>
        /// is <c>ALLOW</c>, <c>ALLOW_SPECIFIC_REPOSITORIES</c>, or <c>BLOCK</c>, then the value
        /// of <c>effectiveMode</c> is the same. Otherwise, when the value of <c>mode</c> is <c>INHERIT</c>,
        /// then the value of <c>effectiveMode</c> is the value of <c>mode</c> of the first parent
        /// group which does not have a value of <c>INHERIT</c>.
        /// </para>
        /// </summary>
        public PackageGroupOriginRestrictionMode EffectiveMode { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveMode property is set.
        /// </summary>
        internal bool IsSetEffectiveMode() => this.EffectiveMode != null;

        /// <summary>
        /// Gets and sets the property InheritedFrom. 
        /// <para>
        /// The parent package group that the package group origin restrictions are inherited
        /// from.
        /// </para>
        /// </summary>
        public PackageGroupReference InheritedFrom { get; set; }

        /// <summary>
        /// Checks to see if the InheritedFrom property is set.
        /// </summary>
        internal bool IsSetInheritedFrom() => this.InheritedFrom != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The package group origin restriction setting. If the value of <c>mode</c> is <c>ALLOW</c>,
        /// <c>ALLOW_SPECIFIC_REPOSITORIES</c>, or <c>BLOCK</c>, then the value of <c>effectiveMode</c>
        /// is the same. Otherwise, when the value is <c>INHERIT</c>, then the value of <c>effectiveMode</c>
        /// is the value of <c>mode</c> of the first parent group which does not have a value
        /// of <c>INHERIT</c>.
        /// </para>
        /// </summary>
        public PackageGroupOriginRestrictionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property RepositoriesCount. 
        /// <para>
        /// The number of repositories in the allowed repository list.
        /// </para>
        /// </summary>
        public long? RepositoriesCount { get; set; }

        /// <summary>
        /// Checks to see if the RepositoriesCount property is set.
        /// </summary>
        internal bool IsSetRepositoriesCount() => this.RepositoriesCount.HasValue;
    }
}
