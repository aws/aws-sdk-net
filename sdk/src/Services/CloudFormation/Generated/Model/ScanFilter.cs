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
    /// A filter that is used to specify which resource types to scan.
    /// </summary>
    public partial class ScanFilter
    {
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// An array of strings where each string represents an Amazon Web Services resource type
        /// you want to scan. Each string defines the resource type using the format <c>AWS::ServiceName::ResourceType</c>,
        /// for example, <c>AWS::DynamoDB::Table</c>. For the full list of supported resource
        /// types, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support</a> table in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To scan all resource types within a service, you can use a wildcard, represented by
        /// an asterisk (<c>*</c>). You can place an asterisk at only the end of the string, for
        /// example, <c>AWS::S3::*</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}