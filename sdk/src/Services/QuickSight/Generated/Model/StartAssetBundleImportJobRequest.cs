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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssetBundleImportJob operation.
    /// Starts an Asset Bundle import job.
    /// 
    ///  
    /// <para>
    /// An Asset Bundle import job imports specified QuickSight assets into an QuickSight
    /// account. You can also choose to import a naming prefix and specified configuration
    /// overrides. The assets that are contained in the bundle file that you provide are used
    /// to create or update a new or existing asset in your QuickSight account. Each QuickSight
    /// account can run up to 5 import jobs concurrently.
    /// </para>
    ///  
    /// <para>
    /// The API caller must have the necessary <c>"create"</c>, <c>"describe"</c>, and <c>"update"</c>
    /// permissions in their IAM role to access each resource type that is contained in the
    /// bundle file before the resources can be imported.
    /// </para>
    /// </summary>
    public partial class StartAssetBundleImportJobRequest : AmazonQuickSightRequest
    {
        private string _assetBundleImportJobId;
        private AssetBundleImportSource _assetBundleImportSource;
        private string _awsAccountId;
        private AssetBundleImportFailureAction _failureAction;
        private AssetBundleImportJobOverrideParameters _overrideParameters;
        private AssetBundleImportJobOverridePermissions _overridePermissions;
        private AssetBundleImportJobOverrideTags _overrideTags;
        private AssetBundleImportJobOverrideValidationStrategy _overrideValidationStrategy;

        /// <summary>
        /// Gets and sets the property AssetBundleImportJobId. 
        /// <para>
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AssetBundleImportJobId
        {
            get { return this._assetBundleImportJobId; }
            set { this._assetBundleImportJobId = value; }
        }

        // Check to see if AssetBundleImportJobId property is set
        internal bool IsSetAssetBundleImportJobId()
        {
            return this._assetBundleImportJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetBundleImportSource. 
        /// <para>
        /// The source of the asset bundle zip file that contains the data that you want to import.
        /// The file must be in <c>QUICKSIGHT_JSON</c> format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetBundleImportSource AssetBundleImportSource
        {
            get { return this._assetBundleImportSource; }
            set { this._assetBundleImportSource = value; }
        }

        // Check to see if AssetBundleImportSource property is set
        internal bool IsSetAssetBundleImportSource()
        {
            return this._assetBundleImportSource != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account to import assets into. 
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
        /// Gets and sets the property FailureAction. 
        /// <para>
        /// The failure action for the import job.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>ROLLBACK</c>, failed import jobs will attempt to undo any asset changes
        /// caused by the failed job.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>DO_NOTHING</c>, failed import jobs will not attempt to roll back
        /// any asset changes caused by the failed job, possibly keeping the QuickSight account
        /// in an inconsistent state.
        /// </para>
        /// </summary>
        public AssetBundleImportFailureAction FailureAction
        {
            get { return this._failureAction; }
            set { this._failureAction = value; }
        }

        // Check to see if FailureAction property is set
        internal bool IsSetFailureAction()
        {
            return this._failureAction != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Optional overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideParameters OverrideParameters
        {
            get { return this._overrideParameters; }
            set { this._overrideParameters = value; }
        }

        // Check to see if OverrideParameters property is set
        internal bool IsSetOverrideParameters()
        {
            return this._overrideParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OverridePermissions. 
        /// <para>
        /// Optional permission overrides that are applied to the resource configuration before
        /// import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverridePermissions OverridePermissions
        {
            get { return this._overridePermissions; }
            set { this._overridePermissions = value; }
        }

        // Check to see if OverridePermissions property is set
        internal bool IsSetOverridePermissions()
        {
            return this._overridePermissions != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideTags. 
        /// <para>
        /// Optional tag overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideTags OverrideTags
        {
            get { return this._overrideTags; }
            set { this._overrideTags = value; }
        }

        // Check to see if OverrideTags property is set
        internal bool IsSetOverrideTags()
        {
            return this._overrideTags != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideValidationStrategy. 
        /// <para>
        /// An optional validation strategy override for all analyses and dashboards that is applied
        /// to the resource configuration before import. 
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideValidationStrategy OverrideValidationStrategy
        {
            get { return this._overrideValidationStrategy; }
            set { this._overrideValidationStrategy = value; }
        }

        // Check to see if OverrideValidationStrategy property is set
        internal bool IsSetOverrideValidationStrategy()
        {
            return this._overrideValidationStrategy != null;
        }

    }
}