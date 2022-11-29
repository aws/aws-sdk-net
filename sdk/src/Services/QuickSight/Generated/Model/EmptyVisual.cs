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
    /// An empty visual.
    /// 
    ///  
    /// <para>
    /// Empty visuals are used in layouts but have not been configured to show any data. A
    /// new visual created in the Amazon QuickSight console is considered an <code>EmptyVisual</code>
    /// until a visual type is selected.
    /// </para>
    /// </summary>
    public partial class EmptyVisual
    {
        private List<VisualCustomAction> _actions = new List<VisualCustomAction>();
        private string _dataSetIdentifier;
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
        /// The data set that is used in the empty visual. Every visual requires a dataset to
        /// render.
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