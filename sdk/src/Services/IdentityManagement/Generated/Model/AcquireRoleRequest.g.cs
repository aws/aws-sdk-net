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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the AcquireRole operation. Creates an IAM role from
    /// the specified role template. The new role takes its configuration—including its name,
    /// path, trust policy, inline and managed policies, permissions boundary, tags, and maximum
    /// session duration—from the role template version that you specify. For more information
    /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
    /// roles</a> in the <i>IAM User Guide</i>. <para> If the template version defines parameters,
    /// use the <c>ReplacementValues</c> parameter to supply the values that the service substitutes
    /// into the role during creation. </para>
    /// </summary>
    public partial class AcquireRoleRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ReplacementValues. 
        /// <para>
        /// A map of values to substitute for the parameters that are defined in the role template
        /// version. Each key is a parameter name from the template, and each value is a structure
        /// that contains the replacement values for that parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public Dictionary<string, ReplacementValueEntry> ReplacementValues { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ReplacementValueEntry>() : null;

        /// <summary>
        /// Checks to see if the ReplacementValues property is set.
        /// </summary>
        internal bool IsSetReplacementValues() => this.ReplacementValues != null && (this.ReplacementValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role template to create the role from.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the role template to use. If you do not specify a minor version,
        /// the service uses the template's default minor version.
        /// </para>
        /// </summary>
        public int? TemplateMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMinorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMinorVersion() => this.TemplateMinorVersion.HasValue;
    }
}
