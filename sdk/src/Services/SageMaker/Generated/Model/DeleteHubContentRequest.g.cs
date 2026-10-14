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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHubContent operation. Delete the contents
    /// of a hub.
    /// </summary>
    public partial class DeleteHubContentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the content that you want to delete from a hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string HubContentName { get; set; }

        /// <summary>
        /// Checks to see if the HubContentName property is set.
        /// </summary>
        internal bool IsSetHubContentName() => this.HubContentName != null;

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The type of content that you want to delete from a hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HubContentType HubContentType { get; set; }

        /// <summary>
        /// Checks to see if the HubContentType property is set.
        /// </summary>
        internal bool IsSetHubContentType() => this.HubContentType != null;

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The version of the content that you want to delete from a hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 14)]
        public string HubContentVersion { get; set; }

        /// <summary>
        /// Checks to see if the HubContentVersion property is set.
        /// </summary>
        internal bool IsSetHubContentVersion() => this.HubContentVersion != null;

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub that you want to delete content in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;
    }
}
