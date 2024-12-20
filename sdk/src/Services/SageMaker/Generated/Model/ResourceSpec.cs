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
    /// Specifies the ARN's of a SageMaker AI image and SageMaker AI image version, and the
    /// instance type that the version runs on.
    /// </summary>
    public partial class ResourceSpec
    {
        private AppInstanceType _instanceType;
        private string _lifecycleConfigArn;
        private string _sageMakerImageArn;
        private string _sageMakerImageVersionAlias;
        private string _sageMakerImageVersionArn;

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
        public AppInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleConfigArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lifecycle Configuration attached to the Resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LifecycleConfigArn
        {
            get { return this._lifecycleConfigArn; }
            set { this._lifecycleConfigArn = value; }
        }

        // Check to see if LifecycleConfigArn property is set
        internal bool IsSetLifecycleConfigArn()
        {
            return this._lifecycleConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerImageArn. 
        /// <para>
        /// The ARN of the SageMaker AI image that the image version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SageMakerImageArn
        {
            get { return this._sageMakerImageArn; }
            set { this._sageMakerImageArn = value; }
        }

        // Check to see if SageMakerImageArn property is set
        internal bool IsSetSageMakerImageArn()
        {
            return this._sageMakerImageArn != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerImageVersionAlias. 
        /// <para>
        /// The SageMakerImageVersionAlias of the image to launch with. This value is in SemVer
        /// 2.0.0 versioning format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SageMakerImageVersionAlias
        {
            get { return this._sageMakerImageVersionAlias; }
            set { this._sageMakerImageVersionAlias = value; }
        }

        // Check to see if SageMakerImageVersionAlias property is set
        internal bool IsSetSageMakerImageVersionAlias()
        {
            return this._sageMakerImageVersionAlias != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerImageVersionArn. 
        /// <para>
        /// The ARN of the image version created on the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SageMakerImageVersionArn
        {
            get { return this._sageMakerImageVersionArn; }
            set { this._sageMakerImageVersionArn = value; }
        }

        // Check to see if SageMakerImageVersionArn property is set
        internal bool IsSetSageMakerImageVersionArn()
        {
            return this._sageMakerImageVersionArn != null;
        }

    }
}