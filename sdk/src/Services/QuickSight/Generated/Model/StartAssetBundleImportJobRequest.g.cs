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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssetBundleImportJob operation. Starts an
    /// Asset Bundle import job. <para> An Asset Bundle import job imports specified Amazon
    /// Quick Sight assets into an Amazon Quick Sight account. You can also choose to import
    /// a naming prefix and specified configuration overrides. The assets that are contained
    /// in the bundle file that you provide are used to create or update a new or existing
    /// asset in your Amazon Quick Sight account. Each Amazon Quick Sight account can run
    /// up to 5 import jobs concurrently. </para> <para> The API caller must have the necessary
    /// <c>"create"</c>, <c>"describe"</c>, and <c>"update"</c> permissions in their IAM role
    /// to access each resource type that is contained in the bundle file before the resources
    /// can be imported. </para>
    /// </summary>
    public partial class StartAssetBundleImportJobRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AssetBundleImportJobId. 
        /// <para>
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AssetBundleImportJobId { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleImportJobId property is set.
        /// </summary>
        internal bool IsSetAssetBundleImportJobId() => this.AssetBundleImportJobId != null;

        /// <summary>
        /// Gets and sets the property AssetBundleImportSource. 
        /// <para>
        /// The source of the asset bundle zip file that contains the data that you want to import.
        /// The file must be in <c>QUICKSIGHT_JSON</c> format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetBundleImportSource AssetBundleImportSource { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleImportSource property is set.
        /// </summary>
        internal bool IsSetAssetBundleImportSource() => this.AssetBundleImportSource != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account to import assets into. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

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
        /// any asset changes caused by the failed job, possibly keeping the Amazon Quick Sight
        /// account in an inconsistent state.
        /// </para>
        /// </summary>
        public AssetBundleImportFailureAction FailureAction { get; set; }

        /// <summary>
        /// Checks to see if the FailureAction property is set.
        /// </summary>
        internal bool IsSetFailureAction() => this.FailureAction != null;

        /// <summary>
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Optional overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideParameters OverrideParameters { get; set; }

        /// <summary>
        /// Checks to see if the OverrideParameters property is set.
        /// </summary>
        internal bool IsSetOverrideParameters() => this.OverrideParameters != null;

        /// <summary>
        /// Gets and sets the property OverridePermissions. 
        /// <para>
        /// Optional permission overrides that are applied to the resource configuration before
        /// import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverridePermissions OverridePermissions { get; set; }

        /// <summary>
        /// Checks to see if the OverridePermissions property is set.
        /// </summary>
        internal bool IsSetOverridePermissions() => this.OverridePermissions != null;

        /// <summary>
        /// Gets and sets the property OverrideTags. 
        /// <para>
        /// Optional tag overrides that are applied to the resource configuration before import.
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideTags OverrideTags { get; set; }

        /// <summary>
        /// Checks to see if the OverrideTags property is set.
        /// </summary>
        internal bool IsSetOverrideTags() => this.OverrideTags != null;

        /// <summary>
        /// Gets and sets the property OverrideValidationStrategy. 
        /// <para>
        /// An optional validation strategy override for all analyses and dashboards that is applied
        /// to the resource configuration before import. 
        /// </para>
        /// </summary>
        public AssetBundleImportJobOverrideValidationStrategy OverrideValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OverrideValidationStrategy property is set.
        /// </summary>
        internal bool IsSetOverrideValidationStrategy() => this.OverrideValidationStrategy != null;
    }
}
