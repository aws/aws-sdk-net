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
    /// Container for the parameters to the GetTemplateSummary operation.
    /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
    /// action is useful for viewing parameter information, such as default parameter values
    /// and parameter types, before you create or update a stack.
    /// 
    ///  
    /// <para>
    /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
    /// or you can get template information for a running or deleted stack.
    /// </para>
    ///  
    /// <para>
    /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
    /// for up to 90 days after the stack has been deleted. If the template does not exist,
    /// a <code>ValidationError</code> is returned.
    /// </para>
    /// </summary>
    public partial class GetTemplateSummaryRequest : AmazonCloudFormationRequest
    {
        private string _stackName;
        private string _stackSetName;
        private string _templateBody;
        private string _templateURL;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the stack ID that is associated with the stack, which are not always interchangeable.
        /// For running stacks, you can specify either the stack's name or its unique stack ID.
        /// For deleted stack, you must specify the unique stack ID.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>StackName</code>,
        /// <code>TemplateBody</code>, or <code>TemplateURL</code>.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the stack set from which the stack was created.
        /// </para>
        /// </summary>
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure containing the template body with a minimum length of 1 byte and a maximum
        /// length of 51,200 bytes. For more information about templates, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>StackName</code>,
        /// <code>TemplateBody</code>, or <code>TemplateURL</code>.
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// Location of file containing the template body. The URL must point to a template (max
        /// size: 460,800 bytes) that is located in an Amazon S3 bucket. For more information
        /// about templates, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/template-anatomy.html">Template
        /// Anatomy</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify only one of the following parameters: <code>StackName</code>,
        /// <code>TemplateBody</code>, or <code>TemplateURL</code>.
        /// </para>
        /// </summary>
        public string TemplateURL
        {
            get { return this._templateURL; }
            set { this._templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this._templateURL != null;
        }

    }
}