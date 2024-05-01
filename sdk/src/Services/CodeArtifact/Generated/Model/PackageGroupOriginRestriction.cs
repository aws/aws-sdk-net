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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
        private PackageGroupOriginRestrictionMode _effectiveMode;
        private PackageGroupReference _inheritedFrom;
        private PackageGroupOriginRestrictionMode _mode;
        private long? _repositoriesCount;

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
        public PackageGroupOriginRestrictionMode EffectiveMode
        {
            get { return this._effectiveMode; }
            set { this._effectiveMode = value; }
        }

        // Check to see if EffectiveMode property is set
        internal bool IsSetEffectiveMode()
        {
            return this._effectiveMode != null;
        }

        /// <summary>
        /// Gets and sets the property InheritedFrom. 
        /// <para>
        /// The parent package group that the package group origin restrictions are inherited
        /// from.
        /// </para>
        /// </summary>
        public PackageGroupReference InheritedFrom
        {
            get { return this._inheritedFrom; }
            set { this._inheritedFrom = value; }
        }

        // Check to see if InheritedFrom property is set
        internal bool IsSetInheritedFrom()
        {
            return this._inheritedFrom != null;
        }

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
        public PackageGroupOriginRestrictionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoriesCount. 
        /// <para>
        /// The number of repositories in the allowed repository list.
        /// </para>
        /// </summary>
        public long? RepositoriesCount
        {
            get { return this._repositoriesCount; }
            set { this._repositoriesCount = value; }
        }

        // Check to see if RepositoriesCount property is set
        internal bool IsSetRepositoriesCount()
        {
            return this._repositoriesCount.HasValue; 
        }

    }
}