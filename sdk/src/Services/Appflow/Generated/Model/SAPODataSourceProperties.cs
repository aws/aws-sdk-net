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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when using SAPOData as a flow source.
    /// </summary>
    public partial class SAPODataSourceProperties
    {
        private string _objectPath;
        private SAPODataPaginationConfig _paginationConfig;
        private SAPODataParallelismConfig _parallelismConfig;

        /// <summary>
        /// Gets and sets the property ObjectPath. 
        /// <para>
        ///  The object path specified in the SAPOData flow source. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ObjectPath
        {
            get { return this._objectPath; }
            set { this._objectPath = value; }
        }

        // Check to see if ObjectPath property is set
        internal bool IsSetObjectPath()
        {
            return this._objectPath != null;
        }

        /// <summary>
        /// Gets and sets the property PaginationConfig. 
        /// <para>
        /// Sets the page size for each concurrent process that transfers OData records from your
        /// SAP instance.
        /// </para>
        /// </summary>
        public SAPODataPaginationConfig PaginationConfig
        {
            get { return this._paginationConfig; }
            set { this._paginationConfig = value; }
        }

        // Check to see if PaginationConfig property is set
        internal bool IsSetPaginationConfig()
        {
            return this._paginationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfig. 
        /// <para>
        /// Sets the number of concurrent processes that transfers OData records from your SAP
        /// instance.
        /// </para>
        /// </summary>
        public SAPODataParallelismConfig ParallelismConfig
        {
            get { return this._parallelismConfig; }
            set { this._parallelismConfig = value; }
        }

        // Check to see if ParallelismConfig property is set
        internal bool IsSetParallelismConfig()
        {
            return this._parallelismConfig != null;
        }

    }
}