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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// This is the response object from the GetOnClusterAppUIPresignedURL operation.
    /// </summary>
    public partial class GetOnClusterAppUIPresignedURLResponse : AmazonWebServiceResponse
    {
        private string _presignedURL;
        private bool? _presignedURLReady;

        /// <summary>
        /// Gets and sets the property PresignedURL. 
        /// <para>
        /// The cluster's generated presigned URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string PresignedURL
        {
            get { return this._presignedURL; }
            set { this._presignedURL = value; }
        }

        // Check to see if PresignedURL property is set
        internal bool IsSetPresignedURL()
        {
            return this._presignedURL != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedURLReady. 
        /// <para>
        /// Used to determine if the presigned URL is ready.
        /// </para>
        /// </summary>
        public bool? PresignedURLReady
        {
            get { return this._presignedURLReady; }
            set { this._presignedURLReady = value; }
        }

        // Check to see if PresignedURLReady property is set
        internal bool IsSetPresignedURLReady()
        {
            return this._presignedURLReady.HasValue; 
        }

    }
}