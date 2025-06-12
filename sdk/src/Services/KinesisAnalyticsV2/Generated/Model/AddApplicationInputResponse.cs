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
    /// This is the response object from the AddApplicationInput operation.
    /// </summary>
    public partial class AddApplicationInputResponse : AmazonWebServiceResponse
    {
        private string _applicationARN;
        private long? _applicationVersionId;
        private List<InputDescription> _inputDescriptions = AWSConfigs.InitializeCollections ? new List<InputDescription>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
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
        /// Provides the current application version.
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
        /// Gets and sets the property InputDescriptions. 
        /// <para>
        /// Describes the application input configuration. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDescription> InputDescriptions
        {
            get { return this._inputDescriptions; }
            set { this._inputDescriptions = value; }
        }

        // Check to see if InputDescriptions property is set
        internal bool IsSetInputDescriptions()
        {
            return this._inputDescriptions != null && (this._inputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}