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
    /// This is the response object from the DescribeStudioLifecycleConfig operation.
    /// </summary>
    public partial class DescribeStudioLifecycleConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the Amazon SageMaker AI Studio Lifecycle Configuration.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// This value is equivalent to CreationTime because Amazon SageMaker AI Studio Lifecycle
        /// Configurations are immutable.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigAppType. 
        /// <para>
        /// The App type that the Lifecycle Configuration is attached to.
        /// </para>
        /// </summary>
        public StudioLifecycleConfigAppType StudioLifecycleConfigAppType { get; set; }

        /// <summary>
        /// Checks to see if the StudioLifecycleConfigAppType property is set.
        /// </summary>
        internal bool IsSetStudioLifecycleConfigAppType() => this.StudioLifecycleConfigAppType != null;

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigArn. 
        /// <para>
        /// The ARN of the Lifecycle Configuration to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioLifecycleConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the StudioLifecycleConfigArn property is set.
        /// </summary>
        internal bool IsSetStudioLifecycleConfigArn() => this.StudioLifecycleConfigArn != null;

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigContent. 
        /// <para>
        /// The content of your Amazon SageMaker AI Studio Lifecycle Configuration script.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string StudioLifecycleConfigContent { get; set; }

        /// <summary>
        /// Checks to see if the StudioLifecycleConfigContent property is set.
        /// </summary>
        internal bool IsSetStudioLifecycleConfigContent() => this.StudioLifecycleConfigContent != null;

        /// <summary>
        /// Gets and sets the property StudioLifecycleConfigName. 
        /// <para>
        /// The name of the Amazon SageMaker AI Studio Lifecycle Configuration that is described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string StudioLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the StudioLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetStudioLifecycleConfigName() => this.StudioLifecycleConfigName != null;
    }
}
