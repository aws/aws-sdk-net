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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property QuickConnectARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the quick connect. 
        /// </para>
        /// </summary>
        public string QuickConnectARN { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectARN property is set.
        /// </summary>
        internal bool IsSetQuickConnectARN() => this.QuickConnectARN != null;

        /// <summary>
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        /// The identifier for the quick connect. 
        /// </para>
        /// </summary>
        public string QuickConnectId { get; set; }

        /// <summary>
        /// Checks to see if the QuickConnectId property is set.
        /// </summary>
        internal bool IsSetQuickConnectId() => this.QuickConnectId != null;
    }
}
