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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Lifecycle hook configuration for MicroVMs and MicroVM images.
    /// </summary>
    public partial class Hooks
    {
        /// <summary>
        /// Gets and sets the property MicrovmHooks. 
        /// <para>
        /// The lifecycle hooks for MicroVM events.
        /// </para>
        /// </summary>
        public MicrovmHooks MicrovmHooks { get; set; }

        /// <summary>
        /// Checks to see if the MicrovmHooks property is set.
        /// </summary>
        internal bool IsSetMicrovmHooks() => this.MicrovmHooks != null;

        /// <summary>
        /// Gets and sets the property MicrovmImageHooks. 
        /// <para>
        /// The hooks for MicroVM image build events.
        /// </para>
        /// </summary>
        public MicrovmImageHooks MicrovmImageHooks { get; set; }

        /// <summary>
        /// Checks to see if the MicrovmImageHooks property is set.
        /// </summary>
        internal bool IsSetMicrovmImageHooks() => this.MicrovmImageHooks != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the hooks listener runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
