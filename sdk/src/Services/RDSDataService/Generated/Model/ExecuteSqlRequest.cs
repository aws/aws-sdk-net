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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteSql operation.
    /// Executes any SQL statement on the target database synchronously
    /// </summary>
    public partial class ExecuteSqlRequest : AmazonRDSDataServiceRequest
    {
        private string _awsSecretStoreArn;
        private string _database;
        private string _dbClusterOrInstanceArn;
        private string _schema;
        private string _sqlStatements;

        /// <summary>
        /// Gets and sets the property AwsSecretStoreArn. ARN of the db credentials in AWS Secret
        /// Store or the friendly secret name
        /// </summary>
        public string AwsSecretStoreArn
        {
            get { return this._awsSecretStoreArn; }
            set { this._awsSecretStoreArn = value; }
        }

        // Check to see if AwsSecretStoreArn property is set
        internal bool IsSetAwsSecretStoreArn()
        {
            return this._awsSecretStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property Database. Target DB name
        /// </summary>
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
        /// Gets and sets the property DbClusterOrInstanceArn. ARN of the target db cluster or
        /// instance
        /// </summary>
        public string DbClusterOrInstanceArn
        {
            get { return this._dbClusterOrInstanceArn; }
            set { this._dbClusterOrInstanceArn = value; }
        }

        // Check to see if DbClusterOrInstanceArn property is set
        internal bool IsSetDbClusterOrInstanceArn()
        {
            return this._dbClusterOrInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. Target Schema name
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SqlStatements. SQL statement(s) to be executed. Statements
        /// can be chained by using semicolons
        /// </summary>
        public string SqlStatements
        {
            get { return this._sqlStatements; }
            set { this._sqlStatements = value; }
        }

        // Check to see if SqlStatements property is set
        internal bool IsSetSqlStatements()
        {
            return this._sqlStatements != null;
        }

    }
}