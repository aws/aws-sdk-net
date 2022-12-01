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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a self-managed Apache Kafka stream as a source.
    /// </summary>
    public partial class UpdatePipeSourceSelfManagedKafkaParameters
    {
        private int? _batchSize;
        private SelfManagedKafkaAccessConfigurationCredentials _credentials;
        private int? _maximumBatchingWindowInSeconds;
        private string _serverRootCaCertificate;
        private SelfManagedKafkaAccessConfigurationVpc _vpc;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records to include in each batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials needed to access the resource.
        /// </para>
        /// </summary>
        public SelfManagedKafkaAccessConfigurationCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum length of a time to wait for events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds.GetValueOrDefault(); }
            set { this._maximumBatchingWindowInSeconds = value; }
        }

        // Check to see if MaximumBatchingWindowInSeconds property is set
        internal bool IsSetMaximumBatchingWindowInSeconds()
        {
            return this._maximumBatchingWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerRootCaCertificate. 
        /// <para>
        /// The ARN of the Secrets Manager secret used for certification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ServerRootCaCertificate
        {
            get { return this._serverRootCaCertificate; }
            set { this._serverRootCaCertificate = value; }
        }

        // Check to see if ServerRootCaCertificate property is set
        internal bool IsSetServerRootCaCertificate()
        {
            return this._serverRootCaCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// This structure specifies the VPC subnets and security groups for the stream, and whether
        /// a public IP address is to be used.
        /// </para>
        /// </summary>
        public SelfManagedKafkaAccessConfigurationVpc Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}