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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the GetIPSet operation.
    /// </summary>
    public partial class GetIPSetResponse : AmazonWebServiceResponse
    {
        private IPSet _ipSet;

        /// <summary>
        /// Gets and sets the property IPSet. 
        /// <para>
        /// Information about the <a>IPSet</a> that you specified in the <code>GetIPSet</code>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>IPSet</a>: Contains <code>IPSetDescriptors</code>, <code>IPSetId</code>, and <code>Name</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IPSetDescriptors</code>: Contains an array of <a>IPSetDescriptor</a> objects.
        /// Each <code>IPSetDescriptor</code> object contains <code>Type</code> and <code>Value</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IPSet IPSet
        {
            get { return this._ipSet; }
            set { this._ipSet = value; }
        }

        // Check to see if IPSet property is set
        internal bool IsSetIPSet()
        {
            return this._ipSet != null;
        }

    }
}