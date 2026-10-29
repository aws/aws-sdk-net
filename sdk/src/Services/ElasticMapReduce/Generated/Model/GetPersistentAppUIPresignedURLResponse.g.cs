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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the GetPersistentAppUIPresignedURL operation.
    /// </summary>
    public partial class GetPersistentAppUIPresignedURLResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PresignedURL. 
        /// <para>
        /// The returned presigned URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string PresignedURL { get; set; }

        /// <summary>
        /// Checks to see if the PresignedURL property is set.
        /// </summary>
        internal bool IsSetPresignedURL() => this.PresignedURL != null;

        /// <summary>
        /// Gets and sets the property PresignedURLReady. 
        /// <para>
        /// Used to determine if the presigned URL is ready.
        /// </para>
        /// </summary>
        public bool? PresignedURLReady { get; set; }

        /// <summary>
        /// Checks to see if the PresignedURLReady property is set.
        /// </summary>
        internal bool IsSetPresignedURLReady() => this.PresignedURLReady.HasValue;
    }
}
