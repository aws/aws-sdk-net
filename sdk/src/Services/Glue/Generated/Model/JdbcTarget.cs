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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a JDBC data store to crawl.
    /// </summary>
    public partial class JdbcTarget
    {
        private string _connectionName;
        private List<string> _enableAdditionalMetadata = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exclusions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _path;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the JDBC target.
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
        /// Gets and sets the property EnableAdditionalMetadata. 
        /// <para>
        /// Specify a value of <c>RAWTYPES</c> or <c>COMMENTS</c> to enable additional metadata
        /// in table responses. <c>RAWTYPES</c> provides the native-level datatype. <c>COMMENTS</c>
        /// provides comments associated with a column or table in the database.
        /// </para>
        ///  
        /// <para>
        /// If you do not need additional metadata, keep the field empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableAdditionalMetadata
        {
            get { return this._enableAdditionalMetadata; }
            set { this._enableAdditionalMetadata = value; }
        }

        // Check to see if EnableAdditionalMetadata property is set
        internal bool IsSetEnableAdditionalMetadata()
        {
            return this._enableAdditionalMetadata != null && (this._enableAdditionalMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A list of glob patterns used to exclude from the crawl. For more information, see
        /// <a href="https://docs.aws.amazon.com/glue/latest/dg/add-crawler.html">Catalog Tables
        /// with a Crawler</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the JDBC target.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}