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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the UpdateStorageVirtualMachine operation.
    /// </summary>
    public partial class UpdateStorageVirtualMachineResponse : AmazonWebServiceResponse
    {
        private StorageVirtualMachine _storageVirtualMachine;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachine.
        /// </summary>
        public StorageVirtualMachine StorageVirtualMachine
        {
            get { return this._storageVirtualMachine; }
            set { this._storageVirtualMachine = value; }
        }

        // Check to see if StorageVirtualMachine property is set
        internal bool IsSetStorageVirtualMachine()
        {
            return this._storageVirtualMachine != null;
        }

    }
}