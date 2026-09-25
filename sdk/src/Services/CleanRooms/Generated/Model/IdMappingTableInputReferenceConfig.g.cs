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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Provides the input reference configuration for the ID mapping table.
    /// </summary>
    public partial class IdMappingTableInputReferenceConfig
    {
        /// <summary>
        /// Gets and sets the property InputReferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the referenced resource in Entity Resolution. Valid
        /// values are ID mapping workflow ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string InputReferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the InputReferenceArn property is set.
        /// </summary>
        internal bool IsSetInputReferenceArn() => this.InputReferenceArn != null;

        /// <summary>
        /// Gets and sets the property ManageResourcePolicies. 
        /// <para>
        /// When <c>TRUE</c>, Clean Rooms manages permissions for the ID mapping table resource.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When <c>FALSE</c>, the resource owner manages permissions for the ID mapping table
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ManageResourcePolicies { get; set; }

        /// <summary>
        /// Checks to see if the ManageResourcePolicies property is set.
        /// </summary>
        internal bool IsSetManageResourcePolicies() => this.ManageResourcePolicies.HasValue;
    }
}
