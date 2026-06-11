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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration for S3 logging behavior in EMR clusters. Defines how different types
    /// of logs are uploaded to S3 based on the specified upload policies for each log type.
    /// </summary>
    public partial class S3LoggingConfiguration
    {
        private Dictionary<string, string> _logTypeUploadPolicy = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property LogTypeUploadPolicy. 
        /// <para>
        /// A map that specifies the upload policy for each log type. The key is the log type,
        /// and the value is the upload policy.
        /// </para>
        ///  
        /// <para>
        /// Valid log types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>system-logs</c>: EMR Daemon logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-logs</c>: Framework logs from Hadoop, Spark, Hive and other applications
        /// running on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>persistent-ui-logs</c>: Logs required for persistent application UIs such as Spark
        /// History Server and Tez UI.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid upload policies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>emr-managed</c>: Standard behavior. Logs are uploaded to S3 bucket as configured
        /// in your LogUri, with certain logs retained by the service for operational support
        /// and troubleshooting purposes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>on-customer-s3only</c>: Logs are uploaded only to the customer-specified S3 bucket.
        /// This requires you to specify a LogUri when creating the cluster. Persistent-ui-logs
        /// cannot have on-customer-s3only policy. Allowed policies for persistent-ui-logs are
        /// emr-managed and disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c>: No S3 upload for this log type.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> LogTypeUploadPolicy
        {
            get { return this._logTypeUploadPolicy; }
            set { this._logTypeUploadPolicy = value; }
        }

        // Check to see if LogTypeUploadPolicy property is set
        internal bool IsSetLogTypeUploadPolicy()
        {
            return this._logTypeUploadPolicy != null && (this._logTypeUploadPolicy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}