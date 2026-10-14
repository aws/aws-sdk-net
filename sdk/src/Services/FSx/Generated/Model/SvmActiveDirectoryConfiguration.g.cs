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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes the Microsoft Active Directory (AD) directory configuration to which the
    /// FSx for ONTAP storage virtual machine (SVM) is joined. Note that account credentials
    /// are not returned in the response payload.
    /// </summary>
    public partial class SvmActiveDirectoryConfiguration
    {
        /// <summary>
        /// Gets and sets the property NetBiosName. 
        /// <para>
        /// The NetBIOS name of the AD computer object to which the SVM is joined.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string NetBiosName { get; set; }

        /// <summary>
        /// Checks to see if the NetBiosName property is set.
        /// </summary>
        internal bool IsSetNetBiosName() => this.NetBiosName != null;

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryAttributes SelfManagedActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedActiveDirectoryConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedActiveDirectoryConfiguration() => this.SelfManagedActiveDirectoryConfiguration != null;
    }
}
