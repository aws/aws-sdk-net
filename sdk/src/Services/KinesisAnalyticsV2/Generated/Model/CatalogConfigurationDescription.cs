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
    /// The configuration parameters for the default Amazon Glue database. You use this database
    /// for Apache Flink SQL queries and table API transforms that you write in a Managed
    /// Service for Apache Flink Studio notebook.
    /// </summary>
    public partial class CatalogConfigurationDescription
    {
        private GlueDataCatalogConfigurationDescription _glueDataCatalogConfigurationDescription;

        /// <summary>
        /// Gets and sets the property GlueDataCatalogConfigurationDescription. 
        /// <para>
        /// The configuration parameters for the default Amazon Glue database. You use this database
        /// for SQL queries that you write in a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GlueDataCatalogConfigurationDescription GlueDataCatalogConfigurationDescription
        {
            get { return this._glueDataCatalogConfigurationDescription; }
            set { this._glueDataCatalogConfigurationDescription = value; }
        }

        // Check to see if GlueDataCatalogConfigurationDescription property is set
        internal bool IsSetGlueDataCatalogConfigurationDescription()
        {
            return this._glueDataCatalogConfigurationDescription != null;
        }

    }
}