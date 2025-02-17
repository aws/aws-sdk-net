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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetSerialConsoleAccessStatus operation.
    /// </summary>
    public partial class GetSerialConsoleAccessStatusResponse : AmazonWebServiceResponse
    {
        private ManagedBy _managedBy;
        private bool? _serialConsoleAccessEnabled;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages access to the serial console. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - Access is managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - Access is managed by a declarative policy and can't be
        /// modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property SerialConsoleAccessEnabled. 
        /// <para>
        /// If <c>true</c>, access to the EC2 serial console of all instances is enabled for your
        /// account. If <c>false</c>, access to the EC2 serial console of all instances is disabled
        /// for your account.
        /// </para>
        /// </summary>
        public bool SerialConsoleAccessEnabled
        {
            get { return this._serialConsoleAccessEnabled.GetValueOrDefault(); }
            set { this._serialConsoleAccessEnabled = value; }
        }

        // Check to see if SerialConsoleAccessEnabled property is set
        internal bool IsSetSerialConsoleAccessEnabled()
        {
            return this._serialConsoleAccessEnabled.HasValue; 
        }

    }
}