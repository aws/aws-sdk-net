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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Contains information about the S3 Tables integration configuration for a configuration
    /// template.
    /// </summary>
    public partial class S3TablesIntegration
    {
        /// <summary>
        /// Gets and sets the property DatasourceName. 
        /// <para>
        /// The name of the S3 Tables datasource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// Checks to see if the DatasourceName property is set.
        /// </summary>
        internal bool IsSetDatasourceName() => this.DatasourceName != null;

        /// <summary>
        /// Gets and sets the property DatasourceType. 
        /// <para>
        /// The type of the S3 Tables datasource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// Checks to see if the DatasourceType property is set.
        /// </summary>
        internal bool IsSetDatasourceType() => this.DatasourceType != null;
    }
}
