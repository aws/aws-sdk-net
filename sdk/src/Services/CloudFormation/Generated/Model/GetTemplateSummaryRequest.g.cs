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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemplateSummary operation. Returns information
    /// about a new or existing template. The <c>GetTemplateSummary</c> action is useful for
    /// viewing parameter information, such as default parameter values and parameter types,
    /// before you create or update a stack or StackSet. <para> You can use the <c>GetTemplateSummary</c>
    /// action when you submit a template, or you can get template information for a StackSet,
    /// or a running or deleted stack. </para> <para> For deleted stacks, <c>GetTemplateSummary</c>
    /// returns the template information for up to 90 days after the stack has been deleted.
    /// If the template doesn't exist, a <c>ValidationError</c> is returned. </para>
    /// </summary>
    public partial class GetTemplateSummaryRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs { get; set; }

        /// <summary>
        /// Checks to see if the CallAs property is set.
        /// </summary>
        internal bool IsSetCallAs() => this.CallAs != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the stack ID that's associated with the stack, which aren't always interchangeable.
        /// For running stacks, you can specify either the stack's name or its unique stack ID.
        /// For deleted stack, you must specify the unique stack ID.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>StackName</c>,
        /// <c>StackSetName</c>, <c>TemplateBody</c>, or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet from which the stack was created.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>StackName</c>,
        /// <c>StackSetName</c>, <c>TemplateBody</c>, or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure that contains the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>StackName</c>,
        /// <c>StackSetName</c>, <c>TemplateBody</c>, or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateSummaryConfig. 
        /// <para>
        /// Specifies options for the <c>GetTemplateSummary</c> API action.
        /// </para>
        /// </summary>
        public TemplateSummaryConfig TemplateSummaryConfig { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSummaryConfig property is set.
        /// </summary>
        internal bool IsSetTemplateSummaryConfig() => this.TemplateSummaryConfig != null;

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// The URL of a file that contains the template body. The URL must point to a template
        /// (max size: 1 MB) that's located in an Amazon S3 bucket or a Systems Manager document.
        /// The location for an Amazon S3 bucket must start with <c>https://</c>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <c>StackName</c>,
        /// <c>StackSetName</c>, <c>TemplateBody</c>, or <c>TemplateURL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5120)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// Checks to see if the TemplateURL property is set.
        /// </summary>
        internal bool IsSetTemplateURL() => this.TemplateURL != null;
    }
}
