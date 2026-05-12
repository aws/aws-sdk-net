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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
    /// This is the response object from the DescribeDaemon operation.
    /// </summary>
    public partial class DescribeDaemonResponse : AmazonWebServiceResponse
    {
        private DaemonDetail _daemon;

        /// <summary>
        /// Gets and sets the property Daemon. 
        /// <para>
        /// The full description of the daemon, including the current revisions, deployment ARN,
        /// cluster, and status information.
        /// </para>
        /// </summary>
        public DaemonDetail Daemon
        {
            get { return this._daemon; }
            set { this._daemon = value; }
        }

        // Check to see if Daemon property is set
        internal bool IsSetDaemon()
        {
            return this._daemon != null;
        }

    }
}