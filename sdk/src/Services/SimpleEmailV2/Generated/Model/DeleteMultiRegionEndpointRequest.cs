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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMultiRegionEndpoint operation.
    /// Deletes a multi-region endpoint (global-endpoint).
    /// 
    ///  
    /// <para>
    /// Only multi-region endpoints (global-endpoints) whose primary region is the AWS-Region
    /// where operation is executed can be deleted.
    /// </para>
    /// </summary>
    public partial class DeleteMultiRegionEndpointRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the multi-region endpoint (global-endpoint) to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

    }
}