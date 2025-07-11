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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the CreateTicketV2 operation.
    /// </summary>
    public partial class CreateTicketV2Response : AmazonWebServiceResponse
    {
        private string _ticketId;
        private string _ticketSrcUrl;

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// The ID for the ticketv2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TicketId
        {
            get { return this._ticketId; }
            set { this._ticketId = value; }
        }

        // Check to see if TicketId property is set
        internal bool IsSetTicketId()
        {
            return this._ticketId != null;
        }

        /// <summary>
        /// Gets and sets the property TicketSrcUrl. 
        /// <para>
        /// The url to the created ticket.
        /// </para>
        /// </summary>
        public string TicketSrcUrl
        {
            get { return this._ticketSrcUrl; }
            set { this._ticketSrcUrl = value; }
        }

        // Check to see if TicketSrcUrl property is set
        internal bool IsSetTicketSrcUrl()
        {
            return this._ticketSrcUrl != null;
        }

    }
}