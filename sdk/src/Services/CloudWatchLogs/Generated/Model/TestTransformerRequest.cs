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
    /// Container for the parameters to the TestTransformer operation.
    /// Use this operation to test a log transformer. You enter the transformer configuration
    /// and a set of log events to test with. The operation responds with an array that includes
    /// the original log events and the transformed versions.
    /// </summary>
    public partial class TestTransformerRequest : AmazonCloudWatchLogsRequest
    {
        private List<string> _logEventMessages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Processor> _transformerConfig = AWSConfigs.InitializeCollections ? new List<Processor>() : null;

        /// <summary>
        /// Gets and sets the property LogEventMessages. 
        /// <para>
        /// An array of the raw log events that you want to use to test this transformer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> LogEventMessages
        {
            get { return this._logEventMessages; }
            set { this._logEventMessages = value; }
        }

        // Check to see if LogEventMessages property is set
        internal bool IsSetLogEventMessages()
        {
            return this._logEventMessages != null && (this._logEventMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransformerConfig. 
        /// <para>
        /// This structure contains the configuration of this log transformer that you want to
        /// test. A log transformer is an array of processors, where each processor applies one
        /// type of transformation to the log events that are ingested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
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