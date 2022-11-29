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
    /// The option that determines the decimal places configuration.
    /// </summary>
    public partial class DecimalPlacesConfiguration
    {
        private long? _decimalPlaces;

        /// <summary>
        /// Gets and sets the property DecimalPlaces. 
        /// <para>
        /// The values of the decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public long DecimalPlaces
        {
            get { return this._decimalPlaces.GetValueOrDefault(); }
            set { this._decimalPlaces = value; }
        }

        // Check to see if DecimalPlaces property is set
        internal bool IsSetDecimalPlaces()
        {
            return this._decimalPlaces.HasValue; 
        }

    }
}