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
    /// The structure containing summary information about resource drifts for a stack instance.
    /// </summary>
    public partial class StackInstanceResourceDriftsSummary
    {
        private string _logicalResourceId;
        private string _physicalResourceId;
        private List<PhysicalResourceIdContextKeyValuePair> _physicalResourceIdContext = AWSConfigs.InitializeCollections ? new List<PhysicalResourceIdContextKeyValuePair>() : null;
        private List<PropertyDifference> _propertyDifferences = AWSConfigs.InitializeCollections ? new List<PropertyDifference>() : null;
        private string _resourceType;
        private string _stackId;
        private StackResourceDriftStatus _stackResourceDriftStatus;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource specified in the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource
        /// supported by CloudFormation.
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
        /// Gets and sets the property PhysicalResourceIdContext. 
        /// <para>
        /// Context information that enables CloudFormation to uniquely identify a resource. CloudFormation
        /// uses context key-value pairs in cases where a resource's logical and physical IDs
        /// aren't enough to uniquely identify that resource. Each context key-value pair specifies
        /// a unique resource that contains the targeted resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<PhysicalResourceIdContextKeyValuePair> PhysicalResourceIdContext
        {
            get { return this._physicalResourceIdContext; }
            set { this._physicalResourceIdContext = value; }
        }

        // Check to see if PhysicalResourceIdContext property is set
        internal bool IsSetPhysicalResourceIdContext()
        {
            return this._physicalResourceIdContext != null && (this._physicalResourceIdContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropertyDifferences. 
        /// <para>
        /// Status of the actual configuration of the resource compared to its expected configuration.
        /// These will be present only for resources whose <c>StackInstanceResourceDriftStatus</c>
        /// is <c>MODIFIED</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PropertyDifference> PropertyDifferences
        {
            get { return this._propertyDifferences; }
            set { this._propertyDifferences = value; }
        }

        // Check to see if PropertyDifferences property is set
        internal bool IsSetPropertyDifferences()
        {
            return this._propertyDifferences != null && (this._propertyDifferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackResourceDriftStatus. 
        /// <para>
        /// The drift status of the resource in a stack instance.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETED</c>: The resource differs from its expected template configuration in
        /// that the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c>: One or more resource properties differ from their expected template
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The resource's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation doesn't currently return this value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StackResourceDriftStatus StackResourceDriftStatus
        {
            get { return this._stackResourceDriftStatus; }
            set { this._stackResourceDriftStatus = value; }
        }

        // Check to see if StackResourceDriftStatus property is set
        internal bool IsSetStackResourceDriftStatus()
        {
            return this._stackResourceDriftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time at which the stack instance drift detection operation was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}