/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Starts logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
    /// </summary>
    public partial class EnableLoggingRequest : AmazonRedshiftRequest
    {
        private string clusterIdentifier;
        private string bucketName;
        private string s3KeyPrefix;


        /// <summary>
        /// The identifier of the cluster on which logging is to be started. Example: <c>examplecluster</c>
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The name of an existing S3 bucket where the log files are to be stored. Constraints: <ul> <li>Must be in the same region as the cluster</li>
        /// <li>The cluster must have read bucket and put object permissions</li> </ul>
        ///  
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The prefix applied to the log file names. Constraints: <ul> <li>Cannot exceed 512 characters</li> <li>Cannot contain spaces( ), double
        /// quotes ("), single quotes ('), a backslash (\), or control characters. The hexadecimal codes for invalid characters are: <ul> <li>x00 to
        /// x20</li> <li>x22</li> <li>x27</li> <li>x5c</li> <li>x7f or larger</li> </ul> </li> </ul>
        ///  
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this.s3KeyPrefix; }
            set { this.s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this.s3KeyPrefix != null;
        }

    }
}
    
