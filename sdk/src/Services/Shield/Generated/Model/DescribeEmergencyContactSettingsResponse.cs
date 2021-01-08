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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// This is the response object from the DescribeEmergencyContactSettings operation.
    /// </summary>
    public partial class DescribeEmergencyContactSettingsResponse : AmazonWebServiceResponse
    {
        private List<EmergencyContact> _emergencyContactList = new List<EmergencyContact>();

        /// <summary>
        /// Gets and sets the property EmergencyContactList. 
        /// <para>
        /// A list of email addresses and phone numbers that the DDoS Response Team (DRT) can
        /// use to contact you if you have proactive engagement enabled, for escalations to the
        /// DRT and to initiate proactive customer support.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<EmergencyContact> EmergencyContactList
        {
            get { return this._emergencyContactList; }
            set { this._emergencyContactList = value; }
        }

        // Check to see if EmergencyContactList property is set
        internal bool IsSetEmergencyContactList()
        {
            return this._emergencyContactList != null && this._emergencyContactList.Count > 0; 
        }

    }
}