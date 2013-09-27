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
    /// <para>Returns an array of CaseDetails objects and a <i>NextToken</i> that defines a point for pagination in the result set.</para>
    /// </summary>
    public class DescribeCasesResult
    {
        
        private List<CaseDetails> cases = new List<CaseDetails>();
        private string nextToken;

        /// <summary>
        /// Array of <a href="API_CaseDetails.html" title="CaseDetails">CaseDetails</a> objects.
        ///  
        /// </summary>
        public List<CaseDetails> Cases
        {
            get { return this.cases; }
            set { this.cases = value; }
        }
        /// <summary>
        /// Adds elements to the Cases collection
        /// </summary>
        /// <param name="cases">The values to add to the Cases collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesResult WithCases(params CaseDetails[] cases)
        {
            foreach (CaseDetails element in cases)
            {
                this.cases.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Cases collection
        /// </summary>
        /// <param name="cases">The values to add to the Cases collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesResult WithCases(IEnumerable<CaseDetails> cases)
        {
            foreach (CaseDetails element in cases)
            {
                this.cases.Add(element);
            }

            return this;
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this.cases.Count > 0;
        }

        /// <summary>
        /// Defines a resumption point for pagination.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesResult WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
