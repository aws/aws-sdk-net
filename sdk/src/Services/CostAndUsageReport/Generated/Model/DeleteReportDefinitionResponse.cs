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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
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
namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// If the action is successful, the service sends back an HTTP 200 response.
    /// </summary>
    public partial class DeleteReportDefinitionResponse : AmazonWebServiceResponse
    {
        private string _responseMessage;

        /// <summary>
        /// Gets and sets the property ResponseMessage.
        /// </summary>
        public string ResponseMessage
        {
            get { return this._responseMessage; }
            set { this._responseMessage = value; }
        }

        // Check to see if ResponseMessage property is set
        internal bool IsSetResponseMessage()
        {
            return this._responseMessage != null;
        }

    }
}