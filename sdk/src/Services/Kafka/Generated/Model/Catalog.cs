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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration of the AWS Glue Data Catalog and S3 Tables warehouse used by the Apache
    /// Iceberg destination.
    /// </summary>
    public partial class Catalog
    {
        private string _catalogArn;
        private string _warehouseLocation;

        /// <summary>
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the federated AWS Glue Data Catalog that projects
        /// the S3 Tables bucket. If omitted, MSK derives the catalog ARN from warehouseLocation.
        /// </para>
        /// </summary>
        public string CatalogArn
        {
            get { return this._catalogArn; }
            set { this._catalogArn = value; }
        }

        // Check to see if CatalogArn property is set
        internal bool IsSetCatalogArn()
        {
            return this._catalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property WarehouseLocation. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Tables bucket that backs the Apache Iceberg
        /// warehouse.
        /// </para>
        /// </summary>
        public string WarehouseLocation
        {
            get { return this._warehouseLocation; }
            set { this._warehouseLocation = value; }
        }

        // Check to see if WarehouseLocation property is set
        internal bool IsSetWarehouseLocation()
        {
            return this._warehouseLocation != null;
        }

    }
}