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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// The drift summary of the enabled control.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Control Tower expects the enabled control configuration to include
    /// all supported and governed Regions. If the enabled control differs from the expected
    /// configuration, it is defined to be in a state of drift. You can repair this drift
    /// by resetting the enabled control.
    /// </para>
    /// </summary>
    public partial class DriftStatusSummary
    {
        private DriftStatus _driftStatus;

        /// <summary>
        /// Gets and sets the property DriftStatus. 
        /// <para>
        ///  The drift status of the enabled control.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c>: The <c>enabledControl</c> deployed in this configuration doesn’t
        /// match the configuration that Amazon Web Services Control Tower expected. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The <c>enabledControl</c> deployed in this configuration matches
        /// the configuration that Amazon Web Services Control Tower expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKING</c>: Amazon Web Services Control Tower does not check drift for this
        /// enabled control. Drift is not supported for the control type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: Amazon Web Services Control Tower is not able to check the drift
        /// status for the enabled control. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DriftStatus DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

    }
}