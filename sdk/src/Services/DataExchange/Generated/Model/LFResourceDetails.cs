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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the AWS Lake Formation resource (Table or Database) included in the
    /// AWS Lake Formation data permission.
    /// </summary>
    public partial class LFResourceDetails
    {
        private DatabaseLFTagPolicy _database;
        private TableLFTagPolicy _table;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Details about the database resource included in the AWS Lake Formation data permission.
        /// </para>
        /// </summary>
        public DatabaseLFTagPolicy Database
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
        /// Gets and sets the property Table. 
        /// <para>
        /// Details about the table resource included in the AWS Lake Formation data permission.
        /// </para>
        /// </summary>
        public TableLFTagPolicy Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}