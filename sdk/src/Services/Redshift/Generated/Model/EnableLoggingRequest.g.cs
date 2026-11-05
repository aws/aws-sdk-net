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
    /// Container for the parameters to the EnableLogging operation. Starts logging information,
    /// such as queries and connection attempts, for the specified Amazon Redshift cluster.
    /// </summary>
    public partial class EnableLoggingRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of an existing S3 bucket where the log files are to be stored.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the same region as the cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must have read bucket and put object permissions
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster on which logging is to be started.
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
        /// and <c>s3table</c>.
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
        /// The collection of exported log types. When <c>LogDestinationType</c> is <c>s3</c>
        /// or <c>cloudwatch</c>, possible values are <c>connectionlog</c>, <c>useractivitylog</c>,
        /// and <c>userlog</c>. When <c>LogDestinationType</c> is <c>s3table</c>, the values are
        /// the names of the system tables to publish. Omitting this parameter, passing an empty
        /// list, or including the value <c>all</c> publishes all current and future system tables.
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

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The prefix applied to the log file names.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are any letter from any language, any whitespace character, any numeric
        /// character, and the following characters: underscore (<c>_</c>), period (<c>.</c>),
        /// colon (<c>:</c>), slash (<c>/</c>), equal (<c>=</c>), plus (<c>+</c>), backslash (<c>\</c>),
        /// hyphen (<c>-</c>), at symbol (<c>@</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property S3TableGranularity. 
        /// <para>
        /// The scope of system table publishing. Valid values are <c>cluster</c> and <c>account</c>.
        /// A value of <c>cluster</c> scopes publishing to the individual cluster. A value of
        /// <c>account</c> scopes publishing to the Amazon Web Services account. This parameter
        /// is valid only when <c>LogDestinationType</c> is <c>s3table</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string S3TableGranularity { get; set; }

        /// <summary>
        /// Checks to see if the S3TableGranularity property is set.
        /// </summary>
        internal bool IsSetS3TableGranularity() => this.S3TableGranularity != null;

        /// <summary>
        /// Gets and sets the property S3TableKmsKeyId. 
        /// <para>
        /// The identifier of a customer managed KMS key used to encrypt the S3 tables. This parameter
        /// is valid only when <c>LogDestinationType</c> is <c>s3table</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string S3TableKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3TableKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3TableKmsKeyId() => this.S3TableKmsKeyId != null;
    }
}
