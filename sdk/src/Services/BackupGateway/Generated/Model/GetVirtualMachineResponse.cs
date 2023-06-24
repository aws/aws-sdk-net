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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// This is the response object from the GetVirtualMachine operation.
    /// </summary>
    public partial class GetVirtualMachineResponse : AmazonWebServiceResponse
    {
        private VirtualMachineDetails _virtualMachine;

        /// <summary>
        /// Gets and sets the property VirtualMachine. 
        /// <para>
        /// This object contains the basic attributes of <code>VirtualMachine</code> contained
        /// by the output of <code>GetVirtualMachine</code> 
        /// </para>
        /// </summary>
        public VirtualMachineDetails VirtualMachine
        {
            get { return this._virtualMachine; }
            set { this._virtualMachine = value; }
        }

        // Check to see if VirtualMachine property is set
        internal bool IsSetVirtualMachine()
        {
            return this._virtualMachine != null;
        }

    }
}