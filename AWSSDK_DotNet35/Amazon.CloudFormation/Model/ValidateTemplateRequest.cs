/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ValidateTemplate operation.
    /// <para>Validates a specified template.</para>
    /// </summary>
    public partial class ValidateTemplateRequest : AmazonCloudFormationRequest
    {
        private string templateBody;
        private string templateURL;


        /// <summary>
        /// String containing the template body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this.templateBody; }
            set { this.templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;
        }

        /// <summary>
        /// Location of file containing the template body. The URL must point to a template (max size: 307,200 bytes) located in an S3 bucket in the
        /// same region as the stack. For more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS
        /// CloudFormation User Guide</a>. Conditional: You must pass <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only
        /// <c>TemplateBody</c> is used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateURL
        {
            get { return this.templateURL; }
            set { this.templateURL = value; }
        }

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this.templateURL != null;
        }

    }
}
    
