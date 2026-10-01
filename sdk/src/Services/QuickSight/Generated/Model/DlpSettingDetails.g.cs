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
    /// The full configuration details of a DLP setting.
    /// </summary>
    public partial class DlpSettingDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the DLP setting was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DlpSettingId. 
        /// <para>
        /// The ID of the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DlpSettingId { get; set; }

        /// <summary>
        /// Checks to see if the DlpSettingId property is set.
        /// </summary>
        internal bool IsSetDlpSettingId() => this.DlpSettingId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderConfig. 
        /// <para>
        /// The provider-specific configuration for the DLP integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderConfig ProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfig property is set.
        /// </summary>
        internal bool IsSetProviderConfig() => this.ProviderConfig != null;

        /// <summary>
        /// Gets and sets the property ProviderOutageAction. 
        /// <para>
        /// The behavior applied when the DLP provider is unreachable. Valid values are <c>ALLOW</c>,
        /// <c>WARN</c>, and <c>BLOCK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DlpAction ProviderOutageAction { get; set; }

        /// <summary>
        /// Checks to see if the ProviderOutageAction property is set.
        /// </summary>
        internal bool IsSetProviderOutageAction() => this.ProviderOutageAction != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of external DLP provider used for sensitivity label classification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DlpProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DLP setting. Valid values are <c>ACTIVE</c> and <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DlpSettingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the DLP setting was most recently updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
