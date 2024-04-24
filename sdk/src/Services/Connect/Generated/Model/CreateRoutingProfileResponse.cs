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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateRoutingProfile operation.
    /// </summary>
    public partial class CreateRoutingProfileResponse : AmazonWebServiceResponse
    {
        private string _routingProfileArn;
        private string _routingProfileId;

        /// <summary>
        /// Gets and sets the property RoutingProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileArn
        {
            get { return this._routingProfileArn; }
            set { this._routingProfileArn = value; }
        }

        // Check to see if RoutingProfileArn property is set
        internal bool IsSetRoutingProfileArn()
        {
            return this._routingProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingProfileId. 
        /// <para>
        /// The identifier of the routing profile.
        /// </para>
        /// </summary>
        public string RoutingProfileId
        {
            get { return this._routingProfileId; }
            set { this._routingProfileId = value; }
        }

        // Check to see if RoutingProfileId property is set
        internal bool IsSetRoutingProfileId()
        {
            return this._routingProfileId != null;
        }

    }
}