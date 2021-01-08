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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing tags for the specified resources.
    /// </summary>
    public partial class ListTagsForResourcesResponse : AmazonWebServiceResponse
    {
        private List<ResourceTagSet> _resourceTagSets = new List<ResourceTagSet>();

        /// <summary>
        /// Gets and sets the property ResourceTagSets. 
        /// <para>
        /// A list of <code>ResourceTagSet</code>s containing tags associated with the specified
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceTagSet> ResourceTagSets
        {
            get { return this._resourceTagSets; }
            set { this._resourceTagSets = value; }
        }

        // Check to see if ResourceTagSets property is set
        internal bool IsSetResourceTagSets()
        {
            return this._resourceTagSets != null && this._resourceTagSets.Count > 0; 
        }

    }
}