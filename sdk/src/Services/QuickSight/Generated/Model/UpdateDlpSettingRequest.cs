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
    /// Container for the parameters to the UpdateDlpSetting operation.
    /// Updates an existing DLP setting configuration in an Amazon Web Services account. Fields
    /// that are omitted from the request retain their current values.
    /// </summary>
    public partial class UpdateDlpSettingRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dlpSettingId;
        private bool? _enabled;
        private string _name;
        private ProviderConfig _providerConfig;
        private DlpAction _providerOutageAction;
        private DlpProviderType _providerType;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the DLP setting that you want
        /// to update.
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
        /// The ID of the DLP setting that you want to update.
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
        /// enable enforcement, or <c>false</c> to disable it.
        /// </para>
        /// </summary>
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
        /// An updated display name for the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// An updated provider-specific configuration for the DLP integration. This is a union
        /// type structure. For this structure to be valid, only one of the attributes can be
        /// defined.
        /// </para>
        /// </summary>
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
        /// An updated behavior to apply when the DLP provider is unreachable. Valid values are
        /// <c>ALLOW</c>, <c>WARN</c>, and <c>BLOCK</c>.
        /// </para>
        /// </summary>
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
        /// An updated DLP provider type. Currently, the only supported value is <c>MICROSOFT_PURVIEW</c>.
        /// </para>
        /// </summary>
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

    }
}