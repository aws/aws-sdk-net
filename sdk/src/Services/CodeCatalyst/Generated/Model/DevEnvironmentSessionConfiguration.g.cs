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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about the configuration of a Dev Environment session.
    /// </summary>
    public partial class DevEnvironmentSessionConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExecuteCommandSessionConfiguration. 
        /// <para>
        /// Information about optional commands that will be run on the Dev Environment when the
        /// SSH session begins.
        /// </para>
        /// </summary>
        public ExecuteCommandSessionConfiguration ExecuteCommandSessionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecuteCommandSessionConfiguration property is set.
        /// </summary>
        internal bool IsSetExecuteCommandSessionConfiguration() => this.ExecuteCommandSessionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionType. 
        /// <para>
        /// The type of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DevEnvironmentSessionType SessionType { get; set; }

        /// <summary>
        /// Checks to see if the SessionType property is set.
        /// </summary>
        internal bool IsSetSessionType() => this.SessionType != null;
    }
}
