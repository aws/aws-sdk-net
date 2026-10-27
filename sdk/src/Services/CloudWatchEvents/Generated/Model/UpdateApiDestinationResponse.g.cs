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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the UpdateApiDestination operation.
    /// </summary>
    public partial class UpdateApiDestinationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiDestinationArn. 
        /// <para>
        /// The ARN of the API destination that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ApiDestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApiDestinationArn property is set.
        /// </summary>
        internal bool IsSetApiDestinationArn() => this.ApiDestinationArn != null;

        /// <summary>
        /// Gets and sets the property ApiDestinationState. 
        /// <para>
        /// The state of the API destination that was updated.
        /// </para>
        /// </summary>
        public ApiDestinationState ApiDestinationState { get; set; }

        /// <summary>
        /// Checks to see if the ApiDestinationState property is set.
        /// </summary>
        internal bool IsSetApiDestinationState() => this.ApiDestinationState != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp for the time that the API destination was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A time stamp for the time that the API destination was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
