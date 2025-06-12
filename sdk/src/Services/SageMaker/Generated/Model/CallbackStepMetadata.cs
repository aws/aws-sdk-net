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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata about a callback step.
    /// </summary>
    public partial class CallbackStepMetadata
    {
        private string _callbackToken;
        private List<OutputParameter> _outputParameters = AWSConfigs.InitializeCollections ? new List<OutputParameter>() : null;
        private string _sqsQueueUrl;

        /// <summary>
        /// Gets and sets the property CallbackToken. 
        /// <para>
        /// The pipeline generated token from the Amazon SQS queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string CallbackToken
        {
            get { return this._callbackToken; }
            set { this._callbackToken = value; }
        }

        // Check to see if CallbackToken property is set
        internal bool IsSetCallbackToken()
        {
            return this._callbackToken != null;
        }

        /// <summary>
        /// Gets and sets the property OutputParameters. 
        /// <para>
        /// A list of the output parameters of the callback step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<OutputParameter> OutputParameters
        {
            get { return this._outputParameters; }
            set { this._outputParameters = value; }
        }

        // Check to see if OutputParameters property is set
        internal bool IsSetOutputParameters()
        {
            return this._outputParameters != null && (this._outputParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SqsQueueUrl. 
        /// <para>
        /// The URL of the Amazon Simple Queue Service (Amazon SQS) queue used by the callback
        /// step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SqsQueueUrl
        {
            get { return this._sqsQueueUrl; }
            set { this._sqsQueueUrl = value; }
        }

        // Check to see if SqsQueueUrl property is set
        internal bool IsSetSqsQueueUrl()
        {
            return this._sqsQueueUrl != null;
        }

    }
}