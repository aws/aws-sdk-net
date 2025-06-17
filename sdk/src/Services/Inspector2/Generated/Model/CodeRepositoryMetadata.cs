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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private string _integrationArn;
        private string _lastScannedCommitId;
        private CodeRepositoryOnDemandScan _onDemandScan;
        private string _projectName;
        private string _providerType;
        private string _providerTypeVisibility;
        private ProjectCodeSecurityScanConfiguration _scanConfiguration;

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the code security integration associated with the
        /// repository.
        /// </para>
        /// </summary>
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastScannedCommitId. 
        /// <para>
        /// The ID of the last commit that was scanned in the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string LastScannedCommitId
        {
            get { return this._lastScannedCommitId; }
            set { this._lastScannedCommitId = value; }
        }

        // Check to see if LastScannedCommitId property is set
        internal bool IsSetLastScannedCommitId()
        {
            return this._lastScannedCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandScan. 
        /// <para>
        /// Information about on-demand scans performed on the repository.
        /// </para>
        /// </summary>
        public CodeRepositoryOnDemandScan OnDemandScan
        {
            get { return this._onDemandScan; }
            set { this._onDemandScan = value; }
        }

        // Check to see if OnDemandScan property is set
        internal bool IsSetOnDemandScan()
        {
            return this._onDemandScan != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of repository provider (such as GitHub, GitLab, etc.).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderTypeVisibility. 
        /// <para>
        /// The visibility setting of the repository (public or private).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string ProviderTypeVisibility
        {
            get { return this._providerTypeVisibility; }
            set { this._providerTypeVisibility = value; }
        }

        // Check to see if ProviderTypeVisibility property is set
        internal bool IsSetProviderTypeVisibility()
        {
            return this._providerTypeVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ScanConfiguration. 
        /// <para>
        /// The scan configuration settings applied to the code repository.
        /// </para>
        /// </summary>
        public ProjectCodeSecurityScanConfiguration ScanConfiguration
        {
            get { return this._scanConfiguration; }
            set { this._scanConfiguration = value; }
        }

        // Check to see if ScanConfiguration property is set
        internal bool IsSetScanConfiguration()
        {
            return this._scanConfiguration != null;
        }

    }
}