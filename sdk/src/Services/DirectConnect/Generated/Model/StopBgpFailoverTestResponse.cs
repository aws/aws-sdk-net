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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the StopBgpFailoverTest operation.
    /// </summary>
    public partial class StopBgpFailoverTestResponse : AmazonWebServiceResponse
    {
        private VirtualInterfaceTestHistory _virtualInterfaceTest;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceTest. 
        /// <para>
        /// Information about the virtual interface failover test.
        /// </para>
        /// </summary>
        public VirtualInterfaceTestHistory VirtualInterfaceTest
        {
            get { return this._virtualInterfaceTest; }
            set { this._virtualInterfaceTest = value; }
        }

        // Check to see if VirtualInterfaceTest property is set
        internal bool IsSetVirtualInterfaceTest()
        {
            return this._virtualInterfaceTest != null;
        }

    }
}