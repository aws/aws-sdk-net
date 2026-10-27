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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.PI.Model
{
    /// <summary>
    /// An object that describes the details for a specified dimension.
    /// </summary>
    public partial class DimensionKeyDetail
    {
        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The full name of the dimension. The full name includes the group name and key name.
        /// The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.query.statement</c> (Amazon DocumentDB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql.statement</c> (Amazon RDS and Aurora)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dimension detail data. Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The dimension detail data is ready to be retrieved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESSING</c> - The dimension detail data isn't ready to be retrieved because
        /// more processing time is required. If the requested detail data has the status <c>PROCESSING</c>,
        /// Performance Insights returns the truncated query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNAVAILABLE</c> - The dimension detail data could not be collected successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DetailStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the dimension detail data. Depending on the return status, this value
        /// is either the full or truncated SQL query for the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.query.statement</c> (Amazon DocumentDB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql.statement</c> (Amazon RDS and Aurora)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
