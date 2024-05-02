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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// This is the response object from the CreateEventIntegration operation.
    /// </summary>
    public partial class CreateEventIntegrationResponse : AmazonWebServiceResponse
    {
        private string _eventIntegrationArn;

        /// <summary>
        /// Gets and sets the property EventIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event integration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EventIntegrationArn
        {
            get { return this._eventIntegrationArn; }
            set { this._eventIntegrationArn = value; }
        }

        // Check to see if EventIntegrationArn property is set
        internal bool IsSetEventIntegrationArn()
        {
            return this._eventIntegrationArn != null;
        }

    }
}