/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// Example: <code>examplecluster</code> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The prefix applied to the log file names.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cannot exceed 512 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot contain spaces( ), double quotes ("), single quotes ('), a backslash (\), or
        /// control characters. The hexadecimal codes for invalid characters are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x00 to x20
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x22
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x27
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x5c
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x7f or larger
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
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