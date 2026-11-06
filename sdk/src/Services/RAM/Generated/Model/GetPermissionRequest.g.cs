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
    /// Container for the parameters to the GetPermission operation. Retrieves the contents
    /// of a managed permission in JSON format. <para> If the permission has template parameters,
    /// you can include the <c>permissionTemplateParameters</c> parameter in your request.
    /// The operation then renders the returned policy with the specified values in place
    /// of the template parameter placeholders. If you omit <c>permissionTemplateParameters</c>,
    /// the operation returns the raw policy template with <c>@{parameterName}</c> placeholders
    /// unchanged. </para>
    /// </summary>
    public partial class GetPermissionRequest : AmazonRAMRequest
    {
        /// <summary>
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the permission whose contents you want to retrieve. To
        /// find the ARN for a permission, use either the <a>ListPermissions</a> operation or
        /// go to the <a href="https://console.aws.amazon.com/ram/home#Permissions:">Permissions
        /// library</a> page in the RAM console and then choose the name of the permission. The
        /// ARN is displayed on the detail page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionArn property is set.
        /// </summary>
        internal bool IsSetPermissionArn() => this.PermissionArn != null;

        /// <summary>
        /// Gets and sets the property PermissionTemplateParameters. 
        /// <para>
        /// Specifies the template parameter values to use when rendering the permission's policy
        /// template. Each entry supplies a parameter name and its values. When you provide this
        /// parameter, the response contains the rendered policy with the specified values in
        /// place of the template parameter placeholders.
        /// </para>
        ///  
        /// <para>
        /// For <c>STRING</c> type parameters, provide a single value. For <c>STRING_LIST</c>
        /// type parameters, provide one or more values.
        /// </para>
        ///  
        /// <para>
        /// You can specify this parameter only for permissions that declare template parameters.
        /// You must provide values for all parameters declared in the permission template.
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

        /// <summary>
        /// Gets and sets the property PermissionVersion. 
        /// <para>
        /// Specifies the version number of the RAM permission to retrieve. If you don't specify
        /// this parameter, the operation retrieves the default version.
        /// </para>
        ///  
        /// <para>
        /// To see the list of available versions, use <a>ListPermissionVersions</a>.
        /// </para>
        /// </summary>
        public int? PermissionVersion { get; set; }

        /// <summary>
        /// Checks to see if the PermissionVersion property is set.
        /// </summary>
        internal bool IsSetPermissionVersion() => this.PermissionVersion.HasValue;
    }
}
