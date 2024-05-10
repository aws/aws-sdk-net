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
    /// This is the response object from the AddApplicationInputProcessingConfiguration operation.
    /// </summary>
    public partial class AddApplicationInputProcessingConfigurationResponse : AmazonWebServiceResponse
    {
        private string _applicationARN;
        private long? _applicationVersionId;
        private string _inputId;
        private InputProcessingConfigurationDescription _inputProcessingConfigurationDescription;

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
        /// Gets and sets the property InputId. 
        /// <para>
        /// The input ID that is associated with the application input. This is the ID that Kinesis
        /// Data Analytics assigns to each input configuration that you add to your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        // Check to see if InputId property is set
        internal bool IsSetInputId()
        {
            return this._inputId != null;
        }

        /// <summary>
        /// Gets and sets the property InputProcessingConfigurationDescription. 
        /// <para>
        /// The description of the preprocessor that executes on records in this input before
        /// the application's code is run.
        /// </para>
        /// </summary>
        public InputProcessingConfigurationDescription InputProcessingConfigurationDescription
        {
            get { return this._inputProcessingConfigurationDescription; }
            set { this._inputProcessingConfigurationDescription = value; }
        }

        // Check to see if InputProcessingConfigurationDescription property is set
        internal bool IsSetInputProcessingConfigurationDescription()
        {
            return this._inputProcessingConfigurationDescription != null;
        }

    }
}