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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the ARN's of a SageMaker AI image and SageMaker AI image version, and the
    /// instance type that the version runs on.
    /// 
    ///  <note> 
    /// <para>
    /// When both <c>SageMakerImageVersionArn</c> and <c>SageMakerImageArn</c> are passed,
    /// <c>SageMakerImageVersionArn</c> is used. Any updates to <c>SageMakerImageArn</c> will
    /// not take effect if <c>SageMakerImageVersionArn</c> already exists in the <c>ResourceSpec</c>
    /// because <c>SageMakerImageVersionArn</c> always takes precedence. To clear the value
    /// set for <c>SageMakerImageVersionArn</c>, pass <c>None</c> as the value.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResourceSpec
    {
        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type that the image version runs on.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>JupyterServer apps</b> only support the <c>system</c> value.
        /// </para>
        ///  
        /// <para>
        /// For <b>KernelGateway apps</b>, the <c>system</c> value is translated to <c>ml.t3.medium</c>.
        /// KernelGateway apps also support all other values for available instance types.
        /// </para>
        ///  </note>
        /// </summary>
        public AppInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfigArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LifecycleConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfigArn property is set.
        /// </summary>
        internal bool IsSetLifecycleConfigArn() => this.LifecycleConfigArn != null;

        /// <summary>
        /// Gets and sets the property SageMakerImageArn. 
        /// <para>
        /// The ARN of the SageMaker AI image that the image version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SageMakerImageArn { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerImageArn property is set.
        /// </summary>
        internal bool IsSetSageMakerImageArn() => this.SageMakerImageArn != null;

        /// <summary>
        /// Gets and sets the property SageMakerImageVersionAlias. 
        /// <para>
        /// The SageMakerImageVersionAlias of the image to launch with. This value is in SemVer
        /// 2.0.0 versioning format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SageMakerImageVersionAlias { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerImageVersionAlias property is set.
        /// </summary>
        internal bool IsSetSageMakerImageVersionAlias() => this.SageMakerImageVersionAlias != null;

        /// <summary>
        /// Gets and sets the property SageMakerImageVersionArn. 
        /// <para>
        /// The ARN of the image version created on the instance. To clear the value set for <c>SageMakerImageVersionArn</c>,
        /// pass <c>None</c> as the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SageMakerImageVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerImageVersionArn property is set.
        /// </summary>
        internal bool IsSetSageMakerImageVersionArn() => this.SageMakerImageVersionArn != null;

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The ARN of the SageMaker AI Training Plan to use for this app. When you specify a
        /// training plan, the app launches on reserved GPU capacity. This field is supported
        /// for JupyterLab and CodeEditor app types.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity with SageMaker AI Training
        /// Plans, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/training-plan-utilization-for-studio-apps.html">Using
        /// training plans in Studio applications</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;
    }
}
