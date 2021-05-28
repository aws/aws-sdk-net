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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Specifies the data storage option chosen for requesting Places.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        private IntendedUse _intendedUse;

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        /// Specifies how the results of an operation will be stored by the caller. 
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SingleUse</code> specifies that the results won't be stored. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Storage</code> specifies that the result can be cached or stored in a database.
        /// </para>
        ///  <important> 
        /// <para>
        /// Place index resources using HERE as a data provider can't be configured to store results
        /// for locations in Japan when choosing <code>Storage</code> for the <code>IntendedUse</code>
        /// parameter.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// Default value: <code>SingleUse</code> 
        /// </para>
        /// </summary>
        public IntendedUse IntendedUse
        {
            get { return this._intendedUse; }
            set { this._intendedUse = value; }
        }

        // Check to see if IntendedUse property is set
        internal bool IsSetIntendedUse()
        {
            return this._intendedUse != null;
        }

    }
}