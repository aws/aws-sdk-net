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
    /// Details about a resource in a generated template
    /// </summary>
    public partial class ResourceDetail
    {
        private string _logicalResourceId;
        private Dictionary<string, string> _resourceIdentifier = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private GeneratedTemplateResourceStatus _resourceStatus;
        private string _resourceStatusReason;
        private string _resourceType;
        private List<WarningDetail> _warnings = AWSConfigs.InitializeCollections ? new List<WarningDetail>() : null;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical id for this resource in the final generated template.
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
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A list of up to 256 key-value pairs that identifies the resource in the generated
        /// template. The key is the name of one of the primary identifiers for the resource.
        /// (Primary identifiers are specified in the <c>primaryIdentifier</c> list in the resource
        /// schema.) The value is the value of that primary identifier. For example, for a <c>AWS::DynamoDB::Table</c>
        /// resource, the primary identifiers is <c>TableName</c> so the key-value pair could
        /// be <c>"TableName": "MyDDBTable"</c>. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html#schema-properties-primaryidentifier">primaryIdentifier</a>
        /// in the <i>CloudFormation Command Line Interface (CLI) User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public Dictionary<string, string> ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null && (this._resourceIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Status of the processing of a resource in a generated template.
        /// </para>
        ///  <dl> <dt> InProgress </dt> <dd> 
        /// <para>
        /// The resource processing is still in progress.
        /// </para>
        ///  </dd> <dt> Complete </dt> <dd> 
        /// <para>
        /// The resource processing is complete.
        /// </para>
        ///  </dd> <dt> Pending </dt> <dd> 
        /// <para>
        /// The resource processing is pending.
        /// </para>
        ///  </dd> <dt> Failed </dt> <dd> 
        /// <para>
        /// The resource processing has failed.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public GeneratedTemplateResourceStatus ResourceStatus
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
        /// The reason for the resource detail, providing more information if a failure happened.
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
        /// The type of the resource, such as <c>AWS::DynamoDB::Table</c>. For the list of supported
        /// resources, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a> In the <i>CloudFormation User Guide</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The warnings generated for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WarningDetail> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}