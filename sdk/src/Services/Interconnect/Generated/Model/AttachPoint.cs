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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
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
namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Identifies an attach point to use with a Connection.
    /// </summary>
    public partial class AttachPoint
    {
        private string _arn;
        private string _directConnectGateway;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Identifies an attach point by full ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=59, Max=150)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGateway. 
        /// <para>
        /// Identifies an DirectConnect Gateway attach point by DirectConnectGatewayID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DirectConnectGateway
        {
            get { return this._directConnectGateway; }
            set { this._directConnectGateway = value; }
        }

        // Check to see if DirectConnectGateway property is set
        internal bool IsSetDirectConnectGateway()
        {
            return this._directConnectGateway != null;
        }

    }
}