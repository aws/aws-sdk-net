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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies skewed values in a table. Skewed values are those that occur with very high
    /// frequency.
    /// </summary>
    public partial class SkewedInfo
    {
        private List<string> _skewedColumnNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _skewedColumnValueLocationMaps = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _skewedColumnValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SkewedColumnNames. 
        /// <para>
        /// A list of names of columns that contain skewed values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SkewedColumnNames
        {
            get { return this._skewedColumnNames; }
            set { this._skewedColumnNames = value; }
        }

        // Check to see if SkewedColumnNames property is set
        internal bool IsSetSkewedColumnNames()
        {
            return this._skewedColumnNames != null && (this._skewedColumnNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkewedColumnValueLocationMaps. 
        /// <para>
        /// A mapping of skewed values to the columns that contain them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SkewedColumnValueLocationMaps
        {
            get { return this._skewedColumnValueLocationMaps; }
            set { this._skewedColumnValueLocationMaps = value; }
        }

        // Check to see if SkewedColumnValueLocationMaps property is set
        internal bool IsSetSkewedColumnValueLocationMaps()
        {
            return this._skewedColumnValueLocationMaps != null && (this._skewedColumnValueLocationMaps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkewedColumnValues. 
        /// <para>
        /// A list of values that appear so frequently as to be considered skewed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SkewedColumnValues
        {
            get { return this._skewedColumnValues; }
            set { this._skewedColumnValues = value; }
        }

        // Check to see if SkewedColumnValues property is set
        internal bool IsSetSkewedColumnValues()
        {
            return this._skewedColumnValues != null && (this._skewedColumnValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}