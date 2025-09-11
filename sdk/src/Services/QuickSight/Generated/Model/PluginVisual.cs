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
    /// A flexible visualization type that allows engineers to create new custom charts in
    /// QuickSight.
    /// </summary>
    public partial class PluginVisual
    {
        private List<VisualCustomAction> _actions = AWSConfigs.InitializeCollections ? new List<VisualCustomAction>() : null;
        private PluginVisualConfiguration _chartConfiguration;
        private string _pluginArn;
        private VisualSubtitleLabelOptions _subtitle;
        private VisualTitleLabelOptions _title;
        private string _visualContentAltText;
        private string _visualId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of custom actions that are configured for a visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<VisualCustomAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChartConfiguration. 
        /// <para>
        ///  A description of the plugin field wells and their persisted properties. 
        /// </para>
        /// </summary>
        public PluginVisualConfiguration ChartConfiguration
        {
            get { return this._chartConfiguration; }
            set { this._chartConfiguration = value; }
        }

        // Check to see if ChartConfiguration property is set
        internal bool IsSetChartConfiguration()
        {
            return this._chartConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that reflects the plugin and version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PluginArn
        {
            get { return this._pluginArn; }
            set { this._pluginArn = value; }
        }

        // Check to see if PluginArn property is set
        internal bool IsSetPluginArn()
        {
            return this._pluginArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subtitle.
        /// </summary>
        public VisualSubtitleLabelOptions Subtitle
        {
            get { return this._subtitle; }
            set { this._subtitle = value; }
        }

        // Check to see if Subtitle property is set
        internal bool IsSetSubtitle()
        {
            return this._subtitle != null;
        }

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        public VisualTitleLabelOptions Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property VisualContentAltText. 
        /// <para>
        /// The alt text for the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VisualContentAltText
        {
            get { return this._visualContentAltText; }
            set { this._visualContentAltText = value; }
        }

        // Check to see if VisualContentAltText property is set
        internal bool IsSetVisualContentAltText()
        {
            return this._visualContentAltText != null;
        }

        /// <summary>
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The ID of the visual that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string VisualId
        {
            get { return this._visualId; }
            set { this._visualId = value; }
        }

        // Check to see if VisualId property is set
        internal bool IsSetVisualId()
        {
            return this._visualId != null;
        }

    }
}