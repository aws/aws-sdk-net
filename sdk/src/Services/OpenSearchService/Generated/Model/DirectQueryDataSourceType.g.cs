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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The type of data source that is used for direct queries. This is a supported Amazon
    /// Web Services service, such as CloudWatch Logs or Security Lake.
    /// </summary>
    public partial class DirectQueryDataSourceType
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLog. 
        /// <para>
        ///  Specifies CloudWatch Logs as a type of data source for direct queries. 
        /// </para>
        /// </summary>
        public CloudWatchDirectQueryDataSource CloudWatchLog { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLog property is set.
        /// </summary>
        internal bool IsSetCloudWatchLog() => this.CloudWatchLog != null;

        /// <summary>
        /// Gets and sets the property Prometheus. 
        /// <para>
        ///  Specifies Prometheus as a type of data source for direct queries. 
        /// </para>
        /// </summary>
        public PrometheusDirectQueryDataSource Prometheus { get; set; }

        /// <summary>
        /// Checks to see if the Prometheus property is set.
        /// </summary>
        internal bool IsSetPrometheus() => this.Prometheus != null;

        /// <summary>
        /// Gets and sets the property SecurityLake. 
        /// <para>
        ///  Specifies Security Lake as a type of data source for direct queries. 
        /// </para>
        /// </summary>
        public SecurityLakeDirectQueryDataSource SecurityLake { get; set; }

        /// <summary>
        /// Checks to see if the SecurityLake property is set.
        /// </summary>
        internal bool IsSetSecurityLake() => this.SecurityLake != null;
    }
}
