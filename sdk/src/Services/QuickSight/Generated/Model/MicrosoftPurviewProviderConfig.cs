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
    /// The full configuration for Microsoft Purview DLP integration, including the provider
    /// credentials and the label-action mappings that define the enforcement policy.
    /// </summary>
    public partial class MicrosoftPurviewProviderConfig
    {
        private MicrosoftPurviewCredentials _credentials;
        private List<LabelActionMapping> _labelActionMappings = AWSConfigs.InitializeCollections ? new List<LabelActionMapping>() : null;
        private DlpAction _unmappedAction;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials used to authenticate with Microsoft Purview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MicrosoftPurviewCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property LabelActionMappings. 
        /// <para>
        /// The mappings from Microsoft Purview sensitivity labels to enforcement actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<LabelActionMapping> LabelActionMappings
        {
            get { return this._labelActionMappings; }
            set { this._labelActionMappings = value; }
        }

        // Check to see if LabelActionMappings property is set
        internal bool IsSetLabelActionMappings()
        {
            return this._labelActionMappings != null && (this._labelActionMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnmappedAction. 
        /// <para>
        /// The default action to apply to content that has no sensitivity label or whose label
        /// is not mapped. Valid values are <c>ALLOW</c>, <c>BLOCK</c>, and <c>WARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DlpAction UnmappedAction
        {
            get { return this._unmappedAction; }
            set { this._unmappedAction = value; }
        }

        // Check to see if UnmappedAction property is set
        internal bool IsSetUnmappedAction()
        {
            return this._unmappedAction != null;
        }

    }
}