/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the DescribeMappedResourceConfiguration operation.
    /// </summary>
    public partial class DescribeMappedResourceConfigurationResponse : AmazonWebServiceResponse
    {
        private List<MappedResourceConfigurationListItem> _mappedResourceConfigurationList = new List<MappedResourceConfigurationListItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MappedResourceConfigurationList. 
        /// <para>
        /// A structure that encapsulates, or contains, the media storage configuration properties.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<MappedResourceConfigurationListItem> MappedResourceConfigurationList
        {
            get { return this._mappedResourceConfigurationList; }
            set { this._mappedResourceConfigurationList = value; }
        }

        // Check to see if MappedResourceConfigurationList property is set
        internal bool IsSetMappedResourceConfigurationList()
        {
            return this._mappedResourceConfigurationList != null && this._mappedResourceConfigurationList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that was used in the <code>NextToken</code>request to fetch the next set
        /// of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}