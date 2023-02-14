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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the CancelInstanceRefresh operation.
    /// </summary>
    public partial class CancelInstanceRefreshResponse : AmazonWebServiceResponse
    {
        private string _instanceRefreshId;

        /// <summary>
        /// Gets and sets the property InstanceRefreshId. 
        /// <para>
        /// The instance refresh ID associated with the request. This is the unique ID assigned
        /// to the instance refresh when it was started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InstanceRefreshId
        {
            get { return this._instanceRefreshId; }
            set { this._instanceRefreshId = value; }
        }

        // Check to see if InstanceRefreshId property is set
        internal bool IsSetInstanceRefreshId()
        {
            return this._instanceRefreshId != null;
        }

    }
}