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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about the MAC Security (MACsec) secret key.
    /// </summary>
    public partial class MacSecKey
    {
        /// <summary>
        /// Gets and sets the property Ckn. 
        /// <para>
        /// The Connection Key Name (CKN) for the MAC Security secret key.
        /// </para>
        /// </summary>
        public string Ckn { get; set; }

        /// <summary>
        /// Checks to see if the Ckn property is set.
        /// </summary>
        internal bool IsSetCkn() => this.Ckn != null;

        /// <summary>
        /// Gets and sets the property SecretARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MAC Security (MACsec) secret key.
        /// </para>
        /// </summary>
        public string SecretARN { get; set; }

        /// <summary>
        /// Checks to see if the SecretARN property is set.
        /// </summary>
        internal bool IsSetSecretARN() => this.SecretARN != null;

        /// <summary>
        /// Gets and sets the property StartOn. 
        /// <para>
        /// The date that the MAC Security (MACsec) secret key takes effect. The value is displayed
        /// in UTC format.
        /// </para>
        /// </summary>
        public string StartOn { get; set; }

        /// <summary>
        /// Checks to see if the StartOn property is set.
        /// </summary>
        internal bool IsSetStartOn() => this.StartOn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the MAC Security (MACsec) secret key.
        /// </para>
        ///  
        /// <para>
        /// The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>associating</c>: The MAC Security (MACsec) secret key is being validated and not
        /// yet associated with the connection or LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associated</c>: The MAC Security (MACsec) secret key is validated and associated
        /// with the connection or LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociating</c>: The MAC Security (MACsec) secret key is being disassociated
        /// from the connection or LAG
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociated</c>: The MAC Security (MACsec) secret key is no longer associated
        /// with the connection or LAG.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
