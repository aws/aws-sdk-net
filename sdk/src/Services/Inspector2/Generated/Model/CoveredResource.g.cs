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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about a resource covered by Amazon Inspector.
    /// </summary>
    public partial class CoveredResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property LastScannedAt. 
        /// <para>
        /// The date and time the resource was last checked for vulnerabilities.
        /// </para>
        /// </summary>
        public DateTime? LastScannedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastScannedAt property is set.
        /// </summary>
        internal bool IsSetLastScannedAt() => this.LastScannedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider of the covered resource.
        /// </para>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property ProviderAccountId. 
        /// <para>
        /// The cloud provider account ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string ProviderAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderAccountId property is set.
        /// </summary>
        internal bool IsSetProviderAccountId() => this.ProviderAccountId != null;

        /// <summary>
        /// Gets and sets the property ProviderOrgId. 
        /// <para>
        /// The cloud provider organization ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string ProviderOrgId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderOrgId property is set.
        /// </summary>
        internal bool IsSetProviderOrgId() => this.ProviderOrgId != null;

        /// <summary>
        /// Gets and sets the property ProviderPartition. 
        /// <para>
        /// The cloud provider partition of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProviderPartition { get; set; }

        /// <summary>
        /// Checks to see if the ProviderPartition property is set.
        /// </summary>
        internal bool IsSetProviderPartition() => this.ProviderPartition != null;

        /// <summary>
        /// Gets and sets the property ProviderRegion. 
        /// <para>
        /// The cloud provider region of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProviderRegion { get; set; }

        /// <summary>
        /// Checks to see if the ProviderRegion property is set.
        /// </summary>
        internal bool IsSetProviderRegion() => this.ProviderRegion != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceMetadata. 
        /// <para>
        /// An object that contains details about the metadata.
        /// </para>
        /// </summary>
        public ResourceScanMetadata ResourceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ResourceMetadata property is set.
        /// </summary>
        internal bool IsSetResourceMetadata() => this.ResourceMetadata != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the covered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CoverageResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scan method that is applied to the instance.
        /// </para>
        /// </summary>
        public ScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;

        /// <summary>
        /// Gets and sets the property ScanStatus. 
        /// <para>
        /// The status of the scan covering the resource.
        /// </para>
        /// </summary>
        public ScanStatus ScanStatus { get; set; }

        /// <summary>
        /// Checks to see if the ScanStatus property is set.
        /// </summary>
        internal bool IsSetScanStatus() => this.ScanStatus != null;

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The Amazon Inspector scan type covering the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;
    }
}
