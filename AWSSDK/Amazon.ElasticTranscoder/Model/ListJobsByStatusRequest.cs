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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobsByStatus operation.
    /// <para>The ListJobsByStatus operation gets a list of jobs that have a specified status. The response body contains one element for each job
    /// that satisfies the search criteria.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByStatus"/>
    public class ListJobsByStatusRequest : AmazonWebServiceRequest
    {
        private string status;
        private string ascending;
        private string pageToken;

        /// <summary>
        /// To get information about all of the jobs associated with the current AWS account that have a given status, specify the following status:
        /// <c>Submitted</c>, <c>Progressing</c>, <c>Complete</c>, <c>Canceled</c>, or <c>Error</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Submitted$)|(^Progressing$)|(^Complete$)|(^Canceled$)|(^Error$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByStatusRequest WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// To list jobs in chronological order by the date and time that they were submitted, enter <c>true</c>. To list jobs in reverse chronological
        /// order, enter <c>false</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^true$)|(^false$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Ascending
        {
            get { return this.ascending; }
            set { this.ascending = value; }
        }

        /// <summary>
        /// Sets the Ascending property
        /// </summary>
        /// <param name="ascending">The value to set for the Ascending property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByStatusRequest WithAscending(string ascending)
        {
            this.ascending = ascending;
            return this;
        }
            

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this.ascending != null;
        }

        /// <summary>
        /// When Elastic Transcoder returns more than one page of results, use <c>pageToken</c> in subsequent <c>GET</c> requests to get each successive
        /// page of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this.pageToken; }
            set { this.pageToken = value; }
        }

        /// <summary>
        /// Sets the PageToken property
        /// </summary>
        /// <param name="pageToken">The value to set for the PageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsByStatusRequest WithPageToken(string pageToken)
        {
            this.pageToken = pageToken;
            return this;
        }
            

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this.pageToken != null;
        }
    }
}
    
