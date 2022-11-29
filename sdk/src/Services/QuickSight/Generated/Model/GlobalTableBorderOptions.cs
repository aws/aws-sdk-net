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
    /// Determines the border options for a table visual.
    /// </summary>
    public partial class GlobalTableBorderOptions
    {
        private TableSideBorderOptions _sideSpecificBorder;
        private TableBorderOptions _uniformBorder;

        /// <summary>
        /// Gets and sets the property SideSpecificBorder. 
        /// <para>
        /// Determines the options for side specific border.
        /// </para>
        /// </summary>
        public TableSideBorderOptions SideSpecificBorder
        {
            get { return this._sideSpecificBorder; }
            set { this._sideSpecificBorder = value; }
        }

        // Check to see if SideSpecificBorder property is set
        internal bool IsSetSideSpecificBorder()
        {
            return this._sideSpecificBorder != null;
        }

        /// <summary>
        /// Gets and sets the property UniformBorder. 
        /// <para>
        /// Determines the options for uniform border.
        /// </para>
        /// </summary>
        public TableBorderOptions UniformBorder
        {
            get { return this._uniformBorder; }
            set { this._uniformBorder = value; }
        }

        // Check to see if UniformBorder property is set
        internal bool IsSetUniformBorder()
        {
            return this._uniformBorder != null;
        }

    }
}