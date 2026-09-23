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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// A set of resources defined by explicit ARNs, a logical expression, or both.
    /// </summary>
    public partial class ResourceSet
    {
        private List<string> _explicitArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceLogicalExpression _expression;

        /// <summary>
        /// Gets and sets the property ExplicitArns. 
        /// <para>
        /// An explicit list of resource ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExplicitArns
        {
            get { return this._explicitArns; }
            set { this._explicitArns = value; }
        }

        // Check to see if ExplicitArns property is set
        internal bool IsSetExplicitArns()
        {
            return this._explicitArns != null && (this._explicitArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A logical expression that selects resources by combining criteria with AND, OR, and
        /// NOT operators.
        /// </para>
        /// </summary>
        public ResourceLogicalExpression Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

    }
}