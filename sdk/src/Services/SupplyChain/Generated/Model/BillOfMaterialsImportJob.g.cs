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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The BillOfMaterialsImportJob details.
    /// </summary>
    public partial class BillOfMaterialsImportJob
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The BillOfMaterialsImportJob instanceId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The BillOfMaterialsImportJob jobId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// When the BillOfMaterialsImportJob has reached a terminal state, there will be a message.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property S3uri. 
        /// <para>
        /// The S3 URI from which the CSV is read.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10)]
        public string S3uri { get; set; }

        /// <summary>
        /// Checks to see if the S3uri property is set.
        /// </summary>
        internal bool IsSetS3uri() => this.S3uri != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The BillOfMaterialsImportJob ConfigurationJobStatus.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
