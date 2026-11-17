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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// An integration configured on the serverless cache, and its current status. ElastiCache
    /// supports DynamoDB integration.
    /// </summary>
    public partial class Integration
    {
        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type. ElastiCache supports <c>dynamodb</c>.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the integration. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enabled</c> – The integration is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c> – The integration is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IntegrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
