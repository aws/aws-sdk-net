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
    /// Container for the parameters to the GetTrafficPolicyInstance operation.
    /// Gets information about a specified traffic policy instance.
    /// 
    ///  <note> 
    /// <para>
    ///  Use <c>GetTrafficPolicyInstance</c> with the <c>id</c> of new traffic policy instance
    /// to confirm that the <c>CreateTrafficPolicyInstance</c> or an <c>UpdateTrafficPolicyInstance</c>
    /// request completed successfully. For more information, see the <c>State</c> response
    /// element.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// In the Route 53 console, traffic policy instances are known as policy records.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetTrafficPolicyInstanceRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the traffic policy instance that you want to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
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