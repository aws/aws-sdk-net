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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Container for the parameters to the BeginTransaction operation.
    /// Starts a SQL transaction.
    /// 
    ///  <note> 
    /// <para>
    /// A transaction can run for a maximum of 24 hours. A transaction is terminated and rolled
    /// back automatically after 24 hours.
    /// </para>
    ///  
    /// <para>
    /// A transaction times out if no calls use its transaction ID in three minutes. If a
    /// transaction times out before it's committed, it's rolled back automatically.
    /// </para>
    ///  
    /// <para>
    /// For Aurora MySQL, DDL statements inside a transaction cause an implicit commit. We
    /// recommend that you run each MySQL DDL statement in a separate <c>ExecuteStatement</c>
    /// call with <c>continueAfterTimeout</c> enabled.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BeginTransactionRequest : AmazonRDSDataServiceRequest
    {
        private string _database;
        private string _resourceArn;
        private string _schema;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora Serverless DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=100)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The name of the database schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=100)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}