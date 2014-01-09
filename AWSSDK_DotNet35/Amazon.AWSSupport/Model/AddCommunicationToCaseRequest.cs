/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the AddCommunicationToCase operation.
    /// <para>Adds additional customer communication to an AWS Support case. You use the <c>CaseId</c> value to identify the case to add
    /// communication to. You can list a set of email addresses to copy on the communication using the <c>CcEmailAddresses</c> value. The
    /// <c>CommunicationBody</c> value contains the text of the communication.</para> <para>The response indicates the success or failure of the
    /// request.</para> <para>This operation implements a subset of the behavior on the AWS Support <a href="https://aws.amazon.com/support" >Your
    /// Support Cases</a> web form.</para>
    /// </summary>
    public partial class AddCommunicationToCaseRequest : AmazonAWSSupportRequest
    {
        private string caseId;
        private string communicationBody;
        private List<string> ccEmailAddresses = new List<string>();


        /// <summary>
        /// The AWS Support case ID requested or returned in the call. The case ID is an alphanumeric string formatted as shown in this example:
        /// case-<i>12345678910-2013-c4c1d2bf33c5cf47</i>
        ///  
        /// </summary>
        public string CaseId
        {
            get { return this.caseId; }
            set { this.caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this.caseId != null;
        }

        /// <summary>
        /// The body of an email communication to add to the support case.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 8000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CommunicationBody
        {
            get { return this.communicationBody; }
            set { this.communicationBody = value; }
        }

        // Check to see if CommunicationBody property is set
        internal bool IsSetCommunicationBody()
        {
            return this.communicationBody != null;
        }

        /// <summary>
        /// The email addresses in the CC line of an email to be added to the support case.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> CcEmailAddresses
        {
            get { return this.ccEmailAddresses; }
            set { this.ccEmailAddresses = value; }
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this.ccEmailAddresses.Count > 0;
        }

    }
}
    
