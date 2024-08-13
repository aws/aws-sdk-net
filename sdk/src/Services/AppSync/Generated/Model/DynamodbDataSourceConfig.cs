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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
        private string _awsRegion;
        private DeltaSyncConfig _deltaSyncConfig;
        private string _tableName;
        private bool? _useCallerCredentials;
        private bool? _versioned;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DeltaSyncConfig. 
        /// <para>
        /// The <c>DeltaSyncConfig</c> for a versioned data source.
        /// </para>
        /// </summary>
        public DeltaSyncConfig DeltaSyncConfig
        {
            get { return this._deltaSyncConfig; }
            set { this._deltaSyncConfig = value; }
        }

        // Check to see if DeltaSyncConfig property is set
        internal bool IsSetDeltaSyncConfig()
        {
            return this._deltaSyncConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The table name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property UseCallerCredentials. 
        /// <para>
        /// Set to TRUE to use Amazon Cognito credentials with this data source.
        /// </para>
        /// </summary>
        public bool? UseCallerCredentials
        {
            get { return this._useCallerCredentials; }
            set { this._useCallerCredentials = value; }
        }

        // Check to see if UseCallerCredentials property is set
        internal bool IsSetUseCallerCredentials()
        {
            return this._useCallerCredentials.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Versioned. 
        /// <para>
        /// Set to TRUE to use Conflict Detection and Resolution with this data source.
        /// </para>
        /// </summary>
        public bool? Versioned
        {
            get { return this._versioned; }
            set { this._versioned = value; }
        }

        // Check to see if Versioned property is set
        internal bool IsSetVersioned()
        {
            return this._versioned.HasValue; 
        }

    }
}