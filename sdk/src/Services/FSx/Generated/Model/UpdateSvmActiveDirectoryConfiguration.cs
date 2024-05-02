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
    /// Specifies updates to an FSx for ONTAP storage virtual machine's (SVM) Microsoft Active
    /// Directory (AD) configuration. Note that account credentials are not returned in the
    /// response payload.
    /// </summary>
    public partial class UpdateSvmActiveDirectoryConfiguration
    {
        private string _netBiosName;
        private SelfManagedActiveDirectoryConfigurationUpdates _selfManagedActiveDirectoryConfiguration;

        /// <summary>
        /// Gets and sets the property NetBiosName. 
        /// <para>
        /// Specifies an updated NetBIOS name of the AD computer object <c>NetBiosName</c> to
        /// which an SVM is joined.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string NetBiosName
        {
            get { return this._netBiosName; }
            set { this._netBiosName = value; }
        }

        // Check to see if NetBiosName property is set
        internal bool IsSetNetBiosName()
        {
            return this._netBiosName != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryConfigurationUpdates SelfManagedActiveDirectoryConfiguration
        {
            get { return this._selfManagedActiveDirectoryConfiguration; }
            set { this._selfManagedActiveDirectoryConfiguration = value; }
        }

        // Check to see if SelfManagedActiveDirectoryConfiguration property is set
        internal bool IsSetSelfManagedActiveDirectoryConfiguration()
        {
            return this._selfManagedActiveDirectoryConfiguration != null;
        }

    }
}