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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
        private StackRefactorActionType _action;
        private string _description;
        private StackRefactorDetection _detection;
        private string _detectionReason;
        private StackRefactorActionEntity _entity;
        private string _physicalResourceId;
        private string _resourceIdentifier;
        private ResourceMapping _resourceMapping;
        private List<Tag> _tagResources = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _untagResources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that CloudFormation takes on the stack.
        /// </para>
        /// </summary>
        public StackRefactorActionType Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify the refactor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        public StackRefactorDetection Detection
        {
            get { return this._detection; }
            set { this._detection = value; }
        }

        // Check to see if Detection property is set
        internal bool IsSetDetection()
        {
            return this._detection != null;
        }

        /// <summary>
        /// Gets and sets the property DetectionReason. 
        /// <para>
        /// The description of the detection type.
        /// </para>
        /// </summary>
        public string DetectionReason
        {
            get { return this._detectionReason; }
            set { this._detectionReason = value; }
        }

        // Check to see if DetectionReason property is set
        internal bool IsSetDetectionReason()
        {
            return this._detectionReason != null;
        }

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
        public StackRefactorActionEntity Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier associated with the physical instance of the resource.
        /// </para>
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A key-value pair that identifies the target resource. The key is an identifier property
        /// (for example, <c>BucketName</c> for <c>AWS::S3::Bucket</c> resources) and the value
        /// is the actual property value (for example, <c>MyS3Bucket</c>).
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMapping. 
        /// <para>
        /// The mapping for the stack resource <c>Source</c> and stack resource <c>Destination</c>.
        /// </para>
        /// </summary>
        public ResourceMapping ResourceMapping
        {
            get { return this._resourceMapping; }
            set { this._resourceMapping = value; }
        }

        // Check to see if ResourceMapping property is set
        internal bool IsSetResourceMapping()
        {
            return this._resourceMapping != null;
        }

        /// <summary>
        /// Gets and sets the property TagResources. 
        /// <para>
        /// Assigns one or more tags to specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagResources
        {
            get { return this._tagResources; }
            set { this._tagResources = value; }
        }

        // Check to see if TagResources property is set
        internal bool IsSetTagResources()
        {
            return this._tagResources != null && (this._tagResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UntagResources. 
        /// <para>
        /// Removes one or more tags to specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UntagResources
        {
            get { return this._untagResources; }
            set { this._untagResources = value; }
        }

        // Check to see if UntagResources property is set
        internal bool IsSetUntagResources()
        {
            return this._untagResources != null && (this._untagResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}