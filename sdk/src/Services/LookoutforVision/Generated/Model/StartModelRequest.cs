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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the StartModel operation.
    /// Starts the running of the version of an Amazon Lookout for Vision model. Starting
    /// a model takes a while to complete. To check the current state of the model, use <a>DescribeModel</a>.
    /// 
    ///  
    /// <para>
    /// A model is ready to use when its status is <c>HOSTED</c>.
    /// </para>
    ///  
    /// <para>
    /// Once the model is running, you can detect custom labels in new images by calling <a>DetectAnomalies</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You are charged for the amount of time that the model is running. To stop a running
    /// model, call <a>StopModel</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:StartModel</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class StartModelRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private int? _maxInferenceUnits;
        private int? _minInferenceUnits;
        private string _modelVersion;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <c>StartModel</c> completes
        /// only once. You choose the value to pass. For example, An issue might prevent you from
        /// getting a response from <c>StartModel</c>. In this case, safely retry your call to
        /// <c>StartModel</c> by using the same <c>ClientToken</c> parameter value. 
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <c>ClientToken</c>, the AWS SDK you are using inserts
        /// a value for you. This prevents retries after a network error from making multiple
        /// start requests. You'll need to provide your own value for other use cases. 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <c>ClientToken</c> is considered a new call to <c>StartModel</c>.
        /// An idempotency token is active for 8 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property MaxInferenceUnits. 
        /// <para>
        /// The maximum number of inference units to use for auto-scaling the model. If you don't
        /// specify a value, Amazon Lookout for Vision doesn't auto-scale the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxInferenceUnits
        {
            get { return this._maxInferenceUnits; }
            set { this._maxInferenceUnits = value; }
        }

        // Check to see if MaxInferenceUnits property is set
        internal bool IsSetMaxInferenceUnits()
        {
            return this._maxInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinInferenceUnits. 
        /// <para>
        /// The minimum number of inference units to use. A single inference unit represents 1
        /// hour of processing. Use a higher number to increase the TPS throughput of your model.
        /// You are charged for the number of inference units that you use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MinInferenceUnits
        {
            get { return this._minInferenceUnits; }
            set { this._minInferenceUnits = value; }
        }

        // Check to see if MinInferenceUnits property is set
        internal bool IsSetMinInferenceUnits()
        {
            return this._minInferenceUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the model that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}