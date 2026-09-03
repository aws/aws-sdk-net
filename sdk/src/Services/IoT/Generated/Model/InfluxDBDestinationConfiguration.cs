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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The configuration of an InfluxDB topic rule destination.
    /// </summary>
    public partial class InfluxDBDestinationConfiguration
    {
        private string _endpoint;
        private InfluxDBVersion _influxdbVersion;
        private string _secretId;
        private string _secretKey;
        private InfluxDBSecretType _secretType;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The URL of the InfluxDB instance to write to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2000)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property InfluxDBVersion. 
        /// <para>
        /// The major version of the InfluxDB instance. Valid values are <c>V2</c> and <c>V3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InfluxDBVersion InfluxDBVersion
        {
            get { return this._influxdbVersion; }
            set { this._influxdbVersion = value; }
        }

        // Check to see if InfluxDBVersion property is set
        internal bool IsSetInfluxDBVersion()
        {
            return this._influxdbVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the Amazon Web Services Secrets Manager secret that contains the
        /// InfluxDB API token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretKey. 
        /// <para>
        /// The key to read from the secret value when the secret contains a JSON object. If omitted,
        /// IoT uses the entire secret value as the InfluxDB API token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecretKey
        {
            get { return this._secretKey; }
            set { this._secretKey = value; }
        }

        // Check to see if SecretKey property is set
        internal bool IsSetSecretKey()
        {
            return this._secretKey != null;
        }

        /// <summary>
        /// Gets and sets the property SecretType. 
        /// <para>
        /// The type of the secret that contains the InfluxDB API token. Valid values are <c>SecretString</c>
        /// and <c>SecretBinary</c>.
        /// </para>
        ///  
        /// <para>
        /// If omitted, IoT reads the secret as a string.
        /// </para>
        /// </summary>
        public InfluxDBSecretType SecretType
        {
            get { return this._secretType; }
            set { this._secretType = value; }
        }

        // Check to see if SecretType property is set
        internal bool IsSetSecretType()
        {
            return this._secretType != null;
        }

    }
}