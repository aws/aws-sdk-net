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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Information about the latest attempt of a service job. A Service job can transition
    /// from <c>SCHEDULED</c> back to <c>RUNNABLE</c> state when they encounter capacity constraints.
    /// </summary>
    public partial class LatestServiceJobAttempt
    {
        private ServiceResourceId _serviceResourceId;

        /// <summary>
        /// Gets and sets the property ServiceResourceId. 
        /// <para>
        /// The service resource identifier associated with the service job attempt.
        /// </para>
        /// </summary>
        public ServiceResourceId ServiceResourceId
        {
            get { return this._serviceResourceId; }
            set { this._serviceResourceId = value; }
        }

        // Check to see if ServiceResourceId property is set
        internal bool IsSetServiceResourceId()
        {
            return this._serviceResourceId != null;
        }

    }
}