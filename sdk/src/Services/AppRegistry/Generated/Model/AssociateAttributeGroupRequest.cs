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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAttributeGroup operation.
    /// Associates an attribute group with an application to augment the application's metadata
    /// with the group's attributes. This feature enables applications to be described with
    /// user-defined details that are machine-readable, such as third-party integrations.
    /// </summary>
    public partial class AssociateAttributeGroupRequest : AmazonAppRegistryRequest
    {
        private string _application;
        private string _attributeGroup;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        ///  The name, ID, or ARN of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeGroup. 
        /// <para>
        ///  The name, ID, or ARN of the attribute group that holds the attributes to describe
        /// the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AttributeGroup
        {
            get { return this._attributeGroup; }
            set { this._attributeGroup = value; }
        }

        // Check to see if AttributeGroup property is set
        internal bool IsSetAttributeGroup()
        {
            return this._attributeGroup != null;
        }

    }
}