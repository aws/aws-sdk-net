/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>DescribeSuggesters</c> request.</para>
    /// </summary>
    public partial class DescribeSuggestersResult : AmazonWebServiceResponse
    {
        
        private List<SuggesterStatus> suggesters = new List<SuggesterStatus>();


        /// <summary>
        /// The suggesters configured for the domain specified in the request.
        ///  
        /// </summary>
        public List<SuggesterStatus> Suggesters
        {
            get { return this.suggesters; }
            set { this.suggesters = value; }
        }

        // Check to see if Suggesters property is set
        internal bool IsSetSuggesters()
        {
            return this.suggesters.Count > 0;
        }
    }
}
