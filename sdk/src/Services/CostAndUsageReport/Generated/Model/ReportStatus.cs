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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
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
namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// A two element dictionary with a <c>lastDelivery</c> and <c>lastStatus</c> key whose
    /// values describe the date and status of the last delivered report for a particular
    /// report definition.
    /// </summary>
    public partial class ReportStatus
    {
        private string _lastDelivery;
        private LastStatus _lastStatus;

        /// <summary>
        /// Gets and sets the property LastDelivery. 
        /// <para>
        /// A timestamp that gives the date of a report delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=20)]
        public string LastDelivery
        {
            get { return this._lastDelivery; }
            set { this._lastDelivery = value; }
        }

        // Check to see if LastDelivery property is set
        internal bool IsSetLastDelivery()
        {
            return this._lastDelivery != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// An enum that gives the status of a report delivery.
        /// </para>
        /// </summary>
        public LastStatus LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

    }
}