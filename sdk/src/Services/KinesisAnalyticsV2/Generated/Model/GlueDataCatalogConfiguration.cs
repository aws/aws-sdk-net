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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The configuration of the Glue Data Catalog that you use for Apache Flink SQL queries
    /// and table API transforms that you write in an application.
    /// </summary>
    public partial class GlueDataCatalogConfiguration
    {
        private string _databaseARN;

        /// <summary>
        /// Gets and sets the property DatabaseARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DatabaseARN
        {
            get { return this._databaseARN; }
            set { this._databaseARN = value; }
        }

        // Check to see if DatabaseARN property is set
        internal bool IsSetDatabaseARN()
        {
            return this._databaseARN != null;
        }

    }
}