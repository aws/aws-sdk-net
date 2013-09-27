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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the QueryObjects action.</para>
    /// </summary>
    public class QueryObjectsResult
    {
        
        private List<string> ids = new List<string>();
        private string marker;
        private bool? hasMoreResults;

        /// <summary>
        /// A list of identifiers that match the query selectors.
        ///  
        /// </summary>
        public List<string> Ids
        {
            get { return this.ids; }
            set { this.ids = value; }
        }
        /// <summary>
        /// Adds elements to the Ids collection
        /// </summary>
        /// <param name="ids">The values to add to the Ids collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsResult WithIds(params string[] ids)
        {
            foreach (string element in ids)
            {
                this.ids.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Ids collection
        /// </summary>
        /// <param name="ids">The values to add to the Ids collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsResult WithIds(IEnumerable<string> ids)
        {
            foreach (string element in ids)
            {
                this.ids.Add(element);
            }

            return this;
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this.ids.Count > 0;
        }

        /// <summary>
        /// The starting point for the results to be returned. As long as the action returns <c>HasMoreResults</c> as <c>True</c>, you can call
        /// <a>QueryObjects</a> again and pass the marker value from the response to retrieve the next set of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// If <c>True</c>, there are more results that can be obtained by a subsequent call to <a>QueryObjects</a>.
        ///  
        /// </summary>
        public bool HasMoreResults
        {
            get { return this.hasMoreResults ?? default(bool); }
            set { this.hasMoreResults = value; }
        }

        /// <summary>
        /// Sets the HasMoreResults property
        /// </summary>
        /// <param name="hasMoreResults">The value to set for the HasMoreResults property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryObjectsResult WithHasMoreResults(bool hasMoreResults)
        {
            this.hasMoreResults = hasMoreResults;
            return this;
        }
            

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this.hasMoreResults.HasValue;
        }
    }
}
