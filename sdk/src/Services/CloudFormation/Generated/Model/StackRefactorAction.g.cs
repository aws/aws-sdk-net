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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Describes the stack and the action that CloudFormation will perform on it if you execute
    /// the stack refactor.
    /// </summary>
    public partial class StackRefactorAction
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that CloudFormation takes on the stack.
        /// </para>
        /// </summary>
        public StackRefactorActionType Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify the refactor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Detection. 
        /// <para>
        /// The detection type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto: CloudFormation figured out the mapping on its own.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manual: The customer provided the mapping in the <c>ResourceMapping</c> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackRefactorDetection Detection { get; set; }

        /// <summary>
        /// Checks to see if the Detection property is set.
        /// </summary>
        internal bool IsSetDetection() => this.Detection != null;

        /// <summary>
        /// Gets and sets the property DetectionReason. 
        /// <para>
        /// The description of the detection type.
        /// </para>
        /// </summary>
        public string DetectionReason { get; set; }

        /// <summary>
        /// Checks to see if the DetectionReason property is set.
        /// </summary>
        internal bool IsSetDetectionReason() => this.DetectionReason != null;

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The type that will be evaluated in the <c>StackRefactorAction</c>. The following are
        /// potential <c>Entity</c> types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Stack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Resource</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackRefactorActionEntity Entity { get; set; }

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier associated with the physical instance of the resource.
        /// </para>
        /// </summary>
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A key-value pair that identifies the target resource. The key is an identifier property
        /// (for example, <c>BucketName</c> for <c>AWS::S3::Bucket</c> resources) and the value
        /// is the actual property value (for example, <c>MyS3Bucket</c>).
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceMapping. 
        /// <para>
        /// The mapping for the stack resource <c>Source</c> and stack resource <c>Destination</c>.
        /// </para>
        /// </summary>
        public ResourceMapping ResourceMapping { get; set; }

        /// <summary>
        /// Checks to see if the ResourceMapping property is set.
        /// </summary>
        internal bool IsSetResourceMapping() => this.ResourceMapping != null;

        /// <summary>
        /// Gets and sets the property TagResources. 
        /// <para>
        /// Assigns one or more tags to specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagResources property is set.
        /// </summary>
        internal bool IsSetTagResources() => this.TagResources != null && (this.TagResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UntagResources. 
        /// <para>
        /// Removes one or more tags to specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UntagResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UntagResources property is set.
        /// </summary>
        internal bool IsSetUntagResources() => this.UntagResources != null && (this.UntagResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
