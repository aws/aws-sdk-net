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
    /// A control to display a list of buttons or boxes. This is used to select either a single
    /// value or multiple values.
    /// </summary>
    public partial class FilterListControl
    {
        /// <summary>
        /// Gets and sets the property CascadingControlConfiguration. 
        /// <para>
        /// The values that are displayed in a control can be configured to only show values that
        /// are valid based on what's selected in other controls.
        /// </para>
        /// </summary>
        public CascadingControlConfiguration CascadingControlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CascadingControlConfiguration property is set.
        /// </summary>
        internal bool IsSetCascadingControlConfiguration() => this.CascadingControlConfiguration != null;

        /// <summary>
        /// Gets and sets the property ControlSortConfigurations. 
        /// <para>
        /// The sort configuration for the values displayed in the control. Only one sort configuration
        /// can be applied per control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<ControlSortConfiguration> ControlSortConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlSortConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ControlSortConfigurations property is set.
        /// </summary>
        internal bool IsSetControlSortConfigurations() => this.ControlSortConfigurations != null && (this.ControlSortConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ControlTitleFormatText. 
        /// <para>
        /// The title text format configuration for the control.
        /// </para>
        /// </summary>
        public ControlTitleFormatText ControlTitleFormatText { get; set; }

        /// <summary>
        /// Checks to see if the ControlTitleFormatText property is set.
        /// </summary>
        internal bool IsSetControlTitleFormatText() => this.ControlTitleFormatText != null;

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public ListControlDisplayOptions DisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOptions property is set.
        /// </summary>
        internal bool IsSetDisplayOptions() => this.DisplayOptions != null;

        /// <summary>
        /// Gets and sets the property FilterControlId. 
        /// <para>
        /// The ID of the <c>FilterListControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FilterControlId { get; set; }

        /// <summary>
        /// Checks to see if the FilterControlId property is set.
        /// </summary>
        internal bool IsSetFilterControlId() => this.FilterControlId != null;

        /// <summary>
        /// Gets and sets the property SelectableValues. 
        /// <para>
        /// A list of selectable values that are used in a control.
        /// </para>
        /// </summary>
        public FilterSelectableValues SelectableValues { get; set; }

        /// <summary>
        /// Checks to see if the SelectableValues property is set.
        /// </summary>
        internal bool IsSetSelectableValues() => this.SelectableValues != null;

        /// <summary>
        /// Gets and sets the property SourceFilterId. 
        /// <para>
        /// The source filter ID of the <c>FilterListControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SourceFilterId { get; set; }

        /// <summary>
        /// Checks to see if the SourceFilterId property is set.
        /// </summary>
        internal bool IsSetSourceFilterId() => this.SourceFilterId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <c>FilterListControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>FilterListControl</c>. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MULTI_SELECT</c>: The user can select multiple entries from the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_SELECT</c>: The user can select a single entry from the list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetControlListType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
