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
    /// Contains the drift information for a resource that has been checked for drift. This
    /// includes actual and expected property values for resources in which CloudFormation
    /// has detected drift. Only resource properties explicitly defined in the stack template
    /// are checked for drift. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
    /// unmanaged configuration changes to stacks and resources with drift detection</a>.
    /// 
    ///  
    /// <para>
    /// Resources that don't currently support drift detection can't be checked. For a list
    /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
    /// type support for imports and drift detection</a>.
    /// </para>
    ///  
    /// <para>
    /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
    /// to detect drift on all resources in a given stack that support drift detection.
    /// </para>
    /// </summary>
    public partial class StackResourceDrift
    {
        private string _actualProperties;
        private string _driftStatusReason;
        private string _expectedProperties;
        private string _logicalResourceId;
        private ModuleInfo _moduleInfo;
        private string _physicalResourceId;
        private List<PhysicalResourceIdContextKeyValuePair> _physicalResourceIdContext = AWSConfigs.InitializeCollections ? new List<PhysicalResourceIdContextKeyValuePair>() : null;
        private List<PropertyDifference> _propertyDifferences = AWSConfigs.InitializeCollections ? new List<PropertyDifference>() : null;
        private string _resourceType;
        private string _stackId;
        private StackResourceDriftStatus _stackResourceDriftStatus;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ActualProperties. 
        /// <para>
        /// A JSON structure that contains the actual property values of the stack resource.
        /// </para>
        ///  
        /// <para>
        /// For resources whose <c>StackResourceDriftStatus</c> is <c>DELETED</c>, this structure
        /// will not be present.
        /// </para>
        /// </summary>
        public string ActualProperties
        {
            get { return this._actualProperties; }
            set { this._actualProperties = value; }
        }

        // Check to see if ActualProperties property is set
        internal bool IsSetActualProperties()
        {
            return this._actualProperties != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatusReason. 
        /// <para>
        /// The reason for the drift status. 
        /// </para>
        /// </summary>
        public string DriftStatusReason
        {
            get { return this._driftStatusReason; }
            set { this._driftStatusReason = value; }
        }

        // Check to see if DriftStatusReason property is set
        internal bool IsSetDriftStatusReason()
        {
            return this._driftStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedProperties. 
        /// <para>
        /// A JSON structure that contains the expected property values of the stack resource,
        /// as defined in the stack template and any values specified as template parameters.
        /// </para>
        ///  
        /// <para>
        /// For resources whose <c>StackResourceDriftStatus</c> is <c>DELETED</c>, this structure
        /// will not be present.
        /// </para>
        /// </summary>
        public string ExpectedProperties
        {
            get { return this._expectedProperties; }
            set { this._expectedProperties = value; }
        }

        // Check to see if ExpectedProperties property is set
        internal bool IsSetExpectedProperties()
        {
            return this._expectedProperties != null;
        }

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
        /// Gets and sets the property ModuleInfo. 
        /// <para>
        /// Contains information about the module from which the resource was created, if the
        /// resource was created from a module included in the stack template.
        /// </para>
        /// </summary>
        public ModuleInfo ModuleInfo
        {
            get { return this._moduleInfo; }
            set { this._moduleInfo = value; }
        }

        // Check to see if ModuleInfo property is set
        internal bool IsSetModuleInfo()
        {
            return this._moduleInfo != null;
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
        /// A collection of the resource properties whose actual values differ from their expected
        /// values. These will be present only for resources whose <c>StackResourceDriftStatus</c>
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
        /// The type of the resource.
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
        /// The ID of the stack.
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
        /// Status of the resource's actual configuration compared to its expected configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETED</c>: The resource differs from its expected template configuration because
        /// the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c>: One or more resource properties differ from their expected values
        /// (as defined in the stack template and any values specified as template parameters).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The resource's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation does not currently return this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: CloudFormation could not run drift detection for the resource. See
        /// the <c>DriftStatusReason</c> for details.
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
        /// Time at which CloudFormation performed drift detection on the stack resource.
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