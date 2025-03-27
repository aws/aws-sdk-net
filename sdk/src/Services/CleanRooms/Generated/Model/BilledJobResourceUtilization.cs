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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Information related to the utilization of resources that have been billed or charged
    /// for in a given context, such as a protected job.
    /// </summary>
    public partial class BilledJobResourceUtilization
    {
        private double? _units;

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        ///  The number of Clean Rooms Processing Unit (CRPU) hours that have been billed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Units
        {
            get { return this._units; }
            set { this._units = value; }
        }

        // Check to see if Units property is set
        internal bool IsSetUnits()
        {
            return this._units.HasValue; 
        }

    }
}