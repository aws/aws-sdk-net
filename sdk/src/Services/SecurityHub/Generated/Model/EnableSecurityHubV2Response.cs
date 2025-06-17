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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the EnableSecurityHubV2 operation.
    /// </summary>
    public partial class EnableSecurityHubV2Response : AmazonWebServiceResponse
    {
        private string _hubV2Arn;

        /// <summary>
        /// Gets and sets the property HubV2Arn. 
        /// <para>
        /// The ARN of the V2 resource that was created.
        /// </para>
        /// </summary>
        public string HubV2Arn
        {
            get { return this._hubV2Arn; }
            set { this._hubV2Arn = value; }
        }

        // Check to see if HubV2Arn property is set
        internal bool IsSetHubV2Arn()
        {
            return this._hubV2Arn != null;
        }

    }
}