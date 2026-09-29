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
    /// A flexible visualization type that allows engineers to create new custom charts in
    /// Quick Sight.
    /// </summary>
    public partial class PluginVisual
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of custom actions that are configured for a visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<VisualCustomAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<VisualCustomAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChartConfiguration. 
        /// <para>
        ///  A description of the plugin field wells and their persisted properties. 
        /// </para>
        /// </summary>
        public PluginVisualConfiguration ChartConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChartConfiguration property is set.
        /// </summary>
        internal bool IsSetChartConfiguration() => this.ChartConfiguration != null;

        /// <summary>
        /// Gets and sets the property PluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that reflects the plugin and version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PluginArn { get; set; }

        /// <summary>
        /// Checks to see if the PluginArn property is set.
        /// </summary>
        internal bool IsSetPluginArn() => this.PluginArn != null;

        /// <summary>
        /// Gets and sets the property Subtitle.
        /// </summary>
        public VisualSubtitleLabelOptions Subtitle { get; set; }

        /// <summary>
        /// Checks to see if the Subtitle property is set.
        /// </summary>
        internal bool IsSetSubtitle() => this.Subtitle != null;

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        public VisualTitleLabelOptions Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property VisualContentAltText. 
        /// <para>
        /// The alt text for the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VisualContentAltText { get; set; }

        /// <summary>
        /// Checks to see if the VisualContentAltText property is set.
        /// </summary>
        internal bool IsSetVisualContentAltText() => this.VisualContentAltText != null;

        /// <summary>
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The ID of the visual that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string VisualId { get; set; }

        /// <summary>
        /// Checks to see if the VisualId property is set.
        /// </summary>
        internal bool IsSetVisualId() => this.VisualId != null;
    }
}
