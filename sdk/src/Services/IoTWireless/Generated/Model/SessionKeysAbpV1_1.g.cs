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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Session keys for ABP v1.1
    /// </summary>
    public partial class SessionKeysAbpV1_1
    {
        /// <summary>
        /// Gets and sets the property AppSKey. 
        /// <para>
        /// The AppSKey value.
        /// </para>
        /// </summary>
        public string AppSKey { get; set; }

        /// <summary>
        /// Checks to see if the AppSKey property is set.
        /// </summary>
        internal bool IsSetAppSKey() => this.AppSKey != null;

        /// <summary>
        /// Gets and sets the property FNwkSIntKey. 
        /// <para>
        /// The FNwkSIntKey value.
        /// </para>
        /// </summary>
        public string FNwkSIntKey { get; set; }

        /// <summary>
        /// Checks to see if the FNwkSIntKey property is set.
        /// </summary>
        internal bool IsSetFNwkSIntKey() => this.FNwkSIntKey != null;

        /// <summary>
        /// Gets and sets the property NwkSEncKey. 
        /// <para>
        /// The NwkSEncKey value.
        /// </para>
        /// </summary>
        public string NwkSEncKey { get; set; }

        /// <summary>
        /// Checks to see if the NwkSEncKey property is set.
        /// </summary>
        internal bool IsSetNwkSEncKey() => this.NwkSEncKey != null;

        /// <summary>
        /// Gets and sets the property SNwkSIntKey. 
        /// <para>
        /// The SNwkSIntKey value.
        /// </para>
        /// </summary>
        public string SNwkSIntKey { get; set; }

        /// <summary>
        /// Checks to see if the SNwkSIntKey property is set.
        /// </summary>
        internal bool IsSetSNwkSIntKey() => this.SNwkSIntKey != null;
    }
}
