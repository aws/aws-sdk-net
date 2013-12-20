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
    /// Container for the parameters to the ListPipelines operation.
    /// <para>The ListPipelines operation gets a list of the pipelines associated with the current AWS account.</para>
    /// </summary>
    public partial class ListPipelinesRequest : AmazonElasticTranscoderRequest
    {
        private string ascending;
        private string pageToken;


        /// <summary>
        /// To list pipelines in chronological order by the date and time that they were created, enter <c>true</c>. To list pipelines in reverse
        /// chronological order, enter <c>false</c>.
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

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this.pageToken != null;
        }

    }
}
    
