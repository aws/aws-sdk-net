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
    /// The full configuration details of a DLP setting.
    /// </summary>
    public partial class DlpSettingDetails
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _dlpSettingId;
        private string _name;
        private ProviderConfig _providerConfig;
        private DlpAction _providerOutageAction;
        private DlpProviderType _providerType;
        private DlpSettingStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DLP setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the DLP setting was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DlpSettingId. 
        /// <para>
        /// The ID of the DLP setting.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the DLP setting.
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
        /// The provider-specific configuration for the DLP integration.
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
        /// The behavior applied when the DLP provider is unreachable. Valid values are <c>ALLOW</c>,
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
        /// The type of external DLP provider used for sensitivity label classification.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DLP setting. Valid values are <c>ACTIVE</c> and <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DlpSettingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the DLP setting was most recently updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}