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
    /// Identifies a scanned resource. This is used with the <c>ListResourceScanRelatedResources</c>
    /// API action.
    /// </summary>
    public partial class ScannedResourceIdentifier
    {
        private Dictionary<string, string> _resourceIdentifier = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A list of up to 256 key-value pairs that identifies the scanned resource. The key
        /// is the name of one of the primary identifiers for the resource. (Primary identifiers
        /// are specified in the <c>primaryIdentifier</c> list in the resource schema.) The value
        /// is the value of that primary identifier. For example, for a <c>AWS::DynamoDB::Table</c>
        /// resource, the primary identifiers is <c>TableName</c> so the key-value pair could
        /// be <c>"TableName": "MyDDBTable"</c>. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html#schema-properties-primaryidentifier">primaryIdentifier</a>
        /// in the <i>CloudFormation Command Line Interface User guide for extension development</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource, such as <c>AWS::DynamoDB::Table</c>. For the list of supported
        /// resources, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">IaC
        /// generator supported resource types</a> In the <i>CloudFormation User Guide</i>.
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