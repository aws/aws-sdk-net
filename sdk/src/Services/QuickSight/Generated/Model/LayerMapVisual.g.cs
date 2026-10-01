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
    /// A layer map visual.
    /// </summary>
    public partial class LayerMapVisual
    {
        /// <summary>
        /// Gets and sets the property ChartConfiguration. 
        /// <para>
        /// The configuration settings of the visual.
        /// </para>
        /// </summary>
        public GeospatialLayerMapConfiguration ChartConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChartConfiguration property is set.
        /// </summary>
        internal bool IsSetChartConfiguration() => this.ChartConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSetIdentifier. 
        /// <para>
        /// The dataset that is used to create the layer map visual. You can't create a visual
        /// without a dataset or a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DataSetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DataSetIdentifier property is set.
        /// </summary>
        internal bool IsSetDataSetIdentifier() => this.DataSetIdentifier != null;

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
        /// Gets and sets the property TopicIdentifier. 
        /// <para>
        /// The topic that is used in the layer map visual. You can't create a visual without
        /// a dataset or a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TopicIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TopicIdentifier property is set.
        /// </summary>
        internal bool IsSetTopicIdentifier() => this.TopicIdentifier != null;

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
        /// The ID of the visual.
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
