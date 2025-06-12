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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetTransformer operation.
    /// </summary>
    public partial class GetTransformerResponse : AmazonWebServiceResponse
    {
        private long? _creationTime;
        private long? _lastModifiedTime;
        private string _logGroupIdentifier;
        private List<Processor> _transformerConfig = AWSConfigs.InitializeCollections ? new List<Processor>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the transformer, expressed as the number of milliseconds after
        /// Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when this transformer was most recently modified, expressed as the
        /// number of milliseconds after Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// The ARN of the log group that you specified in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerConfig. 
        /// <para>
        /// This sructure contains the configuration of the requested transformer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<Processor> TransformerConfig
        {
            get { return this._transformerConfig; }
            set { this._transformerConfig = value; }
        }

        // Check to see if TransformerConfig property is set
        internal bool IsSetTransformerConfig()
        {
            return this._transformerConfig != null && (this._transformerConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}