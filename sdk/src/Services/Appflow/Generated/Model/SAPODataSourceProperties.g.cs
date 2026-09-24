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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when using SAPOData as a flow source.
    /// </summary>
    public partial class SAPODataSourceProperties
    {
        /// <summary>
        /// Gets and sets the property ObjectPath. 
        /// <para>
        ///  The object path specified in the SAPOData flow source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// Checks to see if the ObjectPath property is set.
        /// </summary>
        internal bool IsSetObjectPath() => this.ObjectPath != null;

        /// <summary>
        /// Gets and sets the property PaginationConfig. 
        /// <para>
        /// Sets the page size for each concurrent process that transfers OData records from your
        /// SAP instance.
        /// </para>
        /// </summary>
        public SAPODataPaginationConfig PaginationConfig { get; set; }

        /// <summary>
        /// Checks to see if the PaginationConfig property is set.
        /// </summary>
        internal bool IsSetPaginationConfig() => this.PaginationConfig != null;

        /// <summary>
        /// Gets and sets the property ParallelismConfig. 
        /// <para>
        /// Sets the number of concurrent processes that transfers OData records from your SAP
        /// instance.
        /// </para>
        /// </summary>
        public SAPODataParallelismConfig ParallelismConfig { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfig property is set.
        /// </summary>
        internal bool IsSetParallelismConfig() => this.ParallelismConfig != null;
    }
}
