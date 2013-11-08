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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Contains the AWSSupport <i>caseId</i> returned by a successful completion of the <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" >CreateCase</a> action. </para>
    /// </summary>
    public partial class CreateCaseResult : AmazonWebServiceResponse
    {
        
        private string caseId;

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

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this.caseId != null;
        }
    }
}
