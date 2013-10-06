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
    /// <para>This action returns a list of cases that you specify by passing one or more CaseIds. In addition, you can filter the cases by date by
    /// setting values for the AfterTime and BeforeTime request parameters. </para> <para> The response returns the following in JSON format:
    /// </para> <ol> <li>One or more CaseDetails data types. </li>
    /// <li>One or more <i>NextToken</i> objects, strings that specifies where to paginate the returned records represented by <i>CaseDetails</i>
    /// .</li>
    /// </ol>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.DescribeCases"/>
    public class DescribeCasesRequest : AmazonWebServiceRequest
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
        /// A list of Strings comprising ID numbers for support cases you want returned. The maximum number of cases is 100.
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
        /// <summary>
        /// Adds elements to the CaseIdList collection
        /// </summary>
        /// <param name="caseIdList">The values to add to the CaseIdList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithCaseIdList(params string[] caseIdList)
        {
            foreach (string element in caseIdList)
            {
                this.caseIdList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CaseIdList collection
        /// </summary>
        /// <param name="caseIdList">The values to add to the CaseIdList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithCaseIdList(IEnumerable<string> caseIdList)
        {
            foreach (string element in caseIdList)
            {
                this.caseIdList.Add(element);
            }

            return this;
        }

        // Check to see if CaseIdList property is set
        internal bool IsSetCaseIdList()
        {
            return this.caseIdList.Count > 0;
        }

        /// <summary>
        /// String that corresponds to the ID value displayed for a case in the AWS Support Center user interface.
        ///  
        /// </summary>
        public string DisplayId
        {
            get { return this.displayId; }
            set { this.displayId = value; }
        }

        /// <summary>
        /// Sets the DisplayId property
        /// </summary>
        /// <param name="displayId">The value to set for the DisplayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithDisplayId(string displayId)
        {
            this.displayId = displayId;
            return this;
        }
            

        // Check to see if DisplayId property is set
        internal bool IsSetDisplayId()
        {
            return this.displayId != null;
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithAfterTime(string afterTime)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithBeforeTime(string beforeTime)
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
        /// Boolean that indicates whether or not resolved support cases should be listed in the <a href="API_DescribeCases.html"
        /// title="DescribeCases">DescribeCases</a> search.
        ///  
        /// </summary>
        public bool IncludeResolvedCases
        {
            get { return this.includeResolvedCases ?? default(bool); }
            set { this.includeResolvedCases = value; }
        }

        /// <summary>
        /// Sets the IncludeResolvedCases property
        /// </summary>
        /// <param name="includeResolvedCases">The value to set for the IncludeResolvedCases property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithIncludeResolvedCases(bool includeResolvedCases)
        {
            this.includeResolvedCases = includeResolvedCases;
            return this;
        }
            

        // Check to see if IncludeResolvedCases property is set
        internal bool IsSetIncludeResolvedCases()
        {
            return this.includeResolvedCases.HasValue;
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
        public DescribeCasesRequest WithNextToken(string nextToken)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithMaxResults(int maxResults)
        {
            this.maxResults = maxResults;
            return this;
        }
            

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// Specifies the ISO 639-1 code for the language in which AWS provides support. AWS Support currently supports English and Japanese, for which
        /// the codes are <i>en</i> and <i>ja</i>, respectively.
        ///  
        /// </summary>
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        /// <summary>
        /// Sets the Language property
        /// </summary>
        /// <param name="language">The value to set for the Language property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCasesRequest WithLanguage(string language)
        {
            this.language = language;
            return this;
        }
            

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this.language != null;
        }
    }
}
    
