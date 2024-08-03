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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The configuration settings for the ID mapping table.
    /// </summary>
    public partial class IdMappingConfig
    {
        private bool? _allowUseAsDimensionColumn;

        /// <summary>
        /// Gets and sets the property AllowUseAsDimensionColumn. 
        /// <para>
        /// An indicator as to whether you can use your column as a dimension column in the ID
        /// mapping table (<c>TRUE</c>) or not (<c>FALSE</c>).
        /// </para>
        ///  
        /// <para>
        /// Default is <c>FALSE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AllowUseAsDimensionColumn
        {
            get { return this._allowUseAsDimensionColumn; }
            set { this._allowUseAsDimensionColumn = value; }
        }

        // Check to see if AllowUseAsDimensionColumn property is set
        internal bool IsSetAllowUseAsDimensionColumn()
        {
            return this._allowUseAsDimensionColumn.HasValue; 
        }

    }
}