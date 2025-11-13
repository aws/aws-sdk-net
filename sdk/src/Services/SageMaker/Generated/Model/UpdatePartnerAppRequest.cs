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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePartnerApp operation.
    /// Updates all of the SageMaker Partner AI Apps in an account.
    /// </summary>
    public partial class UpdatePartnerAppRequest : AmazonSageMakerRequest
    {
        private PartnerAppConfig _applicationConfig;
        private string _appVersion;
        private string _arn;
        private string _clientToken;
        private bool? _enableAutoMinorVersionUpgrade;
        private bool? _enableIamSessionBasedIdentity;
        private PartnerAppMaintenanceConfig _maintenanceConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tier;

        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppConfig ApplicationConfig
        {
            get { return this._applicationConfig; }
            set { this._applicationConfig = value; }
        }

        // Check to see if ApplicationConfig property is set
        internal bool IsSetApplicationConfig()
        {
            return this._applicationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The semantic version to upgrade the SageMaker Partner AI App to. Must be the same
        /// semantic version returned in the <c>AvailableUpgrade</c> field from <c>DescribePartnerApp</c>.
        /// Version skipping and downgrades are not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SageMaker Partner AI App to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that guarantees that the call to this API is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAutoMinorVersionUpgrade. 
        /// <para>
        /// When set to <c>TRUE</c>, the SageMaker Partner AI App is automatically upgraded to
        /// the latest minor version during the next scheduled maintenance window, if one is available.
        /// </para>
        /// </summary>
        public bool EnableAutoMinorVersionUpgrade
        {
            get { return this._enableAutoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._enableAutoMinorVersionUpgrade = value; }
        }

        // Check to see if EnableAutoMinorVersionUpgrade property is set
        internal bool IsSetEnableAutoMinorVersionUpgrade()
        {
            return this._enableAutoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableIamSessionBasedIdentity. 
        /// <para>
        /// When set to <c>TRUE</c>, the SageMaker Partner AI App sets the Amazon Web Services
        /// IAM session name or the authenticated IAM user as the identity of the SageMaker Partner
        /// AI App user.
        /// </para>
        /// </summary>
        public bool EnableIamSessionBasedIdentity
        {
            get { return this._enableIamSessionBasedIdentity.GetValueOrDefault(); }
            set { this._enableIamSessionBasedIdentity = value; }
        }

        // Check to see if EnableIamSessionBasedIdentity property is set
        internal bool IsSetEnableIamSessionBasedIdentity()
        {
            return this._enableIamSessionBasedIdentity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceConfig. 
        /// <para>
        /// Maintenance configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppMaintenanceConfig MaintenanceConfig
        {
            get { return this._maintenanceConfig; }
            set { this._maintenanceConfig = value; }
        }

        // Check to see if MaintenanceConfig property is set
        internal bool IsSetMaintenanceConfig()
        {
            return this._maintenanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// Indicates the instance type and size of the cluster attached to the SageMaker Partner
        /// AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}