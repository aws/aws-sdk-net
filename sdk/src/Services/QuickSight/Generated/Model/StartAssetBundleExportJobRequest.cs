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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssetBundleExportJob operation.
    /// Starts an Asset Bundle export job.
    /// 
    ///  
    /// <para>
    /// An Asset Bundle export job exports specified Amazon QuickSight assets. You can also
    /// choose to export any asset dependencies in the same job. Export jobs run asynchronously
    /// and can be polled with a <code>DescribeAssetBundleExportJob</code> API call. When
    /// a job is successfully completed, a download URL that contains the exported assets
    /// is returned. The URL is valid for 5 minutes and can be refreshed with a <code>DescribeAssetBundleExportJob</code>
    /// API call. Each Amazon QuickSight account can run up to 5 export jobs concurrently.
    /// </para>
    ///  
    /// <para>
    /// The API caller must have the necessary permissions in their IAM role to access each
    /// resource before the resources can be exported.
    /// </para>
    /// </summary>
    public partial class StartAssetBundleExportJobRequest : AmazonQuickSightRequest
    {
        private string _assetBundleExportJobId;
        private string _awsAccountId;
        private AssetBundleCloudFormationOverridePropertyConfiguration _cloudFormationOverridePropertyConfiguration;
        private AssetBundleExportFormat _exportFormat;
        private bool? _includeAllDependencies;
        private List<string> _resourceArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AssetBundleExportJobId
        {
            get { return this._assetBundleExportJobId; }
            set { this._assetBundleExportJobId = value; }
        }

        // Check to see if AssetBundleExportJobId property is set
        internal bool IsSetAssetBundleExportJobId()
        {
            return this._assetBundleExportJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account to export assets from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudFormationOverridePropertyConfiguration. 
        /// <para>
        /// An optional collection of structures that generate CloudFormation parameters to override
        /// the existing resource property values when the resource is exported to a new CloudFormation
        /// template.
        /// </para>
        ///  
        /// <para>
        /// Use this field if the <code>ExportFormat</code> field of a <code>StartAssetBundleExportJobRequest</code>
        /// API call is set to <code>CLOUDFORMATION_JSON</code>.
        /// </para>
        /// </summary>
        public AssetBundleCloudFormationOverridePropertyConfiguration CloudFormationOverridePropertyConfiguration
        {
            get { return this._cloudFormationOverridePropertyConfiguration; }
            set { this._cloudFormationOverridePropertyConfiguration = value; }
        }

        // Check to see if CloudFormationOverridePropertyConfiguration property is set
        internal bool IsSetCloudFormationOverridePropertyConfiguration()
        {
            return this._cloudFormationOverridePropertyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The export data format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetBundleExportFormat ExportFormat
        {
            get { return this._exportFormat; }
            set { this._exportFormat = value; }
        }

        // Check to see if ExportFormat property is set
        internal bool IsSetExportFormat()
        {
            return this._exportFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAllDependencies. 
        /// <para>
        /// A Boolean that determines whether all dependencies of each resource ARN are recursively
        /// exported with the job. For example, say you provided a Dashboard ARN to the <code>ResourceArns</code>
        /// parameter. If you set <code>IncludeAllDependencies</code> to <code>TRUE</code>, any
        /// theme, dataset, and data source resource that is a dependency of the dashboard is
        /// also exported.
        /// </para>
        /// </summary>
        public bool IncludeAllDependencies
        {
            get { return this._includeAllDependencies.GetValueOrDefault(); }
            set { this._includeAllDependencies = value; }
        }

        // Check to see if IncludeAllDependencies property is set
        internal bool IsSetIncludeAllDependencies()
        {
            return this._includeAllDependencies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// An array of resource ARNs to export. The following resources are supported.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Analysis</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Dashboard</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSet</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSource</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RefreshSchedule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Theme</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPCConnection</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The API caller must have the necessary permissions in their IAM role to access each
        /// resource before the resources can be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

    }
}