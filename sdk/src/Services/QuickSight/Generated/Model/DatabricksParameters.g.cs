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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters that are required to connect to a Databricks data source.
    /// </summary>
    public partial class DatabricksParameters
    {
        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host name of the Databricks data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for the Databricks data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property SqlEndpointPath. 
        /// <para>
        /// The HTTP path of the Databricks data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string SqlEndpointPath { get; set; }

        /// <summary>
        /// Checks to see if the SqlEndpointPath property is set.
        /// </summary>
        internal bool IsSetSqlEndpointPath() => this.SqlEndpointPath != null;
    }
}
