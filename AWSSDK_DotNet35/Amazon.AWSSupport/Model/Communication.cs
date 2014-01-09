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
    /// <para>Exposes the fields used by a communication for an AWS Support case.</para>
    /// </summary>
    public class Communication
    {
        
        private string caseId;
        private string body;
        private string submittedBy;
        private string timeCreated;


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
        /// The text of the communication between the customer and AWS Support.
        ///  
        /// </summary>
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;
        }

        /// <summary>
        /// The email address of the account that submitted the AWS Support case.
        ///  
        /// </summary>
        public string SubmittedBy
        {
            get { return this.submittedBy; }
            set { this.submittedBy = value; }
        }

        // Check to see if SubmittedBy property is set
        internal bool IsSetSubmittedBy()
        {
            return this.submittedBy != null;
        }

        /// <summary>
        /// The time the support case was created.
        ///  
        /// </summary>
        public string TimeCreated
        {
            get { return this.timeCreated; }
            set { this.timeCreated = value; }
        }

        // Check to see if TimeCreated property is set
        internal bool IsSetTimeCreated()
        {
            return this.timeCreated != null;
        }
    }
}
