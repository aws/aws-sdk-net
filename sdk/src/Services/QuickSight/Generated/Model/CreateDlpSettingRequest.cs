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
    /// Container for the parameters to the CreateDlpSetting operation.
    /// Creates a data loss prevention (DLP) setting configuration for an Amazon Web Services
    /// account. A DLP setting defines the DLP provider, the enforcement behavior, and the
    /// Quick capabilities that the setting applies to.
    /// </summary>
    public partial class CreateDlpSettingRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dlpSettingId;
        private bool? _enabled;
        private string _name;
        private ProviderConfig _providerConfig;
        private DlpAction _providerOutageAction;
        private DlpProviderType _providerType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account in which to create the DLP setting.
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
        /// Gets and sets the property DlpSettingId. 
        /// <para>
        /// A unique identifier for the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DlpSettingId
        {
            get { return this._dlpSettingId; }
            set { this._dlpSettingId = value; }
        }

        // Check to see if DlpSettingId property is set
        internal bool IsSetDlpSettingId()
        {
            return this._dlpSettingId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether DLP enforcement is active for this setting. Set to <c>true</c> to
        /// enable enforcement, or <c>false</c> to disable it at time of setting creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A human-readable display name for the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderConfig. 
        /// <para>
        /// The provider-specific configuration for the DLP integration. This is a union type
        /// structure. For this structure to be valid, only one of the attributes can be defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProviderConfig ProviderConfig
        {
            get { return this._providerConfig; }
            set { this._providerConfig = value; }
        }

        // Check to see if ProviderConfig property is set
        internal bool IsSetProviderConfig()
        {
            return this._providerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderOutageAction. 
        /// <para>
        /// The behavior to apply when the DLP provider is unreachable. Valid values are <c>ALLOW</c>,
        /// <c>WARN</c>, and <c>BLOCK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DlpAction ProviderOutageAction
        {
            get { return this._providerOutageAction; }
            set { this._providerOutageAction = value; }
        }

        // Check to see if ProviderOutageAction property is set
        internal bool IsSetProviderOutageAction()
        {
            return this._providerOutageAction != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of external DLP provider to use for sensitivity label classification. Currently,
        /// the only supported value is <c>MICROSOFT_PURVIEW</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DlpProviderType ProviderType
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of resource tags to apply to the DLP setting. You can use tags to manage access
        /// to your Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

    }
}