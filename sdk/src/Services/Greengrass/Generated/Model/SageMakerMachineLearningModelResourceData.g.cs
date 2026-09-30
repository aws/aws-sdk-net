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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Attributes that define an Amazon SageMaker machine learning resource.
    /// </summary>
    public partial class SageMakerMachineLearningModelResourceData
    {
        /// <summary>
        /// Gets and sets the property DestinationPath. The absolute local path of the resource
        /// inside the Lambda environment.
        /// </summary>
        public string DestinationPath { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPath property is set.
        /// </summary>
        internal bool IsSetDestinationPath() => this.DestinationPath != null;

        /// <summary>
        /// Gets and sets the property OwnerSetting.
        /// </summary>
        public ResourceDownloadOwnerSetting OwnerSetting { get; set; }

        /// <summary>
        /// Checks to see if the OwnerSetting property is set.
        /// </summary>
        internal bool IsSetOwnerSetting() => this.OwnerSetting != null;

        /// <summary>
        /// Gets and sets the property SageMakerJobArn. The ARN of the Amazon SageMaker training
        /// job that represents the source model.
        /// </summary>
        public string SageMakerJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerJobArn property is set.
        /// </summary>
        internal bool IsSetSageMakerJobArn() => this.SageMakerJobArn != null;
    }
}
