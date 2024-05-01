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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using Snowflake.
    /// </summary>
    public partial class SnowflakeConnectorProfileProperties
    {
        private string _accountName;
        private string _bucketName;
        private string _bucketPrefix;
        private string _privateLinkServiceName;
        private string _region;
        private string _stage;
        private string _warehouse;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        ///  The name of the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The name of the Amazon S3 bucket associated with Snowflake. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The bucket path that refers to the Amazon S3 bucket associated with Snowflake. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateLinkServiceName. 
        /// <para>
        ///  The Snowflake Private Link service name to be used for private data transfers. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string PrivateLinkServiceName
        {
            get { return this._privateLinkServiceName; }
            set { this._privateLinkServiceName = value; }
        }

        // Check to see if PrivateLinkServiceName property is set
        internal bool IsSetPrivateLinkServiceName()
        {
            return this._privateLinkServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region of the Snowflake account. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  The name of the Amazon S3 stage that was created while setting up an Amazon S3 stage
        /// in the Snowflake account. This is written in the following format: &lt; Database&gt;&lt;
        /// Schema&gt;&lt;Stage Name&gt;. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property Warehouse. 
        /// <para>
        ///  The name of the Snowflake warehouse. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Warehouse
        {
            get { return this._warehouse; }
            set { this._warehouse = value; }
        }

        // Check to see if Warehouse property is set
        internal bool IsSetWarehouse()
        {
            return this._warehouse != null;
        }

    }
}