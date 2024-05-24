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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties for logging events associated with a member of a Managed
    /// Blockchain network using the Hyperledger Fabric framework.
    /// </summary>
    public partial class MemberFabricLogPublishingConfiguration
    {
        private LogConfigurations _caLogs;

        /// <summary>
        /// Gets and sets the property CaLogs. 
        /// <para>
        /// Configuration properties for logging events associated with a member's Certificate
        /// Authority (CA). CA logs help you determine when a member in your account joins the
        /// network, or when new peers register with a member CA.
        /// </para>
        /// </summary>
        public LogConfigurations CaLogs
        {
            get { return this._caLogs; }
            set { this._caLogs = value; }
        }

        // Check to see if CaLogs property is set
        internal bool IsSetCaLogs()
        {
            return this._caLogs != null;
        }

    }
}