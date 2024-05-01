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
    /// Container for the parameters to the DescribeLoa operation.
    /// Gets the LOA-CFA for a connection, interconnect, or link aggregation group (LAG).
    /// 
    ///  
    /// <para>
    /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
    /// that is used when establishing your cross connect to Amazon Web Services at the colocation
    /// facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
    /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeLoaRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private LoaContentType _loaContentType;
        private string _providerName;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of a connection, LAG, or interconnect.
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
        /// Gets and sets the property LoaContentType. 
        /// <para>
        /// The standard media type for the LOA-CFA document. The only supported value is application/pdf.
        /// </para>
        /// </summary>
        public LoaContentType LoaContentType
        {
            get { return this._loaContentType; }
            set { this._loaContentType = value; }
        }

        // Check to see if LoaContentType property is set
        internal bool IsSetLoaContentType()
        {
            return this._loaContentType != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider who establishes connectivity on your behalf. If you
        /// specify this parameter, the LOA-CFA lists the provider name alongside your company
        /// name as the requester of the cross connect.
        /// </para>
        /// </summary>
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

    }
}