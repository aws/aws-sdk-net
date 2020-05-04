/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// List of each of the failed remediations with specific reasons.
    /// </summary>
    public partial class FailedRemediationBatch
    {
        private List<RemediationConfiguration> _failedItems = new List<RemediationConfiguration>();
        private string _failureMessage;

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Returns remediation configurations of the failed items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<RemediationConfiguration> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && this._failedItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Returns a failure message. For example, the resource is already compliant.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

    }
}