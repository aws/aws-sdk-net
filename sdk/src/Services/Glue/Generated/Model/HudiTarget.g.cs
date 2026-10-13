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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an Apache Hudi data source.
    /// </summary>
    public partial class HudiTarget
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the Hudi target. If your Hudi files
        /// are stored in buckets that require VPC authorization, you can set their connection
        /// properties here.
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A list of glob patterns used to exclude from the crawl. For more information, see
        /// <a href="https://docs.aws.amazon.com/glue/latest/dg/add-crawler.html">Catalog Tables
        /// with a Crawler</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Exclusions property is set.
        /// </summary>
        internal bool IsSetExclusions() => this.Exclusions != null && (this.Exclusions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumTraversalDepth. 
        /// <para>
        /// The maximum depth of Amazon S3 paths that the crawler can traverse to discover the
        /// Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time.
        /// </para>
        /// </summary>
        public int? MaximumTraversalDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaximumTraversalDepth property is set.
        /// </summary>
        internal bool IsSetMaximumTraversalDepth() => this.MaximumTraversalDepth.HasValue;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
