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
    /// <para>This action adds additional customer communication to an AWS Support case. You use the <i>CaseId</i> value to identify the case to
    /// which you want to add communication. You can list a set of email addresses to copy on the communication using the <i>CcEmailAddresses</i>
    /// value. The <i>CommunicationBody</i> value contains the text of the communication.</para> <para>This action's response indicates the success
    /// or failure of the request.</para> <para>This action implements a subset of the behavior on the AWS Support Your Support Cases web
    /// form.</para>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.AddCommunicationToCase"/>
    public class AddCommunicationToCaseRequest : AmazonWebServiceRequest
    {
        private string caseId;
        private string communicationBody;
        private List<string> ccEmailAddresses = new List<string>();

        /// <summary>
        /// String that indicates the AWS Support caseID requested or returned in the call. The caseID is an alphanumeric string formatted as shown in
        /// this example CaseId: <i>case-12345678910-2013-c4c1d2bf33c5cf47</i>
        ///  
        /// </summary>
        public string CaseId
        {
            get { return this.caseId; }
            set { this.caseId = value; }
        }

        /// <summary>
        /// Sets the CaseId property
        /// </summary>
        /// <param name="caseId">The value to set for the CaseId property </param>
        /// <returns>this instance</returns>
        public AddCommunicationToCaseRequest WithCaseId(string caseId)
        {
            this.caseId = caseId;
            return this;
        }
            

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this.caseId != null;
        }

        /// <summary>
        /// Represents the body of an email communication added to the support case.
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

        /// <summary>
        /// Sets the CommunicationBody property
        /// </summary>
        /// <param name="communicationBody">The value to set for the CommunicationBody property </param>
        /// <returns>this instance</returns>
        public AddCommunicationToCaseRequest WithCommunicationBody(string communicationBody)
        {
            this.communicationBody = communicationBody;
            return this;
        }
            

        // Check to see if CommunicationBody property is set
        internal bool IsSetCommunicationBody()
        {
            return this.communicationBody != null;
        }

        /// <summary>
        /// Represents any email addresses contained in the CC line of an email added to the support case.
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
        /// <summary>
        /// Adds elements to the CcEmailAddresses collection
        /// </summary>
        /// <param name="ccEmailAddresses">The values to add to the CcEmailAddresses collection </param>
        /// <returns>this instance</returns>
        public AddCommunicationToCaseRequest WithCcEmailAddresses(params string[] ccEmailAddresses)
        {
            foreach (string element in ccEmailAddresses)
            {
                this.ccEmailAddresses.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CcEmailAddresses collection
        /// </summary>
        /// <param name="ccEmailAddresses">The values to add to the CcEmailAddresses collection </param>
        /// <returns>this instance</returns>
        public AddCommunicationToCaseRequest WithCcEmailAddresses(IEnumerable<string> ccEmailAddresses)
        {
            foreach (string element in ccEmailAddresses)
            {
                this.ccEmailAddresses.Add(element);
            }

            return this;
        }

        // Check to see if CcEmailAddresses property is set
        internal bool IsSetCcEmailAddresses()
        {
            return this.ccEmailAddresses.Count > 0;
        }
    }
}
    
