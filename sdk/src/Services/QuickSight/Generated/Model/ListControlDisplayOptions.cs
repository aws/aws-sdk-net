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
    /// The display options of a control.
    /// </summary>
    public partial class ListControlDisplayOptions
    {
        private ListControlSearchOptions _searchOptions;
        private ListControlSelectAllOptions _selectAllOptions;
        private LabelOptions _titleOptions;

        /// <summary>
        /// Gets and sets the property SearchOptions. 
        /// <para>
        /// The configuration of the search options in a list control.
        /// </para>
        /// </summary>
        public ListControlSearchOptions SearchOptions
        {
            get { return this._searchOptions; }
            set { this._searchOptions = value; }
        }

        // Check to see if SearchOptions property is set
        internal bool IsSetSearchOptions()
        {
            return this._searchOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SelectAllOptions. 
        /// <para>
        /// The configuration of the <code>Select all</code> options in a list control.
        /// </para>
        /// </summary>
        public ListControlSelectAllOptions SelectAllOptions
        {
            get { return this._selectAllOptions; }
            set { this._selectAllOptions = value; }
        }

        // Check to see if SelectAllOptions property is set
        internal bool IsSetSelectAllOptions()
        {
            return this._selectAllOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TitleOptions. 
        /// <para>
        /// The options to configure the title visibility, name, and font size.
        /// </para>
        /// </summary>
        public LabelOptions TitleOptions
        {
            get { return this._titleOptions; }
            set { this._titleOptions = value; }
        }

        // Check to see if TitleOptions property is set
        internal bool IsSetTitleOptions()
        {
            return this._titleOptions != null;
        }

    }
}