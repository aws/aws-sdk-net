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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the containers where the destination Apache Iceberg Tables are persisted.
    /// </summary>
    public partial class CatalogConfiguration
    {
        /// <summary>
        /// Gets and sets the property CatalogARN. 
        /// <para>
        ///  Specifies the Glue catalog ARN identifier of the destination Apache Iceberg Tables.
        /// You must specify the ARN in the format <c>arn:aws:glue:region:account-id:catalog</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string CatalogARN { get; set; }

        /// <summary>
        /// Checks to see if the CatalogARN property is set.
        /// </summary>
        internal bool IsSetCatalogARN() => this.CatalogARN != null;

        /// <summary>
        /// Gets and sets the property WarehouseLocation. 
        /// <para>
        /// The warehouse location for Apache Iceberg tables. You must configure this when schema
        /// evolution and table creation is enabled.
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Checks to see if the WarehouseLocation property is set.
        /// </summary>
        internal bool IsSetWarehouseLocation() => this.WarehouseLocation != null;
    }
}
