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

/*
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains a paginated collection of DomainInfo structures.
    /// </summary>
    public partial class DomainInfos
    {
        private List<DomainInfo> _infos = new List<DomainInfo>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property Infos. 
        /// <para>
        ///  A list of DomainInfo structures. 
        /// </para>
        /// </summary>
        public List<DomainInfo> Infos
        {
            get { return this._infos; }
            set { this._infos = value; }
        }

        // Check to see if Infos property is set
        internal bool IsSetInfos()
        {
            return this._infos != null && this._infos.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        ///  Returns a value if the results are paginated. To get the next page of results, repeat
        /// the request specifying this token and all other arguments unchanged. 
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}