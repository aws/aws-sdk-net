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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetLoadBalancers operation.
    /// Returns information about all load balancers in an account.
    /// 
    ///  
    /// <para>
    /// If you are describing a long list of load balancers, you can paginate the output to
    /// make the list more manageable. You can use the pageToken and nextPageToken values
    /// to retrieve the next items in the list.
    /// </para>
    /// </summary>
    public partial class GetLoadBalancersRequest : AmazonLightsailRequest
    {
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// A token used for paginating the results from your GetLoadBalancers request.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}