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
    /// Container for the parameters to the Promote operation.
    /// Promotes a data replication replica broker to the primary broker role.
    /// </summary>
    public partial class PromoteRequest : AmazonMQRequest
    {
        private string _brokerId;
        private PromoteMode _mode;

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The unique ID that Amazon MQ generates for the broker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The Promote mode requested. Note: Valid values for the parameter are SWITCHOVER, FAILOVER.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PromoteMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}