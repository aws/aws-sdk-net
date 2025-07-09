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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the CancelZonalShift operation.
    /// Cancel a zonal shift in Amazon Application Recovery Controller. To cancel the zonal
    /// shift, specify the zonal shift ID.
    /// 
    ///  
    /// <para>
    /// A zonal shift can be one that you've started for a resource in your Amazon Web Services
    /// account in an Amazon Web Services Region, or it can be a zonal shift started by a
    /// practice run with zonal autoshift. 
    /// </para>
    /// </summary>
    public partial class CancelZonalShiftRequest : AmazonARCZonalShiftRequest
    {
        private string _zonalShiftId;

        /// <summary>
        /// Gets and sets the property ZonalShiftId. 
        /// <para>
        /// The internally-generated identifier of a zonal shift.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=36)]
        public string ZonalShiftId
        {
            get { return this._zonalShiftId; }
            set { this._zonalShiftId = value; }
        }

        // Check to see if ZonalShiftId property is set
        internal bool IsSetZonalShiftId()
        {
            return this._zonalShiftId != null;
        }

    }
}