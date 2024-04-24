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
    /// Specifies an Amazon Redshift data store.
    /// </summary>
    public partial class RedshiftSource
    {
        private string _database;
        private string _name;
        private string _redshiftTmpDir;
        private string _table;
        private string _tmpDirIAMRole;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Redshift data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftTmpDir. 
        /// <para>
        /// The Amazon S3 path where temporary data can be staged when copying out of the database.
        /// </para>
        /// </summary>
        public string RedshiftTmpDir
        {
            get { return this._redshiftTmpDir; }
            set { this._redshiftTmpDir = value; }
        }

        // Check to see if RedshiftTmpDir property is set
        internal bool IsSetRedshiftTmpDir()
        {
            return this._redshiftTmpDir != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The database table to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

        /// <summary>
        /// Gets and sets the property TmpDirIAMRole. 
        /// <para>
        /// The IAM role with permissions.
        /// </para>
        /// </summary>
        public string TmpDirIAMRole
        {
            get { return this._tmpDirIAMRole; }
            set { this._tmpDirIAMRole = value; }
        }

        // Check to see if TmpDirIAMRole property is set
        internal bool IsSetTmpDirIAMRole()
        {
            return this._tmpDirIAMRole != null;
        }

    }
}