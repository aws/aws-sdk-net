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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Specifies the user and group whose permissions are used when running the Lambda function.
    /// You can specify one or both values to override the default values. We recommend that
    /// you avoid running as root unless absolutely necessary to minimize the risk of unintended
    /// changes or malicious attacks. To run as root, you must set ''IsolationMode'' to ''NoContainer''
    /// and update config.json in ''greengrass-root/config'' to set ''allowFunctionsToRunAsRoot''
    /// to ''yes''.
    /// </summary>
    public partial class FunctionRunAsConfig
    {
        /// <summary>
        /// Gets and sets the property Gid. The group ID whose permissions are used to run a Lambda
        /// function.
        /// </summary>
        public int? Gid { get; set; }

        /// <summary>
        /// Checks to see if the Gid property is set.
        /// </summary>
        internal bool IsSetGid() => this.Gid.HasValue;

        /// <summary>
        /// Gets and sets the property Uid. The user ID whose permissions are used to run a Lambda
        /// function.
        /// </summary>
        public int? Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid.HasValue;
    }
}
