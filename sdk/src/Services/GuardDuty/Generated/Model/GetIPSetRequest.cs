/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetIPSet operation.
    /// Retrieves the IPSet specified by the IPSet ID.
    /// </summary>
    public partial class GetIPSetRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private string _ipSetId;

        /// <summary>
        /// Gets and sets the property DetectorId. The detectorID that specifies the GuardDuty
        /// service whose IPSet you want to retrieve.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property IpSetId. The unique ID that specifies the IPSet that you
        /// want to describe.
        /// </summary>
        public string IpSetId
        {
            get { return this._ipSetId; }
            set { this._ipSetId = value; }
        }

        // Check to see if IpSetId property is set
        internal bool IsSetIpSetId()
        {
            return this._ipSetId != null;
        }

    }
}