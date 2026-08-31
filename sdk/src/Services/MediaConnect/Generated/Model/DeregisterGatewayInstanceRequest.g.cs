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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeregisterGatewayInstance operation. Deregisters
    /// an instance. Before you deregister an instance, all bridges running on the instance
    /// must be stopped. If you want to deregister an instance without stopping the bridges,
    /// you must use the --force option.
    /// </summary>
    public partial class DeregisterGatewayInstanceRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        ///  Force the deregistration of an instance. Force will deregister an instance, even
        /// if there are bridges running on it.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the gateway that contains the instance that you
        /// want to deregister.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayInstanceArn property is set.
        /// </summary>
        internal bool IsSetGatewayInstanceArn() => this.GatewayInstanceArn != null;
    }
}
