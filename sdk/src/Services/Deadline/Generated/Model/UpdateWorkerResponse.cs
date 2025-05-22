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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the UpdateWorker operation.
    /// </summary>
    public partial class UpdateWorkerResponse : AmazonWebServiceResponse
    {
        private HostConfiguration _hostConfiguration;
        private LogConfiguration _log;

        /// <summary>
        /// Gets and sets the property HostConfiguration. 
        /// <para>
        /// The script that runs as a worker is starting up that you can use to provide additional
        /// configuration for workers in your fleet.
        /// </para>
        /// </summary>
        public HostConfiguration HostConfiguration
        {
            get { return this._hostConfiguration; }
            set { this._hostConfiguration = value; }
        }

        // Check to see if HostConfiguration property is set
        internal bool IsSetHostConfiguration()
        {
            return this._hostConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The worker log to update.
        /// </para>
        /// </summary>
        public LogConfiguration Log
        {
            get { return this._log; }
            set { this._log = value; }
        }

        // Check to see if Log property is set
        internal bool IsSetLog()
        {
            return this._log != null;
        }

    }
}