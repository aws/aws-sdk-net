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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that contains the configuration parameters for the data source of an import
    /// request.
    /// </summary>
    public partial class ImportDataSourceConfig
    {
        private string _dataSourceUrl;

        /// <summary>
        /// Gets and sets the property DataSourceUrl. 
        /// <para>
        ///  The URL from which source data will be downloaded for the import request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8000)]
        public string DataSourceUrl
        {
            get { return this._dataSourceUrl; }
            set { this._dataSourceUrl = value; }
        }

        // Check to see if DataSourceUrl property is set
        internal bool IsSetDataSourceUrl()
        {
            return this._dataSourceUrl != null;
        }

    }
}