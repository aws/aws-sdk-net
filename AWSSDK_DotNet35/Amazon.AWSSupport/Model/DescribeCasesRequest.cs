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
    /// Container for the parameters to the DescribeCases operation.
    /// <para>Returns a list of cases that you specify by passing one or more case IDs. In addition, you can filter the cases by date by setting
    /// values for the <c>AfterTime</c> and <c>BeforeTime</c> request parameters. </para> <para>The response returns the following in JSON
    /// format:</para> <ol> <li>One or more CaseDetails data types. </li>
    /// <li>One or more <c>NextToken</c> values, which specify where to paginate the returned records represented by the <c>CaseDetails</c>
    /// objects.</li>
    /// </ol>
    /// </summary>
    public partial class DescribeCasesRequest : AmazonAWSSupportRequest
    {
        private List<string> caseIdList = new List<string>();
        private string displayId;
        private string afterTime;
        private string beforeTime;
        private bool? includeResolvedCases;
        private string nextToken;
        private int? maxResults;
        private string language;


        /// <summary>
        /// A list of ID numbers of the support cases you want returned. The maximum number of cases is 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> CaseIdList
        {
            get { return this.caseIdList; }
            set { this.caseIdList = value; }
        }

        // Check to see if CaseIdList property is set
        internal bool IsSetCaseIdList()
        {
            return this.caseIdList.Count > 0;
        }

        /// <summary>
        /// The ID displayed for a case in the AWS Support Center user interface.
        ///  
        /// </summary>
        public string DisplayId
        {
            get { return this.displayId; }
            set { this.displayId = value; }
        }

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this.displayId != null;
        }

        /// <summary>
        /// The start date for a filtered date search on support case communications.
        ///  
        /// </summary>
        public string AfterTime
        {
            get { return this.afterTime; }
            set { this.afterTime = value; }
        }

        // Check to see if AfterTime property is set
        internal bool IsSetAfterTime()
        {
            return this.afterTime != null;
        }

        /// <summary>
        /// The end date for a filtered date search on support case communications.
        ///  
        /// </summary>
        public string BeforeTime
        {
            get { return this.beforeTime; }
            set { this.beforeTime = value; }
        }

        // Check to see if BeforeTime property is set
        internal bool IsSetBeforeTime()
        {
            return this.beforeTime != null;
        }

        /// <summary>
        /// Specifies whether resolved support cases should be included in the <a>DescribeCases</a> results.
        ///  
        /// </summary>
        public bool IncludeResolvedCases
        {
            get { return this.includeResolvedCases ?? default(bool); }
            set { this.includeResolvedCases = value; }
        }

        // Check to see if IncludeResolvedCases property is set
        internal bool IsSetIncludeResolvedCases()
        {
            return this.includeResolvedCases.HasValue;
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

        /// <summary>
        /// The maximum number of results to return before paginating.
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

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English ("en") and Japanese ("ja").
        /// Language parameters must be passed explicitly for operations that take them.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }

    }
}
    
