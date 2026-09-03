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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The transport parameters that you want to associate with an incoming media stream.
    /// </summary>
    public partial class InputConfigurationRequest
    {
        /// <summary>
        /// Gets and sets the property InputPort. 
        /// <para>
        ///  The port that you want the flow to listen on for an incoming media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InputPort { get; set; }

        /// <summary>
        /// Checks to see if the InputPort property is set.
        /// </summary>
        internal bool IsSetInputPort() => this.InputPort.HasValue;

        /// <summary>
        /// Gets and sets the property Interface. 
        /// <para>
        ///  The VPC interface that you want to use for the incoming media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InterfaceRequest Interface { get; set; }

        /// <summary>
        /// Checks to see if the Interface property is set.
        /// </summary>
        internal bool IsSetInterface() => this.Interface != null;
    }
}
