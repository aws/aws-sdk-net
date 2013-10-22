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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains a paginated collection of DomainInfo structures. </para>
    /// </summary>
    public partial class DomainInfos : AmazonWebServiceResponse
    {
        
        private List<DomainInfo> infos = new List<DomainInfo>();
        private string nextPageToken;

        /// <summary>
        /// A list of DomainInfo structures.
        ///  
        /// </summary>
        public List<DomainInfo> Infos
        {
            get { return this.infos; }
            set { this.infos = value; }
        }

        // Check to see if Infos property is set
        internal bool IsSetInfos()
        {
            return this.infos.Count > 0;
        }

        /// <summary>
        /// Returns a value if the results are paginated. To get the next page of results, repeat the request specifying this token and all other
        /// arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
