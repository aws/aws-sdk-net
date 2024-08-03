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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The row filter configuration details.
    /// </summary>
    public partial class RowFilterConfiguration
    {
        private RowFilter _rowFilter;
        private bool? _sensitive;

        /// <summary>
        /// Gets and sets the property RowFilter. 
        /// <para>
        /// The row filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RowFilter RowFilter
        {
            get { return this._rowFilter; }
            set { this._rowFilter = value; }
        }

        // Check to see if RowFilter property is set
        internal bool IsSetRowFilter()
        {
            return this._rowFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// Specifies whether the row filter is sensitive.
        /// </para>
        /// </summary>
        public bool? Sensitive
        {
            get { return this._sensitive; }
            set { this._sensitive = value; }
        }

        // Check to see if Sensitive property is set
        internal bool IsSetSensitive()
        {
            return this._sensitive.HasValue; 
        }

    }
}