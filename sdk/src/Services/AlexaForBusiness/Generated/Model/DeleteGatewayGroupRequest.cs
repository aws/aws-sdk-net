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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGatewayGroup operation.
    /// Deletes a gateway group.
    /// </summary>
    public partial class DeleteGatewayGroupRequest : AmazonAlexaForBusinessRequest
    {
        private string _gatewayGroupArn;

        /// <summary>
        /// Gets and sets the property GatewayGroupArn. 
        /// <para>
        /// The ARN of the gateway group to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayGroupArn
        {
            get { return this._gatewayGroupArn; }
            set { this._gatewayGroupArn = value; }
        }

        // Check to see if GatewayGroupArn property is set
        internal bool IsSetGatewayGroupArn()
        {
            return this._gatewayGroupArn != null;
        }

    }
}