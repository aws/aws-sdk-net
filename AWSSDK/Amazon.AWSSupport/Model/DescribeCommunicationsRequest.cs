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
    /// Container for the parameters to the DescribeCommunications operation.
    /// <para>This action returns communications regarding the support case. You can use the <i>AfterTime</i> and <i>BeforeTime</i> parameters to
    /// filter by date. The <i>CaseId</i> parameter enables you to identify a specific case by its <i>CaseId</i> number.</para> <para>The
    /// <i>MaxResults</i> and <i>NextToken</i> parameters enable you to control the pagination of the result set. Set <i>MaxResults</i> to the
    /// number of cases you want displayed on each page, and use <i>NextToken</i> to specify the resumption of pagination.</para>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.DescribeCommunications"/>
    public class DescribeCommunicationsRequest : AmazonWebServiceRequest
    {
        private string caseId;
        private string beforeTime;
        private string afterTime;
        private string nextToken;
        private int? maxResults;

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
        public DescribeCommunicationsRequest WithCaseId(string caseId)
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
        /// End date for a filtered date search on support case communications.
        ///  
        /// </summary>
        public string BeforeTime
        {
            get { return this.beforeTime; }
            set { this.beforeTime = value; }
        }

        /// <summary>
        /// Sets the BeforeTime property
        /// </summary>
        /// <param name="beforeTime">The value to set for the BeforeTime property </param>
        /// <returns>this instance</returns>
        public DescribeCommunicationsRequest WithBeforeTime(string beforeTime)
        {
            this.beforeTime = beforeTime;
            return this;
        }
            

        // Check to see if BeforeTime property is set
        internal bool IsSetBeforeTime()
        {
            return this.beforeTime != null;
        }

        /// <summary>
        /// Start date for a filtered date search on support case communications.
        ///  
        /// </summary>
        public string AfterTime
        {
            get { return this.afterTime; }
            set { this.afterTime = value; }
        }

        /// <summary>
        /// Sets the AfterTime property
        /// </summary>
        /// <param name="afterTime">The value to set for the AfterTime property </param>
        /// <returns>this instance</returns>
        public DescribeCommunicationsRequest WithAfterTime(string afterTime)
        {
            this.afterTime = afterTime;
            return this;
        }
            

        // Check to see if AfterTime property is set
        internal bool IsSetAfterTime()
        {
            return this.afterTime != null;
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
        public DescribeCommunicationsRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// Integer that sets the maximum number of results to return before paginating.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>10 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        /// <summary>
        /// Sets the MaxResults property
        /// </summary>
        /// <param name="maxResults">The value to set for the MaxResults property </param>
        /// <returns>this instance</returns>
        public DescribeCommunicationsRequest WithMaxResults(int maxResults)
        {
            this.maxResults = maxResults;
            return this;
        }
            

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }
    }
}
    
