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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetMemberDetectors operation.
    /// Describes which data sources are enabled for the member account's detector.
    /// </summary>
    public partial class GetMemberDetectorsRequest : AmazonGuardDutyRequest
    {
        private List<string> _accountIds = new List<string>();
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The account ID of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID for the administrator account.
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