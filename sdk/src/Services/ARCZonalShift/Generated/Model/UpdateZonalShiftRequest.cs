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

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateZonalShift operation.
    /// Update an active zonal shift in Amazon Route 53 Application Recovery Controller in
    /// your AWS account. You can update a zonal shift to set a new expiration, or edit or
    /// replace the comment for the zonal shift.
    /// </summary>
    public partial class UpdateZonalShiftRequest : AmazonARCZonalShiftRequest
    {
        private string _comment;
        private string _expiresIn;
        private string _zonalShiftId;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment that you enter about the zonal shift. Only the latest comment is retained;
        /// no comment history is maintained. A new comment overwrites any existing comment string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The length of time that you want a zonal shift to be active, which Route 53 ARC converts
        /// to an expiry time (expiration time). Zonal shifts are temporary. You can set a zonal
        /// shift to be active initially for up to three days (72 hours).
        /// </para>
        ///  
        /// <para>
        /// If you want to still keep traffic away from an Availability Zone, you can update the
        /// zonal shift and set a new expiration. You can also cancel a zonal shift, before it
        /// expires, for example, if you're ready to restore traffic to the Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// To set a length of time for a zonal shift to be active, specify a whole number, and
        /// then one of the following, with no space:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A lowercase letter m:</b> To specify that the value is in minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A lowercase letter h:</b> To specify that the value is in hours.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example: <code>20h</code> means the zonal shift expires in 20 hours. <code>120m</code>
        /// means the zonal shift expires in 120 minutes (2 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string ExpiresIn
        {
            get { return this._expiresIn; }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalShiftId. 
        /// <para>
        /// The identifier of a zonal shift.
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