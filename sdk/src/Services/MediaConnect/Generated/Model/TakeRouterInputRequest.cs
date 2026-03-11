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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the TakeRouterInput operation.
    /// Associates a router input with a router output in AWS Elemental MediaConnect.
    /// </summary>
    public partial class TakeRouterInputRequest : AmazonMediaConnectRequest
    {
        private string _routerInputArn;
        private string _routerOutputArn;

        /// <summary>
        /// Gets and sets the property RouterInputArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router input that you want to associate with
        /// a router output.
        /// </para>
        /// </summary>
        public string RouterInputArn
        {
            get { return this._routerInputArn; }
            set { this._routerInputArn = value; }
        }

        // Check to see if RouterInputArn property is set
        internal bool IsSetRouterInputArn()
        {
            return this._routerInputArn != null;
        }

        /// <summary>
        /// Gets and sets the property RouterOutputArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router output that you want to associate with
        /// a router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouterOutputArn
        {
            get { return this._routerOutputArn; }
            set { this._routerOutputArn = value; }
        }

        // Check to see if RouterOutputArn property is set
        internal bool IsSetRouterOutputArn()
        {
            return this._routerOutputArn != null;
        }

    }
}