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

namespace Amazon.AccountAccessRuntime.Model
{
    /// <summary>
    /// The temporary credentials returned for a role. Only one member is set, depending on
    /// the type of access that you requested.
    /// </summary>
    public partial class CredentialsDetails
    {
        /// <summary>
        /// Gets and sets the property ProgrammaticAccess. 
        /// <para>
        /// The access key credentials returned for programmatic access with the CLI or an Amazon
        /// Web Services SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ProgrammaticAccessDetails ProgrammaticAccess { get; set; }

        /// <summary>
        /// Checks to see if the ProgrammaticAccess property is set.
        /// </summary>
        internal bool IsSetProgrammaticAccess() => this.ProgrammaticAccess != null;
    }
}
