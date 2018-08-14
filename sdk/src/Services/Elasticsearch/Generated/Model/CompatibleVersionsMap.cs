/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// A map from an <code> <a>ElasticsearchVersion</a> </code> to a list of compatible
    /// <code> <a>ElasticsearchVersion</a> </code> s to which the domain can be upgraded.
    /// </summary>
    public partial class CompatibleVersionsMap
    {
        private string _sourceVersion;
        private List<string> _targetVersions = new List<string>();

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The current version of Elasticsearch on which a domain is.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<string> TargetVersions
        {
            get { return this._targetVersions; }
            set { this._targetVersions = value; }
        }

        // Check to see if TargetVersions property is set
        internal bool IsSetTargetVersions()
        {
            return this._targetVersions != null && this._targetVersions.Count > 0; 
        }

    }
}