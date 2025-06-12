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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Container for the parameters to the EnableLogging operation.
    /// Starts logging information, such as queries and connection attempts, for the specified
    /// Amazon Redshift cluster.
    /// </summary>
    public partial class EnableLoggingRequest : AmazonRedshiftRequest
    {
        private string _bucketName;
        private string _clusterIdentifier;
        private LogDestinationType _logDestinationType;
        private List<string> _logExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _s3KeyPrefix;

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
        [AWSProperty(Max=2147483647)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

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
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// The log destination type. An enum with possible values of <c>s3</c> and <c>cloudwatch</c>.
        /// </para>
        /// </summary>
        public LogDestinationType LogDestinationType
        {
            get { return this._logDestinationType; }
            set { this._logDestinationType = value; }
        }

        // Check to see if LogDestinationType property is set
        internal bool IsSetLogDestinationType()
        {
            return this._logDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The collection of exported log types. Possible values are <c>connectionlog</c>, <c>useractivitylog</c>,
        /// and <c>userlog</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogExports
        {
            get { return this._logExports; }
            set { this._logExports = value; }
        }

        // Check to see if LogExports property is set
        internal bool IsSetLogExports()
        {
            return this._logExports != null && (this._logExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Max=256)]
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

    }
}