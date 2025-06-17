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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetAdministratorAccount operation.
    /// Provides the details of the GuardDuty administrator account associated with the current
    /// GuardDuty member account.
    /// 
    ///  
    /// <para>
    /// Based on the type of account that runs this API, the following list shows how the
    /// API behavior varies:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When the GuardDuty administrator account runs this API, it will return success (<c>HTTP
    /// 200</c>) but no content.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When a member account runs this API, it will return the details of the GuardDuty administrator
    /// account that is associated with this calling member account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When an individual account (not associated with an organization) runs this API, it
    /// will return success (<c>HTTP 200</c>) but no content.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetAdministratorAccountRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector of the GuardDuty member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

    }
}