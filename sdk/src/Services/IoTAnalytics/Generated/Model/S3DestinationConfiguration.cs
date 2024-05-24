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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Configuration information for delivery of dataset contents to Amazon Simple Storage
    /// Service (Amazon S3).
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
        /// The name of the S3 bucket to which dataset contents are delivered.
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
        /// Configuration information for coordination with Glue, a fully managed extract, transform
        /// and load (ETL) service.
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
        /// The key of the dataset contents object in an S3 bucket. Each object has a key that
        /// is a unique identifier. Each object has exactly one key.
        /// </para>
        ///  
        /// <para>
        /// You can create a unique key with the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>!{iotanalytics:scheduleTime}</c> to insert the time of a scheduled SQL query
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>!{iotanalytics:versionId}</c> to insert a unique hash that identifies a dataset
        /// content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>!{iotanalytics:creationTime}</c> to insert the creation time of a dataset content.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following example creates a unique key for a CSV file: <c>dataset/mydataset/!{iotanalytics:scheduleTime}/!{iotanalytics:versionId}.csv</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't use <c>!{iotanalytics:versionId}</c> to specify the key, you might get
        /// duplicate keys. For example, you might have two dataset contents with the same <c>scheduleTime</c>
        /// but different <c>versionId</c>s. This means that one dataset content overwrites the
        /// other. 
        /// </para>
        ///  </note>
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
        /// The ARN of the role that grants IoT Analytics permission to interact with your Amazon
        /// S3 and Glue resources.
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