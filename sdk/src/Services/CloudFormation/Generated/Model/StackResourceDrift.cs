/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains the drift information for a resource that has been checked for drift. This
    /// includes actual and expected property values for resources in which AWS CloudFormation
    /// has detected drift. Only resource properties explicitly defined in the stack template
    /// are checked for drift. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
    /// Unregulated Configuration Changes to Stacks and Resources</a>.
    /// 
    ///  
    /// <para>
    /// Resources that do not currently support drift detection cannot be checked. For a list
    /// of resources that support drift detection, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
    /// that Support Drift Detection</a>.
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
        private string _expectedProperties;
        private string _logicalResourceId;
        private string _physicalResourceId;
        private List<PhysicalResourceIdContextKeyValuePair> _physicalResourceIdContext = new List<PhysicalResourceIdContextKeyValuePair>();
        private List<PropertyDifference> _propertyDifferences = new List<PropertyDifference>();
        private string _resourceType;
        private string _stackId;
        private StackResourceDriftStatus _stackResourceDriftStatus;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ActualProperties. 
        /// <para>
        /// A JSON structure containing the actual property values of the stack resource.
        /// </para>
        ///  
        /// <para>
        /// For resources whose <code>StackResourceDriftStatus</code> is <code>DELETED</code>,
        /// this structure will not be present. 
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
        /// Gets and sets the property ExpectedProperties. 
        /// <para>
        /// A JSON structure containing the expected property values of the stack resource, as
        /// defined in the stack template and any values specified as template parameters. 
        /// </para>
        ///  
        /// <para>
        /// For resources whose <code>StackResourceDriftStatus</code> is <code>DELETED</code>,
        /// this structure will not be present. 
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
        /// supported by AWS CloudFormation. 
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
        /// Context information that enables AWS CloudFormation to uniquely identify a resource.
        /// AWS CloudFormation uses context key-value pairs in cases where a resource's logical
        /// and physical IDs are not enough to uniquely identify that resource. Each context key-value
        /// pair specifies a unique resource that contains the targeted resource.
        /// </para>
        /// </summary>
        public List<PhysicalResourceIdContextKeyValuePair> PhysicalResourceIdContext
        {
            get { return this._physicalResourceIdContext; }
            set { this._physicalResourceIdContext = value; }
        }

        // Check to see if PhysicalResourceIdContext property is set
        internal bool IsSetPhysicalResourceIdContext()
        {
            return this._physicalResourceIdContext != null && this._physicalResourceIdContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropertyDifferences. 
        /// <para>
        /// A collection of the resource properties whose actual values differ from their expected
        /// values. These will be present only for resources whose <code>StackResourceDriftStatus</code>
        /// is <code>MODIFIED</code>. 
        /// </para>
        /// </summary>
        public List<PropertyDifference> PropertyDifferences
        {
            get { return this._propertyDifferences; }
            set { this._propertyDifferences = value; }
        }

        // Check to see if PropertyDifferences property is set
        internal bool IsSetPropertyDifferences()
        {
            return this._propertyDifferences != null && this._propertyDifferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
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
        /// Status of the resource's actual configuration compared to its expected configuration
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DELETED</code>: The resource differs from its expected template configuration
        /// because the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFIED</code>: One or more resource properties differ from their expected
        /// values (as defined in the stack template and any values specified as template parameters).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: The resources's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation does not currently return this value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Time at which AWS CloudFormation performed drift detection on the stack resource.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}