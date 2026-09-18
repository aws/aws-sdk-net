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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about logs to be activated for the specified broker.
    /// </summary>
    public partial class AwsAmazonMqBrokerLogsPendingDetails
    {
        /// <summary>
        /// Gets and sets the property Audit. 
        /// <para>
        ///  Activates audit logging. Every user management action made using JMX or the ActiveMQ
        /// Web Console is logged. Doesn't apply to RabbitMQ brokers. 
        /// </para>
        /// </summary>
        public bool? Audit { get; set; }

        /// <summary>
        /// Checks to see if the Audit property is set.
        /// </summary>
        internal bool IsSetAudit() => this.Audit.HasValue;

        /// <summary>
        /// Gets and sets the property General. 
        /// <para>
        ///  Activates general logging. 
        /// </para>
        /// </summary>
        public bool? General { get; set; }

        /// <summary>
        /// Checks to see if the General property is set.
        /// </summary>
        internal bool IsSetGeneral() => this.General.HasValue;
    }
}
