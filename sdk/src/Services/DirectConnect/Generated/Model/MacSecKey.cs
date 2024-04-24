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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
        private string _ckn;
        private string _secretarn;
        private string _startOn;
        private string _state;

        /// <summary>
        /// Gets and sets the property Ckn. 
        /// <para>
        /// The Connection Key Name (CKN) for the MAC Security secret key.
        /// </para>
        /// </summary>
        public string Ckn
        {
            get { return this._ckn; }
            set { this._ckn = value; }
        }

        // Check to see if Ckn property is set
        internal bool IsSetCkn()
        {
            return this._ckn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MAC Security (MACsec) secret key.
        /// </para>
        /// </summary>
        public string SecretARN
        {
            get { return this._secretarn; }
            set { this._secretarn = value; }
        }

        // Check to see if SecretARN property is set
        internal bool IsSetSecretARN()
        {
            return this._secretarn != null;
        }

        /// <summary>
        /// Gets and sets the property StartOn. 
        /// <para>
        /// The date that the MAC Security (MACsec) secret key takes effect. The value is displayed
        /// in UTC format.
        /// </para>
        /// </summary>
        public string StartOn
        {
            get { return this._startOn; }
            set { this._startOn = value; }
        }

        // Check to see if StartOn property is set
        internal bool IsSetStartOn()
        {
            return this._startOn != null;
        }

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
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}