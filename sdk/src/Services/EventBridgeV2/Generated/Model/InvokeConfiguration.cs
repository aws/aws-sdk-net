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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Configuration for how the subscriber invokes its target.
    /// </summary>
    public partial class InvokeConfiguration
    {
        private EventBusV2Parameters _eventBusV2Parameters;
        private HttpParameters _httpParameters;
        private KinesisParameters _kinesisParameters;
        private LambdaParameters _lambdaParameters;
        private string _roleArn;
        private SnsParameters _snsParameters;
        private SqsParameters _sqsParameters;
        private StepFunctionsParameters _stepFunctionsParameters;
        private string _targetArn;
        private UniversalTargetParameters _universalTargetParameters;

        /// <summary>
        /// Gets and sets the property EventBusV2Parameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public EventBusV2Parameters EventBusV2Parameters
        {
            get { return this._eventBusV2Parameters; }
            set { this._eventBusV2Parameters = value; }
        }

        // Check to see if EventBusV2Parameters property is set
        internal bool IsSetEventBusV2Parameters()
        {
            return this._eventBusV2Parameters != null;
        }

        /// <summary>
        /// Gets and sets the property HttpParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public HttpParameters HttpParameters
        {
            get { return this._httpParameters; }
            set { this._httpParameters = value; }
        }

        // Check to see if HttpParameters property is set
        internal bool IsSetHttpParameters()
        {
            return this._httpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public KinesisParameters KinesisParameters
        {
            get { return this._kinesisParameters; }
            set { this._kinesisParameters = value; }
        }

        // Check to see if KinesisParameters property is set
        internal bool IsSetKinesisParameters()
        {
            return this._kinesisParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public LambdaParameters LambdaParameters
        {
            get { return this._lambdaParameters; }
            set { this._lambdaParameters = value; }
        }

        // Check to see if LambdaParameters property is set
        internal bool IsSetLambdaParameters()
        {
            return this._lambdaParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// IAM role the service assumes to invoke the target. Must belong to the calling account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SnsParameters SnsParameters
        {
            get { return this._snsParameters; }
            set { this._snsParameters = value; }
        }

        // Check to see if SnsParameters property is set
        internal bool IsSetSnsParameters()
        {
            return this._snsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SqsParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SqsParameters SqsParameters
        {
            get { return this._sqsParameters; }
            set { this._sqsParameters = value; }
        }

        // Check to see if SqsParameters property is set
        internal bool IsSetSqsParameters()
        {
            return this._sqsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property StepFunctionsParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public StepFunctionsParameters StepFunctionsParameters
        {
            get { return this._stepFunctionsParameters; }
            set { this._stepFunctionsParameters = value; }
        }

        // Check to see if StepFunctionsParameters property is set
        internal bool IsSetStepFunctionsParameters()
        {
            return this._stepFunctionsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property UniversalTargetParameters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public UniversalTargetParameters UniversalTargetParameters
        {
            get { return this._universalTargetParameters; }
            set { this._universalTargetParameters = value; }
        }

        // Check to see if UniversalTargetParameters property is set
        internal bool IsSetUniversalTargetParameters()
        {
            return this._universalTargetParameters != null;
        }

    }
}