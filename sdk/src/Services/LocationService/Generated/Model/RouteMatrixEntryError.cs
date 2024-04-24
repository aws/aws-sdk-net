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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// An error corresponding to the calculation of a route between the <c>DeparturePosition</c>
    /// and <c>DestinationPosition</c>.
    /// 
    ///  
    /// <para>
    /// The error code can be one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>RouteNotFound</c> - Unable to find a valid route with the given parameters.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>RouteTooLong</c> - Route calculation went beyond the maximum size of a route and
    /// was terminated before completion.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>PositionsNotFound</c> - One or more of the input positions were not found on the
    /// route network.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>DestinationPositionNotFound</c> - The destination position was not found on the
    /// route network.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>DeparturePositionNotFound</c> - The departure position was not found on the route
    /// network.
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>OtherValidationError</c> - The given inputs were not valid or a route was not
    /// found. More information is given in the error <c>Message</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RouteMatrixEntryError
    {
        private RouteMatrixErrorCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The type of error which occurred for the route calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteMatrixErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the error that occurred for the route calculation.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}