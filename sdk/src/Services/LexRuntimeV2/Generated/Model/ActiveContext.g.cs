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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Contains information about the contexts that a user is using in a session. You can
    /// configure Amazon Lex V2 to set a context when an intent is fulfilled, or you can set
    /// a context using the , , or operations.
    /// 
    ///  
    /// <para>
    /// Use a context to indicate to Amazon Lex V2 intents that should be used as follow-up
    /// intents. For example, if the active context is <c>order-fulfilled</c>, only intents
    /// that have <c>order-fulfilled</c> configured as a trigger are considered for follow
    /// up.
    /// </para>
    /// </summary>
    public partial class ActiveContext
    {
        /// <summary>
        /// Gets and sets the property ContextAttributes. 
        /// <para>
        /// A list of contexts active for the request. A context can be activated when a previous
        /// intent is fulfilled, or by including the context in the request.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a list of contexts, Amazon Lex V2 will use the current list of
        /// contexts for the session. If you specify an empty list, all contexts for the session
        /// are cleared. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public Dictionary<string, string> ContextAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ContextAttributes property is set.
        /// </summary>
        internal bool IsSetContextAttributes() => this.ContextAttributes != null && (this.ContextAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// Indicates the number of turns or seconds that the context is active. Once the time
        /// to live expires, the context is no longer returned in a response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActiveContextTimeToLive TimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the TimeToLive property is set.
        /// </summary>
        internal bool IsSetTimeToLive() => this.TimeToLive != null;
    }
}
