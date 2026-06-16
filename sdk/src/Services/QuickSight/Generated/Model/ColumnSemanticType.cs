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
    /// The semantic type information for a column in the new data preparation experience.
    /// </summary>
    public partial class ColumnSemanticType
    {
        private GeoSpatialDataRole _geographicalRole;

        /// <summary>
        /// Gets and sets the property GeographicalRole. 
        /// <para>
        /// The geographical role of the column in the new data preparation experience.
        /// </para>
        /// </summary>
        public GeoSpatialDataRole GeographicalRole
        {
            get { return this._geographicalRole; }
            set { this._geographicalRole = value; }
        }

        // Check to see if GeographicalRole property is set
        internal bool IsSetGeographicalRole()
        {
            return this._geographicalRole != null;
        }

    }
}