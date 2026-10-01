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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAttributeGroup operation. Updates an existing
    /// attribute group with new details.
    /// </summary>
    public partial class UpdateAttributeGroupRequest : AmazonAppRegistryRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeGroup. 
        /// <para>
        ///  The name, ID, or ARN of the attribute group that holds the attributes to describe
        /// the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AttributeGroup { get; set; }

        /// <summary>
        /// Checks to see if the AttributeGroup property is set.
        /// </summary>
        internal bool IsSetAttributeGroup() => this.AttributeGroup != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A JSON string in the form of nested key-value pairs that represent the attributes
        /// in the group and describes an application and its components.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8000)]
        public string Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the attribute group that the user provides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Deprecated: The new name of the attribute group. The name must be unique in the region
        /// in which you are updating the attribute group. Please do not use this field as we
        /// have stopped supporting name updates.
        /// </para>
        /// </summary>
        [Obsolete("Name update for attribute group is deprecated.")]
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
