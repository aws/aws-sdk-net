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
    /// The default options that correspond to the filter control type of a <c>DateTimePicker</c>.
    /// </summary>
    public partial class DefaultDateTimePickerControlOptions
    {
        private CommitMode _commitMode;
        private DateTimePickerControlDisplayOptions _displayOptions;
        private SheetControlDateTimePickerType _type;

        /// <summary>
        /// Gets and sets the property CommitMode. 
        /// <para>
        /// The visibility configuration of the Apply button on a <c>DateTimePickerControl</c>.
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
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public DateTimePickerControlDisplayOptions DisplayOptions
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The date time picker type of the <c>DefaultDateTimePickerControlOptions</c>. Choose
        /// one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE_VALUED</c>: The filter condition is a fixed date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DATE_RANGE</c>: The filter condition is a date time range.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetControlDateTimePickerType Type
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