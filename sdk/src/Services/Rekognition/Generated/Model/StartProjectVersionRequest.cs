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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the StartProjectVersion operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Starts the running of the version of a model. Starting a model takes a while to complete.
    /// To check the current state of the model, use <a>DescribeProjectVersions</a>. 
    /// </para>
    ///  
    /// <para>
    /// Once the model is running, you can detect custom labels in new images by calling <a>DetectCustomLabels</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You are charged for the amount of time that the model is running. To stop a running
    /// model, call <a>StopProjectVersion</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:StartProjectVersion</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartProjectVersionRequest : AmazonRekognitionRequest
    {
        private int? _maxInferenceUnits;
        private int? _minInferenceUnits;
        private string _projectVersionArn;

        /// <summary>
        /// Gets and sets the property MaxInferenceUnits. 
        /// <para>
        /// The maximum number of inference units to use for auto-scaling the model. If you don't
        /// specify a value, Amazon Rekognition Custom Labels doesn't auto-scale the model.
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
        /// hour of processing. 
        /// </para>
        ///  
        /// <para>
        /// Use a higher number to increase the TPS throughput of your model. You are charged
        /// for the number of inference units that you use. 
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
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The Amazon Resource Name(ARN) of the model version that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectVersionArn
        {
            get { return this._projectVersionArn; }
            set { this._projectVersionArn = value; }
        }

        // Check to see if ProjectVersionArn property is set
        internal bool IsSetProjectVersionArn()
        {
            return this._projectVersionArn != null;
        }

    }
}