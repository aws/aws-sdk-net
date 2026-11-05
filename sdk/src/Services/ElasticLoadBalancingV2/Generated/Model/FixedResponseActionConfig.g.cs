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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an action that returns a custom HTTP response.
    /// </summary>
    public partial class FixedResponseActionConfig
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: text/plain | text/css | text/html | application/javascript | application/json
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MessageBody { get; set; }

        /// <summary>
        /// Checks to see if the MessageBody property is set.
        /// </summary>
        internal bool IsSetMessageBody() => this.MessageBody != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP response code (2XX, 4XX, or 5XX).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;
    }
}
