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
    /// Container for the parameters to the DescribeConnectionLoa operation. <note> <para>
    /// Deprecated. Use <a>DescribeLoa</a> instead. </para> </note> <para> Gets the LOA-CFA
    /// for a connection. </para> <para> The Letter of Authorization - Connecting Facility
    /// Assignment (LOA-CFA) is a document that your APN partner or service provider uses
    /// when establishing your cross connect to Amazon Web Services at the colocation facility.
    /// For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
    /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeConnectionLoaRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property LoaContentType. 
        /// <para>
        /// The standard media type for the LOA-CFA document. The only supported value is application/pdf.
        /// </para>
        /// </summary>
        public LoaContentType LoaContentType { get; set; }

        /// <summary>
        /// Checks to see if the LoaContentType property is set.
        /// </summary>
        internal bool IsSetLoaContentType() => this.LoaContentType != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the APN partner or service provider who establishes connectivity on your
        /// behalf. If you specify this parameter, the LOA-CFA lists the provider name alongside
        /// your company name as the requester of the cross connect.
        /// </para>
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;
    }
}
