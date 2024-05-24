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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Contains the configuration information of file formats. IoT Analytics data stores
    /// support JSON and <a href="https://parquet.apache.org/">Parquet</a>.
    /// 
    ///  
    /// <para>
    /// The default file format is JSON. You can specify only one format.
    /// </para>
    ///  
    /// <para>
    /// You can't change the file format after you create the data store.
    /// </para>
    /// </summary>
    public partial class FileFormatConfiguration
    {
        private JsonConfiguration _jsonConfiguration;
        private ParquetConfiguration _parquetConfiguration;

        /// <summary>
        /// Gets and sets the property JsonConfiguration. 
        /// <para>
        /// Contains the configuration information of the JSON format.
        /// </para>
        /// </summary>
        public JsonConfiguration JsonConfiguration
        {
            get { return this._jsonConfiguration; }
            set { this._jsonConfiguration = value; }
        }

        // Check to see if JsonConfiguration property is set
        internal bool IsSetJsonConfiguration()
        {
            return this._jsonConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetConfiguration. 
        /// <para>
        /// Contains the configuration information of the Parquet format.
        /// </para>
        /// </summary>
        public ParquetConfiguration ParquetConfiguration
        {
            get { return this._parquetConfiguration; }
            set { this._parquetConfiguration = value; }
        }

        // Check to see if ParquetConfiguration property is set
        internal bool IsSetParquetConfiguration()
        {
            return this._parquetConfiguration != null;
        }

    }
}