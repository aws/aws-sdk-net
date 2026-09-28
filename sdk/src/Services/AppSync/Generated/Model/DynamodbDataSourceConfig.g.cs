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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an Amazon DynamoDB data source configuration.
    /// </summary>
    public partial class DynamodbDataSourceConfig
    {
        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property DeltaSyncConfig. 
        /// <para>
        /// The <c>DeltaSyncConfig</c> for a versioned data source.
        /// </para>
        /// </summary>
        public DeltaSyncConfig DeltaSyncConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeltaSyncConfig property is set.
        /// </summary>
        internal bool IsSetDeltaSyncConfig() => this.DeltaSyncConfig != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property UseCallerCredentials. 
        /// <para>
        /// Set to TRUE to use Amazon Cognito credentials with this data source.
        /// </para>
        /// </summary>
        public bool? UseCallerCredentials { get; set; }

        /// <summary>
        /// Checks to see if the UseCallerCredentials property is set.
        /// </summary>
        internal bool IsSetUseCallerCredentials() => this.UseCallerCredentials.HasValue;

        /// <summary>
        /// Gets and sets the property Versioned. 
        /// <para>
        /// Set to TRUE to use Conflict Detection and Resolution with this data source.
        /// </para>
        /// </summary>
        public bool? Versioned { get; set; }

        /// <summary>
        /// Checks to see if the Versioned property is set.
        /// </summary>
        internal bool IsSetVersioned() => this.Versioned.HasValue;
    }
}
