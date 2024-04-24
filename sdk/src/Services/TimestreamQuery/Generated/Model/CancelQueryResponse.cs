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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// This is the response object from the CancelQuery operation.
    /// </summary>
    public partial class CancelQueryResponse : AmazonWebServiceResponse
    {
        private string _cancellationMessage;

        /// <summary>
        /// Gets and sets the property CancellationMessage. 
        /// <para>
        ///  A <c>CancellationMessage</c> is returned when a <c>CancelQuery</c> request for the
        /// query specified by <c>QueryId</c> has already been issued. 
        /// </para>
        /// </summary>
        public string CancellationMessage
        {
            get { return this._cancellationMessage; }
            set { this._cancellationMessage = value; }
        }

        // Check to see if CancellationMessage property is set
        internal bool IsSetCancellationMessage()
        {
            return this._cancellationMessage != null;
        }

    }
}