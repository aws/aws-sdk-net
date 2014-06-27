/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStreamingDistribution operation.
    /// Update a streaming distribution.
    /// </summary>
    public partial class UpdateStreamingDistributionRequest : AmazonWebServiceRequest
    {
        private string _id;
        private string _ifMatch;
        private StreamingDistributionConfig _streamingDistributionConfig;


        /// <summary>
        /// Gets and sets the property Id. The streaming distribution's id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStreamingDistributionRequest WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }


        /// <summary>
        /// Gets and sets the property IfMatch. The value of the ETag header you received when
        /// retrieving the streaming distribution's configuration. For example: E2QWRUHAPOMQZL.
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }


        /// <summary>
        /// Sets the IfMatch property
        /// </summary>
        /// <param name="ifMatch">The value to set for the IfMatch property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStreamingDistributionRequest WithIfMatch(string ifMatch)
        {
            this._ifMatch = ifMatch;
            return this;
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }


        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. The streaming distribution's
        /// configuration information.
        /// </summary>
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this._streamingDistributionConfig; }
            set { this._streamingDistributionConfig = value; }
        }


        /// <summary>
        /// Sets the StreamingDistributionConfig property
        /// </summary>
        /// <param name="streamingDistributionConfig">The value to set for the StreamingDistributionConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStreamingDistributionRequest WithStreamingDistributionConfig(StreamingDistributionConfig streamingDistributionConfig)
        {
            this._streamingDistributionConfig = streamingDistributionConfig;
            return this;
        }

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this._streamingDistributionConfig != null;
        }

    }
}