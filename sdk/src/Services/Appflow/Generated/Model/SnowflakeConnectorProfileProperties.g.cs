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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using Snowflake.
    /// </summary>
    public partial class SnowflakeConnectorProfileProperties
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        ///  The name of the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The name of the Amazon S3 bucket associated with Snowflake. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The bucket path that refers to the Amazon S3 bucket associated with Snowflake. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the BucketPrefix property is set.
        /// </summary>
        internal bool IsSetBucketPrefix() => this.BucketPrefix != null;

        /// <summary>
        /// Gets and sets the property PrivateLinkServiceName. 
        /// <para>
        ///  The Snowflake Private Link service name to be used for private data transfers. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string PrivateLinkServiceName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateLinkServiceName property is set.
        /// </summary>
        internal bool IsSetPrivateLinkServiceName() => this.PrivateLinkServiceName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region of the Snowflake account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  The name of the Amazon S3 stage that was created while setting up an Amazon S3 stage
        /// in the Snowflake account. This is written in the following format: &lt; Database>&lt;
        /// Schema>&lt;Stage Name&gt;. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property Warehouse. 
        /// <para>
        ///  The name of the Snowflake warehouse. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string Warehouse { get; set; }

        /// <summary>
        /// Checks to see if the Warehouse property is set.
        /// </summary>
        internal bool IsSetWarehouse() => this.Warehouse != null;
    }
}
