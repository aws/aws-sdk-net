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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Credentials for the master user for a domain.
    /// </summary>
    public partial class MasterUserOptions
    {
        /// <summary>
        /// Gets and sets the property MasterUserARN. 
        /// <para>
        /// Amazon Resource Name (ARN) for the master user. Only specify if <c>InternalUserDatabaseEnabled</c>
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string MasterUserARN { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserARN property is set.
        /// </summary>
        internal bool IsSetMasterUserARN() => this.MasterUserARN != null;

        /// <summary>
        /// Gets and sets the property MasterUserName. 
        /// <para>
        /// User name for the master user. Only specify if <c>InternalUserDatabaseEnabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string MasterUserName { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserName property is set.
        /// </summary>
        internal bool IsSetMasterUserName() => this.MasterUserName != null;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// Password for the master user. Only specify if <c>InternalUserDatabaseEnabled</c> is
        /// <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8, Max = 128)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;
    }
}
