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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The configuration for the <c>OnPublish</c> and <c>OnSubscribe</c> handlers.
    /// </summary>
    public partial class HandlerConfigs
    {
        /// <summary>
        /// Gets and sets the property OnPublish. 
        /// <para>
        /// The configuration for the <c>OnPublish</c> handler.
        /// </para>
        /// </summary>
        public HandlerConfig OnPublish { get; set; }

        /// <summary>
        /// Checks to see if the OnPublish property is set.
        /// </summary>
        internal bool IsSetOnPublish() => this.OnPublish != null;

        /// <summary>
        /// Gets and sets the property OnSubscribe. 
        /// <para>
        /// The configuration for the <c>OnSubscribe</c> handler.
        /// </para>
        /// </summary>
        public HandlerConfig OnSubscribe { get; set; }

        /// <summary>
        /// Checks to see if the OnSubscribe property is set.
        /// </summary>
        internal bool IsSetOnSubscribe() => this.OnSubscribe != null;
    }
}
