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
    /// The configuration that controls field customization options available to dashboard
    /// readers for a visual.
    /// </summary>
    public partial class VisualCustomizationFieldsConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdditionalFields. 
        /// <para>
        /// The additional dataset fields available for dashboard readers to customize the visual
        /// with, beyond the fields already configured on the visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public List<ColumnIdentifier> AdditionalFields { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnIdentifier>() : null;

        /// <summary>
        /// Checks to see if the AdditionalFields property is set.
        /// </summary>
        internal bool IsSetAdditionalFields() => this.AdditionalFields != null && (this.AdditionalFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether dashboard readers can customize fields for this visual. This option
        /// is <c>ENABLED</c> by default.
        /// </para>
        /// </summary>
        public DashboardCustomizationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
