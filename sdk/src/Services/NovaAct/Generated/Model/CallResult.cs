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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// The result returned from executing a tool call.
    /// </summary>
    public partial class CallResult
    {
        private string _callId;
        private List<CallResultContent> _content = AWSConfigs.InitializeCollections ? new List<CallResultContent>() : null;

        /// <summary>
        /// Gets and sets the property CallId. 
        /// <para>
        /// The identifier of the tool call that this result corresponds to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string CallId
        {
            get { return this._callId; }
            set { this._callId = value; }
        }

        // Check to see if CallId property is set
        internal bool IsSetCallId()
        {
            return this._callId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content returned by the tool execution, which can include text or other media
        /// types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<CallResultContent> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}