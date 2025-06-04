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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// This is the response object from the CreateEnvironmentHost operation.
    /// </summary>
    public partial class CreateEnvironmentHostResponse : AmazonWebServiceResponse
    {
        private EnvironmentSummary _environmentSummary;
        private Host _host;

        /// <summary>
        /// Gets and sets the property EnvironmentSummary. 
        /// <para>
        /// A summary of the environment that the host is created in.
        /// </para>
        /// </summary>
        public EnvironmentSummary EnvironmentSummary
        {
            get { return this._environmentSummary; }
            set { this._environmentSummary = value; }
        }

        // Check to see if EnvironmentSummary property is set
        internal bool IsSetEnvironmentSummary()
        {
            return this._environmentSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// A description of the created host.
        /// </para>
        /// </summary>
        public Host Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

    }
}