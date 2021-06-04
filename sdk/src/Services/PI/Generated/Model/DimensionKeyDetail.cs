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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// An object that describes the details for a specified dimension.
    /// </summary>
    public partial class DimensionKeyDetail
    {
        private string _dimension;
        private DetailStatus _status;
        private string _value;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The full name of the dimension. The full name includes the group name and key name.
        /// The only valid value is <code>db.sql.statement</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dimension detail data. Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The dimension detail data is ready to be retrieved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROCESSING</code> - The dimension detail data isn't ready to be retrieved because
        /// more processing time is required. If the requested detail data for <code>db.sql.statement</code>
        /// has the status <code>PROCESSING</code>, Performance Insights returns the truncated
        /// query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNAVAILABLE</code> - The dimension detail data could not be collected successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DetailStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the dimension detail data. For the <code>db.sql.statement</code> dimension,
        /// this value is either the full or truncated SQL query, depending on the return status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}