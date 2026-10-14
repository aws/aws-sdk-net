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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EventBusV2Parameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public EventBusV2Parameters EventBusV2Parameters { get; set; }

        /// <summary>
        /// Checks to see if the EventBusV2Parameters property is set.
        /// </summary>
        internal bool IsSetEventBusV2Parameters() => this.EventBusV2Parameters != null;

        /// <summary>
        /// Gets and sets the property HttpParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public HttpParameters HttpParameters { get; set; }

        /// <summary>
        /// Checks to see if the HttpParameters property is set.
        /// </summary>
        internal bool IsSetHttpParameters() => this.HttpParameters != null;

        /// <summary>
        /// Gets and sets the property KinesisParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public KinesisParameters KinesisParameters { get; set; }

        /// <summary>
        /// Checks to see if the KinesisParameters property is set.
        /// </summary>
        internal bool IsSetKinesisParameters() => this.KinesisParameters != null;

        /// <summary>
        /// Gets and sets the property LambdaParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public LambdaParameters LambdaParameters { get; set; }

        /// <summary>
        /// Checks to see if the LambdaParameters property is set.
        /// </summary>
        internal bool IsSetLambdaParameters() => this.LambdaParameters != null;

        /// <summary>
        /// Gets and sets the property RoleArn. IAM role the service assumes to invoke the target.
        /// Must belong to the calling account.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SnsParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SnsParameters SnsParameters { get; set; }

        /// <summary>
        /// Checks to see if the SnsParameters property is set.
        /// </summary>
        internal bool IsSetSnsParameters() => this.SnsParameters != null;

        /// <summary>
        /// Gets and sets the property SqsParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SqsParameters SqsParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqsParameters property is set.
        /// </summary>
        internal bool IsSetSqsParameters() => this.SqsParameters != null;

        /// <summary>
        /// Gets and sets the property StepFunctionsParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public StepFunctionsParameters StepFunctionsParameters { get; set; }

        /// <summary>
        /// Checks to see if the StepFunctionsParameters property is set.
        /// </summary>
        internal bool IsSetStepFunctionsParameters() => this.StepFunctionsParameters != null;

        /// <summary>
        /// Gets and sets the property TargetArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;

        /// <summary>
        /// Gets and sets the property UniversalTargetParameters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public UniversalTargetParameters UniversalTargetParameters { get; set; }

        /// <summary>
        /// Checks to see if the UniversalTargetParameters property is set.
        /// </summary>
        internal bool IsSetUniversalTargetParameters() => this.UniversalTargetParameters != null;
    }
}
