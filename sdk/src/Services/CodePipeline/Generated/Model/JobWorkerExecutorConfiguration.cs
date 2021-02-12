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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Details about the polling configuration for the <code>JobWorker</code> action engine,
    /// or executor.
    /// </summary>
    public partial class JobWorkerExecutorConfiguration
    {
        private List<string> _pollingAccounts = new List<string>();
        private List<string> _pollingServicePrincipals = new List<string>();

        /// <summary>
        /// Gets and sets the property PollingAccounts. 
        /// <para>
        /// The accounts in which the job worker is configured and might poll for jobs as part
        /// of the action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> PollingAccounts
        {
            get { return this._pollingAccounts; }
            set { this._pollingAccounts = value; }
        }

        // Check to see if PollingAccounts property is set
        internal bool IsSetPollingAccounts()
        {
            return this._pollingAccounts != null && this._pollingAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PollingServicePrincipals. 
        /// <para>
        /// The service Principals in which the job worker is configured and might poll for jobs
        /// as part of the action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> PollingServicePrincipals
        {
            get { return this._pollingServicePrincipals; }
            set { this._pollingServicePrincipals = value; }
        }

        // Check to see if PollingServicePrincipals property is set
        internal bool IsSetPollingServicePrincipals()
        {
            return this._pollingServicePrincipals != null && this._pollingServicePrincipals.Count > 0; 
        }

    }
}