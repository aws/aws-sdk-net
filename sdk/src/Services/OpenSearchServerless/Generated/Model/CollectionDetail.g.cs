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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about each OpenSearch Serverless collection, including the collection endpoint,
    /// the OpenSearch Dashboards endpoint, and FIPS-compliant endpoints for federal government
    /// workloads.
    /// </summary>
    public partial class CollectionDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// Collection-specific endpoint used to submit index, search, and data upload requests
        /// to an OpenSearch Serverless collection.
        /// </para>
        /// </summary>
        public string CollectionEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CollectionEndpoint property is set.
        /// </summary>
        internal bool IsSetCollectionEndpoint() => this.CollectionEndpoint != null;

        /// <summary>
        /// Gets and sets the property CollectionGroupName. 
        /// <para>
        /// The name of the collection group that contains this collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string CollectionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CollectionGroupName property is set.
        /// </summary>
        internal bool IsSetCollectionGroupName() => this.CollectionGroupName != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The Epoch time when the collection was created.
        /// </para>
        /// </summary>
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardEndpoint. 
        /// <para>
        /// Collection-specific endpoint used to access OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public string DashboardEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DashboardEndpoint property is set.
        /// </summary>
        internal bool IsSetDashboardEndpoint() => this.DashboardEndpoint != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether deletion protection is <c>ENABLED</c> or <c>DISABLED</c> for the
        /// collection.
        /// </para>
        /// </summary>
        public DeletionProtection DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collection.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// A failure code associated with the request.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A message associated with the failure code.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property FipsEndpoints. 
        /// <para>
        /// FIPS-compliant endpoints for the collection. These endpoints use FIPS 140-3 validated
        /// cryptographic modules and are required for federal government workloads that must
        /// comply with FedRAMP security standards.
        /// </para>
        /// </summary>
        public FipsEndpoints FipsEndpoints { get; set; }

        /// <summary>
        /// Checks to see if the FipsEndpoints property is set.
        /// </summary>
        internal bool IsSetFipsEndpoints() => this.FipsEndpoints != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the collection was last modified.
        /// </para>
        /// </summary>
        public long? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StandbyReplicas. 
        /// <para>
        /// Details about an OpenSearch Serverless collection.
        /// </para>
        /// </summary>
        public StandbyReplicas StandbyReplicas { get; set; }

        /// <summary>
        /// Checks to see if the StandbyReplicas property is set.
        /// </summary>
        internal bool IsSetStandbyReplicas() => this.StandbyReplicas != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the collection.
        /// </para>
        /// </summary>
        public CollectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of collection.
        /// </para>
        /// </summary>
        public CollectionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VectorOptions. 
        /// <para>
        /// Configuration options for vector search capabilities in the collection.
        /// </para>
        /// </summary>
        public VectorOptions VectorOptions { get; set; }

        /// <summary>
        /// Checks to see if the VectorOptions property is set.
        /// </summary>
        internal bool IsSetVectorOptions() => this.VectorOptions != null;
    }
}
