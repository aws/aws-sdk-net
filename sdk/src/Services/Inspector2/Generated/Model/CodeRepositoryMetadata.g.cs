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
    /// Contains metadata information about a code repository that is being scanned by Amazon
    /// Inspector.
    /// </summary>
    public partial class CodeRepositoryMetadata
    {
        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the code security integration associated with the
        /// repository.
        /// </para>
        /// </summary>
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property LastScannedCommitId. 
        /// <para>
        /// The ID of the last commit that was scanned in the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 40)]
        public string LastScannedCommitId { get; set; }

        /// <summary>
        /// Checks to see if the LastScannedCommitId property is set.
        /// </summary>
        internal bool IsSetLastScannedCommitId() => this.LastScannedCommitId != null;

        /// <summary>
        /// Gets and sets the property OnDemandScan. 
        /// <para>
        /// Information about on-demand scans performed on the repository.
        /// </para>
        /// </summary>
        public CodeRepositoryOnDemandScan OnDemandScan { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandScan property is set.
        /// </summary>
        internal bool IsSetOnDemandScan() => this.OnDemandScan != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of repository provider (such as GitHub, GitLab, etc.).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property ProviderTypeVisibility. 
        /// <para>
        /// The visibility setting of the repository (public or private).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string ProviderTypeVisibility { get; set; }

        /// <summary>
        /// Checks to see if the ProviderTypeVisibility property is set.
        /// </summary>
        internal bool IsSetProviderTypeVisibility() => this.ProviderTypeVisibility != null;

        /// <summary>
        /// Gets and sets the property ScanConfiguration. 
        /// <para>
        /// The scan configuration settings applied to the code repository.
        /// </para>
        /// </summary>
        public ProjectCodeSecurityScanConfiguration ScanConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfiguration property is set.
        /// </summary>
        internal bool IsSetScanConfiguration() => this.ScanConfiguration != null;
    }
}
