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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Provides authorization for Amazon to bring a specific IP address range to a specific
    /// Amazon Web Services account using bring your own IP addresses (BYOIP). 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
    /// your own IP addresses (BYOIP)</a> in the <i>Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CidrAuthorizationContext
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The plain-text authorization message for the prefix and account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The signed authorization message for the prefix and account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Signature { get; set; }

        /// <summary>
        /// Checks to see if the Signature property is set.
        /// </summary>
        internal bool IsSetSignature() => this.Signature != null;
    }
}
