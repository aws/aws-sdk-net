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
    /// Container for the parameters to the AssociateMacSecKey operation.
    /// Associates a MAC Security (MACsec) Connection Key Name (CKN)/ Connectivity Association
    /// Key (CAK) pair with a Direct Connect connection.
    /// 
    ///  
    /// <para>
    /// You must supply either the <c>secretARN,</c> or the CKN/CAK (<c>ckn</c> and <c>cak</c>)
    /// pair in the request.
    /// </para>
    ///  
    /// <para>
    /// For information about MAC Security (MACsec) key considerations, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/direct-connect-mac-sec-getting-started.html#mac-sec-key-consideration">MACsec
    /// pre-shared CKN/CAK key considerations </a> in the <i>Direct Connect User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateMacSecKeyRequest : AmazonDirectConnectRequest
    {
        private string _cak;
        private string _ckn;
        private string _connectionId;
        private string _secretarn;

        /// <summary>
        /// Gets and sets the property Cak. 
        /// <para>
        /// The MAC Security (MACsec) CAK to associate with the connection.
        /// </para>
        ///  
        /// <para>
        /// You can create the CKN/CAK pair using an industry standard tool.
        /// </para>
        ///  
        /// <para>
        ///  The valid values are 64 hexadecimal characters (0-9, A-E).
        /// </para>
        ///  
        /// <para>
        /// If you use this request parameter, you must use the <c>ckn</c> request parameter and
        /// not use the <c>secretARN</c> request parameter.
        /// </para>
        /// </summary>
        public string Cak
        {
            get { return this._cak; }
            set { this._cak = value; }
        }

        // Check to see if Cak property is set
        internal bool IsSetCak()
        {
            return this._cak != null;
        }

        /// <summary>
        /// Gets and sets the property Ckn. 
        /// <para>
        /// The MAC Security (MACsec) CKN to associate with the connection.
        /// </para>
        ///  
        /// <para>
        /// You can create the CKN/CAK pair using an industry standard tool.
        /// </para>
        ///  
        /// <para>
        ///  The valid values are 64 hexadecimal characters (0-9, A-E).
        /// </para>
        ///  
        /// <para>
        /// If you use this request parameter, you must use the <c>cak</c> request parameter and
        /// not use the <c>secretARN</c> request parameter.
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
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the dedicated connection (dxcon-xxxx), interconnect (dxcon-xxxx), or LAG
        /// (dxlag-xxxx).
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeConnections</a>, <a>DescribeInterconnects</a>, or <a>DescribeLags</a>
        /// to retrieve connection ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MAC Security (MACsec) secret key to associate
        /// with the connection.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeConnections</a> or <a>DescribeLags</a> to retrieve the MAC
        /// Security (MACsec) secret key.
        /// </para>
        ///  
        /// <para>
        /// If you use this request parameter, you do not use the <c>ckn</c> and <c>cak</c> request
        /// parameters.
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

    }
}