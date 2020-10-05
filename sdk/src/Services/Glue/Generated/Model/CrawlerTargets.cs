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
    /// Specifies data stores to crawl.
    /// </summary>
    public partial class CrawlerTargets
    {
        private List<CatalogTarget> _catalogTargets = new List<CatalogTarget>();
        private List<DynamoDBTarget> _dynamoDBTargets = new List<DynamoDBTarget>();
        private List<JdbcTarget> _jdbcTargets = new List<JdbcTarget>();
        private List<MongoDBTarget> _mongoDBTargets = new List<MongoDBTarget>();
        private List<S3Target> _s3Targets = new List<S3Target>();

        /// <summary>
        /// Gets and sets the property CatalogTargets. 
        /// <para>
        /// Specifies AWS Glue Data Catalog targets.
        /// </para>
        /// </summary>
        public List<CatalogTarget> CatalogTargets
        {
            get { return this._catalogTargets; }
            set { this._catalogTargets = value; }
        }

        // Check to see if CatalogTargets property is set
        internal bool IsSetCatalogTargets()
        {
            return this._catalogTargets != null && this._catalogTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DynamoDBTargets. 
        /// <para>
        /// Specifies Amazon DynamoDB targets.
        /// </para>
        /// </summary>
        public List<DynamoDBTarget> DynamoDBTargets
        {
            get { return this._dynamoDBTargets; }
            set { this._dynamoDBTargets = value; }
        }

        // Check to see if DynamoDBTargets property is set
        internal bool IsSetDynamoDBTargets()
        {
            return this._dynamoDBTargets != null && this._dynamoDBTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JdbcTargets. 
        /// <para>
        /// Specifies JDBC targets.
        /// </para>
        /// </summary>
        public List<JdbcTarget> JdbcTargets
        {
            get { return this._jdbcTargets; }
            set { this._jdbcTargets = value; }
        }

        // Check to see if JdbcTargets property is set
        internal bool IsSetJdbcTargets()
        {
            return this._jdbcTargets != null && this._jdbcTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MongoDBTargets. 
        /// <para>
        /// Specifies Amazon DocumentDB or MongoDB targets.
        /// </para>
        /// </summary>
        public List<MongoDBTarget> MongoDBTargets
        {
            get { return this._mongoDBTargets; }
            set { this._mongoDBTargets = value; }
        }

        // Check to see if MongoDBTargets property is set
        internal bool IsSetMongoDBTargets()
        {
            return this._mongoDBTargets != null && this._mongoDBTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3Targets. 
        /// <para>
        /// Specifies Amazon Simple Storage Service (Amazon S3) targets.
        /// </para>
        /// </summary>
        public List<S3Target> S3Targets
        {
            get { return this._s3Targets; }
            set { this._s3Targets = value; }
        }

        // Check to see if S3Targets property is set
        internal bool IsSetS3Targets()
        {
            return this._s3Targets != null && this._s3Targets.Count > 0; 
        }

    }
}