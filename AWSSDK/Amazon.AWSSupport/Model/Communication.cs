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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Object that exposes the fields used by a communication for an AWS Support case.</para>
    /// </summary>
    public class Communication
    {
        
        private string caseId;
        private string body;
        private string submittedBy;
        private string timeCreated;

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
        public Communication WithCaseId(string caseId)
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
        /// Contains the text of the the commmunication between the customer and AWS Support.
        ///  
        /// </summary>
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        /// <summary>
        /// Sets the Body property
        /// </summary>
        /// <param name="body">The value to set for the Body property </param>
        /// <returns>this instance</returns>
        public Communication WithBody(string body)
        {
            this.body = body;
            return this;
        }
            

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;
        }

        /// <summary>
        /// Email address of the account that submitted the AWS Support case.
        ///  
        /// </summary>
        public string SubmittedBy
        {
            get { return this.submittedBy; }
            set { this.submittedBy = value; }
        }

        /// <summary>
        /// Sets the SubmittedBy property
        /// </summary>
        /// <param name="submittedBy">The value to set for the SubmittedBy property </param>
        /// <returns>this instance</returns>
        public Communication WithSubmittedBy(string submittedBy)
        {
            this.submittedBy = submittedBy;
            return this;
        }
            

        // Check to see if SubmittedBy property is set
        internal bool IsSetSubmittedBy()
        {
            return this.submittedBy != null;
        }

        /// <summary>
        /// Time the support case was created.
        ///  
        /// </summary>
        public string TimeCreated
        {
            get { return this.timeCreated; }
            set { this.timeCreated = value; }
        }

        /// <summary>
        /// Sets the TimeCreated property
        /// </summary>
        /// <param name="timeCreated">The value to set for the TimeCreated property </param>
        /// <returns>this instance</returns>
        public Communication WithTimeCreated(string timeCreated)
        {
            this.timeCreated = timeCreated;
            return this;
        }
            

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this.timeCreated != null;
        }
    }
}
