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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A label used to group or categorize pricing dimensions, such as by region or SageMaker
    /// option.
    /// </summary>
    public partial class DimensionLabel
    {
        private string _displayName;
        private DimensionLabelType _labelType;
        private string _labelValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable display name of the label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property LabelType. 
        /// <para>
        /// The type of the dimension label, such as <c>Region</c> or <c>SagemakerOption</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionLabelType LabelType
        {
            get { return this._labelType; }
            set { this._labelType = value; }
        }

        // Check to see if LabelType property is set
        internal bool IsSetLabelType()
        {
            return this._labelType != null;
        }

        /// <summary>
        /// Gets and sets the property LabelValue. 
        /// <para>
        /// The value used to group dimensions together.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string LabelValue
        {
            get { return this._labelValue; }
            set { this._labelValue = value; }
        }

        // Check to see if LabelValue property is set
        internal bool IsSetLabelValue()
        {
            return this._labelValue != null;
        }

    }
}