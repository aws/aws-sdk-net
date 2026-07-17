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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of the admin password source configuration for an Autonomous Database.
    /// </summary>
    public partial class AdminPasswordSourceSummary
    {
        private AdminPasswordSource _adminPasswordSource;
        private AdminPasswordSourceConfiguration _adminPasswordSourceConfiguration;

        /// <summary>
        /// Gets and sets the property AdminPasswordSource. 
        /// <para>
        /// The source of the admin password for the Autonomous Database.
        /// </para>
        /// </summary>
        public AdminPasswordSource AdminPasswordSource
        {
            get { return this._adminPasswordSource; }
            set { this._adminPasswordSource = value; }
        }

        // Check to see if AdminPasswordSource property is set
        internal bool IsSetAdminPasswordSource()
        {
            return this._adminPasswordSource != null;
        }

        /// <summary>
        /// Gets and sets the property AdminPasswordSourceConfiguration. 
        /// <para>
        /// The configuration of the admin password source for the Autonomous Database.
        /// </para>
        /// </summary>
        public AdminPasswordSourceConfiguration AdminPasswordSourceConfiguration
        {
            get { return this._adminPasswordSourceConfiguration; }
            set { this._adminPasswordSourceConfiguration = value; }
        }

        // Check to see if AdminPasswordSourceConfiguration property is set
        internal bool IsSetAdminPasswordSourceConfiguration()
        {
            return this._adminPasswordSourceConfiguration != null;
        }

    }
}