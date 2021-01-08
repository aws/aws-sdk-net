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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// A collection of log configurations.
    /// </summary>
    public partial class LogConfigurations
    {
        private LogConfiguration _cloudwatch;

        /// <summary>
        /// Gets and sets the property Cloudwatch. 
        /// <para>
        /// Parameters for publishing logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LogConfiguration Cloudwatch
        {
            get { return this._cloudwatch; }
            set { this._cloudwatch = value; }
        }

        // Check to see if Cloudwatch property is set
        internal bool IsSetCloudwatch()
        {
            return this._cloudwatch != null;
        }

    }
}