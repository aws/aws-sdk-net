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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A complex type containing details about a Suricata rule. Contains:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>SID</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Msg</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Metadata</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Summaries are available for rule groups you manage and for active threat defense Amazon
    /// Web Services managed rule groups.
    /// </para>
    /// </summary>
    public partial class RuleSummary
    {
        private string _metadata;
        private string _msg;
        private string _sid;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The contents of the rule's metadata.
        /// </para>
        /// </summary>
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Msg. 
        /// <para>
        /// The contents taken from the rule's msg field.
        /// </para>
        /// </summary>
        public string Msg
        {
            get { return this._msg; }
            set { this._msg = value; }
        }

        // Check to see if Msg property is set
        internal bool IsSetMsg()
        {
            return this._msg != null;
        }

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        /// The unique identifier (Signature ID) of the Suricata rule.
        /// </para>
        /// </summary>
        public string SID
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if SID property is set
        internal bool IsSetSID()
        {
            return this._sid != null;
        }

    }
}