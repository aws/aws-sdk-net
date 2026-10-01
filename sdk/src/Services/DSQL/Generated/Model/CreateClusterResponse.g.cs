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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// This is the response object from the CreateCluster operation.
    /// </summary>
    public partial class CreateClusterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the created cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time of when created the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Whether deletion protection is enabled on this cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionDetails. 
        /// <para>
        /// The encryption configuration for the cluster that was specified during the creation
        /// process, including the KMS key identifier and encryption state.
        /// </para>
        /// </summary>
        public EncryptionDetails EncryptionDetails { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionDetails property is set.
        /// </summary>
        internal bool IsSetEncryptionDetails() => this.EncryptionDetails != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the created cluster.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the created cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property MultiRegionProperties. 
        /// <para>
        /// The multi-Region cluster configuration details that were set during cluster creation
        /// </para>
        /// </summary>
        public MultiRegionProperties MultiRegionProperties { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionProperties property is set.
        /// </summary>
        internal bool IsSetMultiRegionProperties() => this.MultiRegionProperties != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the created cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
