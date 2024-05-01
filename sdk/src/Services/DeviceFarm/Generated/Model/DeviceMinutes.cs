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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private double? _metered;
        private double? _total;
        private double? _unmetered;

        /// <summary>
        /// Gets and sets the property Metered. 
        /// <para>
        /// When specified, represents only the sum of metered minutes used by the resource to
        /// run tests.
        /// </para>
        /// </summary>
        public double? Metered
        {
            get { return this._metered; }
            set { this._metered = value; }
        }

        // Check to see if Metered property is set
        internal bool IsSetMetered()
        {
            return this._metered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// When specified, represents the total minutes used by the resource to run tests.
        /// </para>
        /// </summary>
        public double? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unmetered. 
        /// <para>
        /// When specified, represents only the sum of unmetered minutes used by the resource
        /// to run tests.
        /// </para>
        /// </summary>
        public double? Unmetered
        {
            get { return this._unmetered; }
            set { this._unmetered = value; }
        }

        // Check to see if Unmetered property is set
        internal bool IsSetUnmetered()
        {
            return this._unmetered.HasValue; 
        }

    }
}