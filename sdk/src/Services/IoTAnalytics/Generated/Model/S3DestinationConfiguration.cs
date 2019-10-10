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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Configuration information for delivery of data set contents to Amazon S3.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        private string _bucket;
        private GlueConfiguration _glueConfiguration;
        private string _key;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket to which data set contents are delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property GlueConfiguration. 
        /// <para>
        /// Configuration information for coordination with the AWS Glue ETL (extract, transform
        /// and load) service.
        /// </para>
        /// </summary>
        public GlueConfiguration GlueConfiguration
        {
            get { return this._glueConfiguration; }
            set { this._glueConfiguration = value; }
        }

        // Check to see if GlueConfiguration property is set
        internal bool IsSetGlueConfiguration()
        {
            return this._glueConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the data set contents object. Each object in an Amazon S3 bucket has a
        /// key that is its unique identifier within the bucket (each object in a bucket has exactly
        /// one key). To produce a unique key, you can use "!{iotanalytics:scheduledTime}" to
        /// insert the time of the scheduled SQL query run, or "!{iotanalytics:versioned} to insert
        /// a unique hash identifying the data set, for example: "/DataSet/!{iotanalytics:scheduledTime}/!{iotanalytics:versioned}.csv".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role which grants AWS IoT Analytics permission to interact with your
        /// Amazon S3 and AWS Glue resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}