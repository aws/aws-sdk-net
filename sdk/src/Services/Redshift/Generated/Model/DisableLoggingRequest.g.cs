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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DisableLogging operation. Stops logging information,
    /// such as queries and connection attempts, for the specified Amazon Redshift cluster.
    /// </summary>
    public partial class DisableLoggingRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster on which logging is to be stopped.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>examplecluster</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// The log destination type. An enum with possible values of <c>s3</c>, <c>cloudwatch</c>,
        /// and <c>s3table</c>. When set to <c>s3table</c>, stops system table publishing. When
        /// omitted, the operation disables audit logging.
        /// </para>
        /// </summary>
        public LogDestinationType LogDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the LogDestinationType property is set.
        /// </summary>
        internal bool IsSetLogDestinationType() => this.LogDestinationType != null;

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The collection of log types to stop exporting. When <c>LogDestinationType</c> is <c>s3table</c>,
        /// the values are the names of the system tables to stop publishing. Omitting this parameter
        /// or passing <c>all</c> stops publishing all system tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogExports property is set.
        /// </summary>
        internal bool IsSetLogExports() => this.LogExports != null && (this.LogExports.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
