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
    /// <para>Returns an array of CaseDetails objects and a <c>NextToken</c> that defines a point for pagination in the result set.</para>
    /// </summary>
    public partial class DescribeCasesResult : AmazonWebServiceResponse
    {
        
        private List<CaseDetails> cases = new List<CaseDetails>();
        private string nextToken;


        /// <summary>
        /// The details for the cases that match the request.
        ///  
        /// </summary>
        public List<CaseDetails> Cases
        {
            get { return this.cases; }
            set { this.cases = value; }
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this.cases.Count > 0;
        }

        /// <summary>
        /// A resumption point for pagination.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
