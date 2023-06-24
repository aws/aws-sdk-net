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
    /// A control to display a list of buttons or boxes. This is used to select either a single
    /// value or multiple values.
    /// </summary>
    public partial class FilterListControl
    {
        private CascadingControlConfiguration _cascadingControlConfiguration;
        private ListControlDisplayOptions _displayOptions;
        private string _filterControlId;
        private FilterSelectableValues _selectableValues;
        private string _sourceFilterId;
        private string _title;
        private SheetControlListType _type;

        /// <summary>
        /// Gets and sets the property CascadingControlConfiguration. 
        /// <para>
        /// The values that are displayed in a control can be configured to only show values that
        /// are valid based on what's selected in other controls.
        /// </para>
        /// </summary>
        public CascadingControlConfiguration CascadingControlConfiguration
        {
            get { return this._cascadingControlConfiguration; }
            set { this._cascadingControlConfiguration = value; }
        }

        // Check to see if CascadingControlConfiguration property is set
        internal bool IsSetCascadingControlConfiguration()
        {
            return this._cascadingControlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public ListControlDisplayOptions DisplayOptions
        {
            get { return this._displayOptions; }
            set { this._displayOptions = value; }
        }

        // Check to see if DisplayOptions property is set
        internal bool IsSetDisplayOptions()
        {
            return this._displayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FilterControlId. 
        /// <para>
        /// The ID of the <code>FilterListControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterControlId
        {
            get { return this._filterControlId; }
            set { this._filterControlId = value; }
        }

        // Check to see if FilterControlId property is set
        internal bool IsSetFilterControlId()
        {
            return this._filterControlId != null;
        }

        /// <summary>
        /// Gets and sets the property SelectableValues. 
        /// <para>
        /// A list of selectable values that are used in a control.
        /// </para>
        /// </summary>
        public FilterSelectableValues SelectableValues
        {
            get { return this._selectableValues; }
            set { this._selectableValues = value; }
        }

        // Check to see if SelectableValues property is set
        internal bool IsSetSelectableValues()
        {
            return this._selectableValues != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFilterId. 
        /// <para>
        /// The source filter ID of the <code>FilterListControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SourceFilterId
        {
            get { return this._sourceFilterId; }
            set { this._sourceFilterId = value; }
        }

        // Check to see if SourceFilterId property is set
        internal bool IsSetSourceFilterId()
        {
            return this._sourceFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <code>FilterListControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Title
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of <code>FilterListControl</code>. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MULTI_SELECT</code>: The user can select multiple entries from the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_SELECT</code>: The user can select a single entry from the list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetControlListType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}