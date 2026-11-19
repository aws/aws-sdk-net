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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Contains a permission ARN and its associated template parameter values. The <a>CreateResourceShare</a>
    /// operation uses this structure when associating permissions that have template parameters.
    /// </summary>
    public partial class PermissionArnAndTemplateParameters
    {
        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the permission to associate with the resource share.
        /// </para>
        /// </summary>
        public string PermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionArn property is set.
        /// </summary>
        internal bool IsSetPermissionArn() => this.PermissionArn != null;

        /// <summary>
        /// Gets and sets the property PermissionTemplateParameters. 
        /// <para>
        /// The list of template parameter values to assign for this permission. You must provide
        /// values for all parameters declared in the permission template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PermissionTemplateParameterInput> PermissionTemplateParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<PermissionTemplateParameterInput>() : null;

        /// <summary>
        /// Checks to see if the PermissionTemplateParameters property is set.
        /// </summary>
        internal bool IsSetPermissionTemplateParameters() => this.PermissionTemplateParameters != null && (this.PermissionTemplateParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
