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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The source configuration for a migration, specifying the data source from which to
    /// export saved objects.
    /// </summary>
    public partial class MigrationSource
    {
        private string _datasourceArn;

        /// <summary>
        /// Gets and sets the property DatasourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source to migrate saved objects from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DatasourceArn
        {
            get { return this._datasourceArn; }
            set { this._datasourceArn = value; }
        }

        // Check to see if DatasourceArn property is set
        internal bool IsSetDatasourceArn()
        {
            return this._datasourceArn != null;
        }

    }
}