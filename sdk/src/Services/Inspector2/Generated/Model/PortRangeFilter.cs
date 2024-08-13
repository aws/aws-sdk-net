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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that describes the details of a port range filter.
    /// </summary>
    public partial class PortRangeFilter
    {
        private int? _beginInclusive;
        private int? _endInclusive;

        /// <summary>
        /// Gets and sets the property BeginInclusive. 
        /// <para>
        /// The port number the port range begins at.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? BeginInclusive
        {
            get { return this._beginInclusive; }
            set { this._beginInclusive = value; }
        }

        // Check to see if BeginInclusive property is set
        internal bool IsSetBeginInclusive()
        {
            return this._beginInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndInclusive. 
        /// <para>
        /// The port number the port range ends at.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? EndInclusive
        {
            get { return this._endInclusive; }
            set { this._endInclusive = value; }
        }

        // Check to see if EndInclusive property is set
        internal bool IsSetEndInclusive()
        {
            return this._endInclusive.HasValue; 
        }

    }
}