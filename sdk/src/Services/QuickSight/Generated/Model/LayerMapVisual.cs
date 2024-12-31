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
    /// A layer map visual.
    /// </summary>
    public partial class LayerMapVisual
    {
        private GeospatialLayerMapConfiguration _chartConfiguration;
        private string _dataSetIdentifier;
        private VisualSubtitleLabelOptions _subtitle;
        private VisualTitleLabelOptions _title;
        private string _visualContentAltText;
        private string _visualId;

        /// <summary>
        /// Gets and sets the property ChartConfiguration. 
        /// <para>
        /// The configuration settings of the visual.
        /// </para>
        /// </summary>
        public GeospatialLayerMapConfiguration ChartConfiguration
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
        /// Gets and sets the property DataSetIdentifier. 
        /// <para>
        /// The dataset that is used to create the layer map visual. You can't create a visual
        /// without a dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DataSetIdentifier
        {
            get { return this._dataSetIdentifier; }
            set { this._dataSetIdentifier = value; }
        }

        // Check to see if DataSetIdentifier property is set
        internal bool IsSetDataSetIdentifier()
        {
            return this._dataSetIdentifier != null;
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
        /// The ID of the visual.
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