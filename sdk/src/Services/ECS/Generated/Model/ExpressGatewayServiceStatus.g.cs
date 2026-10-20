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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object that defines the status of Express service creation and information about
    /// the status of the service.
    /// </summary>
    public partial class ExpressGatewayServiceStatus
    {
        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status of the Express service.
        /// </para>
        /// </summary>
        public ExpressGatewayServiceStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the Express service is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
