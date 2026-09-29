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
    /// A control from a date filter that is used to specify date and time.
    /// </summary>
    public partial class FilterDateTimePickerControl
    {
        /// <summary>
        /// Gets and sets the property CommitMode. 
        /// <para>
        /// The visibility configurationof the Apply button on a <c>DateTimePickerControl</c>.
        /// </para>
        /// </summary>
        public CommitMode CommitMode { get; set; }

        /// <summary>
        /// Checks to see if the CommitMode property is set.
        /// </summary>
        internal bool IsSetCommitMode() => this.CommitMode != null;

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
        public DateTimePickerControlDisplayOptions DisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the DisplayOptions property is set.
        /// </summary>
        internal bool IsSetDisplayOptions() => this.DisplayOptions != null;

        /// <summary>
        /// Gets and sets the property FilterControlId. 
        /// <para>
        /// The ID of the <c>FilterDateTimePickerControl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FilterControlId { get; set; }

        /// <summary>
        /// Checks to see if the FilterControlId property is set.
        /// </summary>
        internal bool IsSetFilterControlId() => this.FilterControlId != null;

        /// <summary>
        /// Gets and sets the property SourceFilterId. 
        /// <para>
        /// The source filter ID of the <c>FilterDateTimePickerControl</c>.
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
        /// The title of the <c>FilterDateTimePickerControl</c>.
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
        public SheetControlDateTimePickerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
