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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// This is the response object from the AddApplicationOutput operation.
    /// </summary>
    public partial class AddApplicationOutputResponse : AmazonWebServiceResponse
    {
        private string _applicationARN;
        private long? _applicationVersionId;
        private List<OutputDescription> _outputDescriptions = AWSConfigs.InitializeCollections ? new List<OutputDescription>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The application Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationARN
        {
            get { return this._applicationARN; }
            set { this._applicationARN = value; }
        }

        // Check to see if ApplicationARN property is set
        internal bool IsSetApplicationARN()
        {
            return this._applicationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The updated application version ID. Kinesis Data Analytics increments this ID when
        /// the application is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long? ApplicationVersionId
        {
            get { return this._applicationVersionId; }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDescriptions. 
        /// <para>
        /// Describes the application output configuration. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Configuring
        /// Application Output</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDescription> OutputDescriptions
        {
            get { return this._outputDescriptions; }
            set { this._outputDescriptions = value; }
        }

        // Check to see if OutputDescriptions property is set
        internal bool IsSetOutputDescriptions()
        {
            return this._outputDescriptions != null && (this._outputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}