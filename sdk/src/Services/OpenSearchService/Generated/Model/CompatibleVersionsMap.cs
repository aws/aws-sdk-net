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
    /// A map of OpenSearch or Elasticsearch versions and the versions you can upgrade them
    /// to.
    /// </summary>
    public partial class CompatibleVersionsMap
    {
        private string _sourceVersion;
        private List<string> _targetVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The current version that the OpenSearch Service domain is running.
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=18)]
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersions. 
        /// <para>
        /// The possible versions that you can upgrade the domain to.
        /// </para>
        /// </summary>
        public List<string> TargetVersions
        {
            get { return this._targetVersions; }
            set { this._targetVersions = value; }
        }

        // Check to see if TargetVersions property is set
        internal bool IsSetTargetVersions()
        {
            return this._targetVersions != null && (this._targetVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}