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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The BillOfMaterialsImportJob details.
    /// </summary>
    public partial class BillOfMaterialsImportJob
    {
        private string _instanceId;
        private string _jobId;
        private string _message;
        private string _s3uri;
        private ConfigurationJobStatus _status;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The BillOfMaterialsImportJob instanceId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The BillOfMaterialsImportJob jobId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// When the BillOfMaterialsImportJob has reached a terminal state, there will be a message.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property S3uri. 
        /// <para>
        /// The S3 URI from which the CSV is read.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10)]
        public string S3uri
        {
            get { return this._s3uri; }
            set { this._s3uri = value; }
        }

        // Check to see if S3uri property is set
        internal bool IsSetS3uri()
        {
            return this._s3uri != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The BillOfMaterialsImportJob ConfigurationJobStatus.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}