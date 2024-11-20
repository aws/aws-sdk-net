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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
        private string _commitMessage;
        private DateTime? _createdAt;
        private PackageConfiguration _packageConfiguration;
        private string _packageVersion;
        private PluginProperties _pluginProperties;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// A message associated with the package version when it was uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
        public string CommitMessage
        {
            get { return this._commitMessage; }
            set { this._commitMessage = value; }
        }

        // Check to see if CommitMessage property is set
        internal bool IsSetCommitMessage()
        {
            return this._commitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the package was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PackageConfiguration. 
        /// <para>
        /// The configuration details for a specific version of a package.
        /// </para>
        /// </summary>
        public PackageConfiguration PackageConfiguration
        {
            get { return this._packageConfiguration; }
            set { this._packageConfiguration = value; }
        }

        // Check to see if PackageConfiguration property is set
        internal bool IsSetPackageConfiguration()
        {
            return this._packageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The package version.
        /// </para>
        /// </summary>
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PluginProperties. 
        /// <para>
        /// Additional information about plugin properties if the package is a <c>ZIP-PLUGIN</c>
        /// package.
        /// </para>
        /// </summary>
        public PluginProperties PluginProperties
        {
            get { return this._pluginProperties; }
            set { this._pluginProperties = value; }
        }

        // Check to see if PluginProperties property is set
        internal bool IsSetPluginProperties()
        {
            return this._pluginProperties != null;
        }

    }
}