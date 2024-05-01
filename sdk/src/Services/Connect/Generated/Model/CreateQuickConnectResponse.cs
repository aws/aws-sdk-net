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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateQuickConnect operation.
    /// </summary>
    public partial class CreateQuickConnectResponse : AmazonWebServiceResponse
    {
        private string _quickConnectARN;
        private string _quickConnectId;

        /// <summary>
        /// Gets and sets the property QuickConnectARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the quick connect. 
        /// </para>
        /// </summary>
        public string QuickConnectARN
        {
            get { return this._quickConnectARN; }
            set { this._quickConnectARN = value; }
        }

        // Check to see if QuickConnectARN property is set
        internal bool IsSetQuickConnectARN()
        {
            return this._quickConnectARN != null;
        }

        /// <summary>
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        /// The identifier for the quick connect. 
        /// </para>
        /// </summary>
        public string QuickConnectId
        {
            get { return this._quickConnectId; }
            set { this._quickConnectId = value; }
        }

        // Check to see if QuickConnectId property is set
        internal bool IsSetQuickConnectId()
        {
            return this._quickConnectId != null;
        }

    }
}