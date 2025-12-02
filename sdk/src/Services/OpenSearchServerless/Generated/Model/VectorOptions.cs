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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Configuration options for vector search capabilities in an OpenSearch Serverless collection.
    /// </summary>
    public partial class VectorOptions
    {
        private ServerlessVectorAccelerationStatus _serverlessVectorAcceleration;

        /// <summary>
        /// Gets and sets the property ServerlessVectorAcceleration. 
        /// <para>
        /// Specifies whether serverless vector acceleration is enabled for the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerlessVectorAccelerationStatus ServerlessVectorAcceleration
        {
            get { return this._serverlessVectorAcceleration; }
            set { this._serverlessVectorAcceleration = value; }
        }

        // Check to see if ServerlessVectorAcceleration property is set
        internal bool IsSetServerlessVectorAcceleration()
        {
            return this._serverlessVectorAcceleration != null;
        }

    }
}