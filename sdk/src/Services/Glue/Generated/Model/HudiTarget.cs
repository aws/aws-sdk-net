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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an Apache Hudi data source.
    /// </summary>
    public partial class HudiTarget
    {
        private string _connectionName;
        private List<string> _exclusions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maximumTraversalDepth;
        private List<string> _paths = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the Hudi target. If your Hudi files
        /// are stored in buckets that require VPC authorization, you can set their connection
        /// properties here.
        /// </para>
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A list of glob patterns used to exclude from the crawl. For more information, see
        /// <a href="https://docs.aws.amazon.com/glue/latest/dg/add-crawler.html">Catalog Tables
        /// with a Crawler</a>.
        /// </para>
        /// </summary>
        public List<string> Exclusions
        {
            get { return this._exclusions; }
            set { this._exclusions = value; }
        }

        // Check to see if Exclusions property is set
        internal bool IsSetExclusions()
        {
            return this._exclusions != null && (this._exclusions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaximumTraversalDepth. 
        /// <para>
        /// The maximum depth of Amazon S3 paths that the crawler can traverse to discover the
        /// Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time.
        /// </para>
        /// </summary>
        public int MaximumTraversalDepth
        {
            get { return this._maximumTraversalDepth.GetValueOrDefault(); }
            set { this._maximumTraversalDepth = value; }
        }

        // Check to see if MaximumTraversalDepth property is set
        internal bool IsSetMaximumTraversalDepth()
        {
            return this._maximumTraversalDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// An array of Amazon S3 location strings for Hudi, each indicating the root folder with
        /// which the metadata files for a Hudi table resides. The Hudi folder may be located
        /// in a child folder of the root folder.
        /// </para>
        ///  
        /// <para>
        /// The crawler will scan all folders underneath a path for a Hudi folder.
        /// </para>
        /// </summary>
        public List<string> Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null && (this._paths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}