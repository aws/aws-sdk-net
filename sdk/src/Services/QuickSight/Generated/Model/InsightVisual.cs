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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An insight visual.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/computational-insights.html">Working
    /// with insights</a> in the <i>Amazon QuickSight User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InsightVisual
    {
        private List<VisualCustomAction> _actions = new List<VisualCustomAction>();
        private string _dataSetIdentifier;
        private InsightConfiguration _insightConfiguration;
        private VisualSubtitleLabelOptions _subtitle;
        private VisualTitleLabelOptions _title;
        private string _visualId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of custom actions that are configured for a visual.
        /// </para>
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
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSetIdentifier. 
        /// <para>
        /// The dataset that is used in the insight visual.
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
        /// Gets and sets the property InsightConfiguration. 
        /// <para>
        /// The configuration of an insight visual.
        /// </para>
        /// </summary>
        public InsightConfiguration InsightConfiguration
        {
            get { return this._insightConfiguration; }
            set { this._insightConfiguration = value; }
        }

        // Check to see if InsightConfiguration property is set
        internal bool IsSetInsightConfiguration()
        {
            return this._insightConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// The subtitle that is displayed on the visual.
        /// </para>
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
        /// <para>
        /// The title that is displayed on the visual.
        /// </para>
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
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The unique identifier of a visual. This identifier must be unique within the context
        /// of a dashboard, template, or analysis. Two dashboards, analyses, or templates can
        /// have visuals with the same identifiers.
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