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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides detailed context information for an Engagement. This structure allows for
    /// specifying the type of context and its associated payload.
    /// </summary>
    public partial class EngagementContextDetails
    {
        private EngagementContextPayload _payload;
        private EngagementContextType _type;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Contains the specific details of the Engagement context. The structure of this payload
        /// varies depending on the Type field. 
        /// </para>
        /// </summary>
        public EngagementContextPayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of Engagement context. Valid values are "CustomerProject" or "Document",
        /// indicating whether the context relates to a customer project or a document respectively.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngagementContextType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}