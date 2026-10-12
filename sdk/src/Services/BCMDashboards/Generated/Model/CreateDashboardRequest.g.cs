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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDashboard operation. Creates a new dashboard
    /// that can contain multiple widgets displaying cost and usage data. You can add custom
    /// widgets or use predefined widgets, arranging them in your preferred layout.
    /// </summary>
    public partial class CreateDashboardRequest : AmazonBCMDashboardsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the dashboard's purpose or contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dashboard. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags to apply to the dashboard resource for organization and management.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Widgets. 
        /// <para>
        /// An array of widget configurations that define the visualizations to be displayed in
        /// the dashboard. Each dashboard can contain up to 20 widgets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20)]
        public List<Widget> Widgets { get; set; } = AWSConfigs.InitializeCollections ? new List<Widget>() : null;

        /// <summary>
        /// Checks to see if the Widgets property is set.
        /// </summary>
        internal bool IsSetWidgets() => this.Widgets != null && (this.Widgets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
