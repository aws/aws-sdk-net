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
    /// The general configuration of a column.
    /// </summary>
    public partial class ColumnConfiguration
    {
        private ColumnIdentifier _column;
        private FormatConfiguration _formatConfiguration;
        private ColumnRole _role;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property FormatConfiguration. 
        /// <para>
        /// The format configuration of a column.
        /// </para>
        /// </summary>
        public FormatConfiguration FormatConfiguration
        {
            get { return this._formatConfiguration; }
            set { this._formatConfiguration = value; }
        }

        // Check to see if FormatConfiguration property is set
        internal bool IsSetFormatConfiguration()
        {
            return this._formatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the column.
        /// </para>
        /// </summary>
        public ColumnRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}