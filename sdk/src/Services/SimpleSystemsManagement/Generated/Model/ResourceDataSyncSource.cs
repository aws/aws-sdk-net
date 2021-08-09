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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the source of the data included in the resource data sync.
    /// </summary>
    public partial class ResourceDataSyncSource
    {
        private ResourceDataSyncAwsOrganizationsSource _awsOrganizationsSource;
        private bool? _enableAllOpsDataSources;
        private bool? _includeFutureRegions;
        private List<string> _sourceRegions = new List<string>();
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property AwsOrganizationsSource. 
        /// <para>
        /// Information about the <code>AwsOrganizationsSource</code> resource data sync source.
        /// A sync source of this type can synchronize data from Organizations.
        /// </para>
        /// </summary>
        public ResourceDataSyncAwsOrganizationsSource AwsOrganizationsSource
        {
            get { return this._awsOrganizationsSource; }
            set { this._awsOrganizationsSource = value; }
        }

        // Check to see if AwsOrganizationsSource property is set
        internal bool IsSetAwsOrganizationsSource()
        {
            return this._awsOrganizationsSource != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAllOpsDataSources. 
        /// <para>
        /// When you create a resource data sync, if you choose one of the Organizations options,
        /// then Systems Manager automatically enables all OpsData sources in the selected Amazon
        /// Web Services Regions for all Amazon Web Services accounts in your organization (or
        /// in the selected organization units). For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resouce-data-sync-multiple-accounts-and-regions.html">About
        /// multiple account and Region resource data syncs</a> in the <i>Amazon Web Services
        /// Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public bool EnableAllOpsDataSources
        {
            get { return this._enableAllOpsDataSources.GetValueOrDefault(); }
            set { this._enableAllOpsDataSources = value; }
        }

        // Check to see if EnableAllOpsDataSources property is set
        internal bool IsSetEnableAllOpsDataSources()
        {
            return this._enableAllOpsDataSources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeFutureRegions. 
        /// <para>
        /// Whether to automatically synchronize and aggregate data from new Amazon Web Services
        /// Regions when those Regions come online.
        /// </para>
        /// </summary>
        public bool IncludeFutureRegions
        {
            get { return this._includeFutureRegions.GetValueOrDefault(); }
            set { this._includeFutureRegions = value; }
        }

        // Check to see if IncludeFutureRegions property is set
        internal bool IsSetIncludeFutureRegions()
        {
            return this._includeFutureRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceRegions. 
        /// <para>
        /// The <code>SyncSource</code> Amazon Web Services Regions included in the resource data
        /// sync.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SourceRegions
        {
            get { return this._sourceRegions; }
            set { this._sourceRegions = value; }
        }

        // Check to see if SourceRegions property is set
        internal bool IsSetSourceRegions()
        {
            return this._sourceRegions != null && this._sourceRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of data source for the resource data sync. <code>SourceType</code> is either
        /// <code>AwsOrganizations</code> (if an organization is present in Organizations) or
        /// <code>SingleAccountMultiRegions</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}