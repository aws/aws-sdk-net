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
    /// The default options that correspond to the <c>Dropdown</c> filter control type.
    /// </summary>
    public partial class DefaultFilterDropDownControlOptions
    {
        private CommitMode _commitMode;
        private List<ControlSortConfiguration> _controlSortConfigurations = AWSConfigs.InitializeCollections ? new List<ControlSortConfiguration>() : null;
        private DropDownControlDisplayOptions _displayOptions;
        private FilterSelectableValues _selectableValues;
        private SheetControlListType _type;

        /// <summary>
        /// Gets and sets the property CommitMode. 
        /// <para>
        /// The visibility configuration of the Apply button on a <c>FilterDropDownControl</c>.
        /// </para>
        /// </summary>
        public CommitMode CommitMode
        {
            get { return this._commitMode; }
            set { this._commitMode = value; }
        }

        // Check to see if CommitMode property is set
        internal bool IsSetCommitMode()
        {
            return this._commitMode != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSortConfigurations. 
        /// <para>
        /// The sort configuration for the values displayed in the control. Only one sort configuration
        /// can be applied per control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<ControlSortConfiguration> ControlSortConfigurations
        {
            get { return this._controlSortConfigurations; }
            set { this._controlSortConfigurations = value; }
        }

        // Check to see if ControlSortConfigurations property is set
        internal bool IsSetControlSortConfigurations()
        {
            return this._controlSortConfigurations != null && (this._controlSortConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public DropDownControlDisplayOptions DisplayOptions
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>FilterDropDownControl</c>. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MULTI_SELECT</c>: The user can select multiple entries from a dropdown menu.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_SELECT</c>: The user can select a single entry from a dropdown menu.
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