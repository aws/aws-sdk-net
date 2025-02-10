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
    /// Contains high-level information about the specified stack resource.
    /// </summary>
    public partial class StackResourceSummary
    {
        private StackResourceDriftInformationSummary _driftInformation;
        private DateTime? _lastUpdatedTimestamp;
        private string _logicalResourceId;
        private ModuleInfo _moduleInfo;
        private string _physicalResourceId;
        private ResourceStatus _resourceStatus;
        private string _resourceStatusReason;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property DriftInformation. 
        /// <para>
        /// Information about whether the resource's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// </para>
        /// </summary>
        public StackResourceDriftInformationSummary DriftInformation
        {
            get { return this._driftInformation; }
            set { this._driftInformation = value; }
        }

        // Check to see if DriftInformation property is set
        internal bool IsSetDriftInformation()
        {
            return this._driftInformation != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
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
        /// The name or unique identifier that corresponds to a physical instance ID of the resource.
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
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceStatus ResourceStatus
        {
            get { return this._resourceStatus; }
            set { this._resourceStatus = value; }
        }

        // Check to see if ResourceStatus property is set
        internal bool IsSetResourceStatus()
        {
            return this._resourceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        public string ResourceStatusReason
        {
            get { return this._resourceStatusReason; }
            set { this._resourceStatusReason = value; }
        }

        // Check to see if ResourceStatusReason property is set
        internal bool IsSetResourceStatusReason()
        {
            return this._resourceStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource. (For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>.)
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

    }
}