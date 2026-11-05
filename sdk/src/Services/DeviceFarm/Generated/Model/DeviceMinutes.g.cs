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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the total (metered or unmetered) minutes used by the resource to run tests.
    /// Contains the sum of minutes consumed by all children.
    /// </summary>
    public partial class DeviceMinutes
    {
        /// <summary>
        /// Gets and sets the property Metered. 
        /// <para>
        /// When specified, represents only the sum of metered minutes used by the resource to
        /// run tests.
        /// </para>
        /// </summary>
        public double? Metered { get; set; }

        /// <summary>
        /// Checks to see if the Metered property is set.
        /// </summary>
        internal bool IsSetMetered() => this.Metered.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// When specified, represents the total minutes used by the resource to run tests.
        /// </para>
        /// </summary>
        public double? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property Unmetered. 
        /// <para>
        /// When specified, represents only the sum of unmetered minutes used by the resource
        /// to run tests.
        /// </para>
        /// </summary>
        public double? Unmetered { get; set; }

        /// <summary>
        /// Checks to see if the Unmetered property is set.
        /// </summary>
        internal bool IsSetUnmetered() => this.Unmetered.HasValue;
    }
}
