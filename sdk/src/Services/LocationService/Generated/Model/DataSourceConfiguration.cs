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
    /// 
    ///  <note> 
    /// <para>
    /// By using Places, you agree that AWS may transmit your API queries to your selected
    /// third party provider for processing, which may be outside the AWS region you are currently
    /// using. 
    /// </para>
    ///  
    /// <para>
    /// Also, when using HERE as your data provider, you may not (a) use HERE Places for Asset
    /// Management, or (b) select the <code>Storage</code> option for the <code>IntendedUse</code>
    /// parameter when requesting Places in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service.
    /// </para>
    ///  </note>
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
        ///  </li> </ul> 
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