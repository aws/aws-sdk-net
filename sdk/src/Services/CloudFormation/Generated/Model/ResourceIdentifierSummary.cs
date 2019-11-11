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
    /// Describes the target resources of a specific type in your import template (for example,
    /// all <code>AWS::S3::Bucket</code> resources) and the properties you can provide during
    /// the import to identify resources of that type.
    /// </summary>
    public partial class ResourceIdentifierSummary
    {
        private List<string> _logicalResourceIds = new List<string>();
        private List<string> _resourceIdentifiers = new List<string>();
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property LogicalResourceIds. 
        /// <para>
        /// The logical IDs of the target resources of the specified <code>ResourceType</code>,
        /// as defined in the import template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<string> LogicalResourceIds
        {
            get { return this._logicalResourceIds; }
            set { this._logicalResourceIds = value; }
        }

        // Check to see if LogicalResourceIds property is set
        internal bool IsSetLogicalResourceIds()
        {
            return this._logicalResourceIds != null && this._logicalResourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// The resource properties you can provide during the import to identify your target
        /// resources. For example, <code>BucketName</code> is a possible identifier property
        /// for <code>AWS::S3::Bucket</code> resources.
        /// </para>
        /// </summary>
        public List<string> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && this._resourceIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The template resource type of the target resources, such as <code>AWS::S3::Bucket</code>.
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

    }
}