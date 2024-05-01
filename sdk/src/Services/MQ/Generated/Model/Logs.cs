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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// The list of information about logs to be enabled for the specified broker.
    /// </summary>
    public partial class Logs
    {
        private bool? _audit;
        private bool? _general;

        /// <summary>
        /// Gets and sets the property Audit. 
        /// <para>
        /// Enables audit logging. Every user management action made using JMX or the ActiveMQ
        /// Web Console is logged. Does not apply to RabbitMQ brokers.
        /// </para>
        /// </summary>
        public bool? Audit
        {
            get { return this._audit; }
            set { this._audit = value; }
        }

        // Check to see if Audit property is set
        internal bool IsSetAudit()
        {
            return this._audit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property General. 
        /// <para>
        /// Enables general logging.
        /// </para>
        /// </summary>
        public bool? General
        {
            get { return this._general; }
            set { this._general = value; }
        }

        // Check to see if General property is set
        internal bool IsSetGeneral()
        {
            return this._general.HasValue; 
        }

    }
}