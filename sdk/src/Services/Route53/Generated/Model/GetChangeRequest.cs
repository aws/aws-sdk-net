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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetChange operation.
    /// Returns the current status of a change batch request. The status is one of the following
    /// values:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>PENDING</c> indicates that the changes in this request have not propagated to
    /// all Amazon Route 53 DNS servers managing the hosted zone. This is the initial status
    /// of all change batch requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>INSYNC</c> indicates that the changes have propagated to all Route 53 DNS servers
    /// managing the hosted zone. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetChangeRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetChangeRequest() { }

        /// <summary>
        /// Instantiates GetChangeRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The ID of the change batch request. The value that you specify here is the value that <c>ChangeResourceRecordSets</c> returned in the <c>Id</c> element when you submitted the request.</param>
        public GetChangeRequest(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the change batch request. The value that you specify here is the value that
        /// <c>ChangeResourceRecordSets</c> returned in the <c>Id</c> element when you submitted
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6500)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}