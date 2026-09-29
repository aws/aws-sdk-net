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
    /// Container for the parameters to the UpdateDlpSetting operation. Updates an existing
    /// DLP setting configuration in an Amazon Web Services account. Fields that are omitted
    /// from the request retain their current values.
    /// </summary>
    public partial class UpdateDlpSettingRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the DLP setting that you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DlpSettingId. 
        /// <para>
        /// The ID of the DLP setting that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DlpSettingId { get; set; }

        /// <summary>
        /// Checks to see if the DlpSettingId property is set.
        /// </summary>
        internal bool IsSetDlpSettingId() => this.DlpSettingId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether DLP enforcement is active for this setting. Set to <c>true</c> to
        /// enable enforcement, or <c>false</c> to disable it.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An updated display name for the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderConfig. 
        /// <para>
        /// An updated provider-specific configuration for the DLP integration. This is a union
        /// type structure. For this structure to be valid, only one of the attributes can be
        /// defined.
        /// </para>
        /// </summary>
        public ProviderConfig ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfig property is set.
        /// </summary>
        internal bool IsSetProviderConfig() => this.ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property ProviderOutageAction. 
        /// <para>
        /// An updated behavior to apply when the DLP provider is unreachable. Valid values are
        /// <c>ALLOW</c>, <c>WARN</c>, and <c>BLOCK</c>.
        /// </para>
        /// </summary>
        public DlpAction ProviderOutageAction { get; set; }

        /// <summary>
        /// Checks to see if the ProviderOutageAction property is set.
        /// </summary>
        internal bool IsSetProviderOutageAction() => this.ProviderOutageAction != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// An updated DLP provider type. Currently, the only supported value is <c>MICROSOFT_PURVIEW</c>.
        /// </para>
        /// </summary>
        public DlpProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;
    }
}
