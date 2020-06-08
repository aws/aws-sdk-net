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
    /// Container for the parameters to the AssociateProactiveEngagementDetails operation.
    /// Initializes proactive engagement and sets the list of contacts for the DDoS Response
    /// Team (DRT) to use. You must provide at least one phone number in the emergency contact
    /// list. 
    /// 
    ///  
    /// <para>
    /// After you have initialized proactive engagement using this call, to disable or enable
    /// proactive engagement, use the calls <code>DisableProactiveEngagement</code> and <code>EnableProactiveEngagement</code>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// This call defines the list of email addresses and phone numbers that the DDoS Response
    /// Team (DRT) can use to contact you for escalations to the DRT and to initiate proactive
    /// customer support.
    /// </para>
    ///  
    /// <para>
    /// The contacts that you provide in the request replace any contacts that were already
    /// defined. If you already have contacts defined and want to use them, retrieve the list
    /// using <code>DescribeEmergencyContactSettings</code> and then provide it to this call.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateProactiveEngagementDetailsRequest : AmazonShieldRequest
    {
        private List<EmergencyContact> _emergencyContactList = new List<EmergencyContact>();

        /// <summary>
        /// Gets and sets the property EmergencyContactList. 
        /// <para>
        /// A list of email addresses and phone numbers that the DDoS Response Team (DRT) can
        /// use to contact you for escalations to the DRT and to initiate proactive customer support.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To enable proactive engagement, the contact list must include at least one phone number.
        /// </para>
        ///  <note> 
        /// <para>
        /// The contacts that you provide here replace any contacts that were already defined.
        /// If you already have contacts defined and want to use them, retrieve the list using
        /// <code>DescribeEmergencyContactSettings</code> and then provide it here. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
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