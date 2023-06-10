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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DimensionMapping
    {
        private string _destinationColumn;
        private string _sourceColumn;

        /// <summary>
        /// Gets and sets the property DestinationColumn. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DestinationColumn
        {
            get { return this._destinationColumn; }
            set { this._destinationColumn = value; }
        }

        // Check to see if DestinationColumn property is set
        internal bool IsSetDestinationColumn()
        {
            return this._destinationColumn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceColumn.
        /// </summary>
        [AWSProperty(Min=1)]
        public string SourceColumn
        {
            get { return this._sourceColumn; }
            set { this._sourceColumn = value; }
        }

        // Check to see if SourceColumn property is set
        internal bool IsSetSourceColumn()
        {
            return this._sourceColumn != null;
        }

    }
}