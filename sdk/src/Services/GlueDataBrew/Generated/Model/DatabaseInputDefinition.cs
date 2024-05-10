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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Connection information for dataset input files stored in a database.
    /// </summary>
    public partial class DatabaseInputDefinition
    {
        private string _databaseTableName;
        private string _glueConnectionName;
        private string _queryString;
        private S3Location _tempDirectory;

        /// <summary>
        /// Gets and sets the property DatabaseTableName. 
        /// <para>
        /// The table within the target database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatabaseTableName
        {
            get { return this._databaseTableName; }
            set { this._databaseTableName = value; }
        }

        // Check to see if DatabaseTableName property is set
        internal bool IsSetDatabaseTableName()
        {
            return this._databaseTableName != null;
        }

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Glue Connection that stores the connection information for the target database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GlueConnectionName
        {
            get { return this._glueConnectionName; }
            set { this._glueConnectionName = value; }
        }

        // Check to see if GlueConnectionName property is set
        internal bool IsSetGlueConnectionName()
        {
            return this._glueConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// Custom SQL to run against the provided Glue connection. This SQL will be used as the
        /// input for DataBrew projects and jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property TempDirectory.
        /// </summary>
        public S3Location TempDirectory
        {
            get { return this._tempDirectory; }
            set { this._tempDirectory = value; }
        }

        // Check to see if TempDirectory property is set
        internal bool IsSetTempDirectory()
        {
            return this._tempDirectory != null;
        }

    }
}