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
    /// Container for the parameters to the EstimateTemplateCost operation.
    /// <para>Returns the estimated monthly cost of a template. The return value is an AWS Simple Monthly Calculator URL with a query string that
    /// describes the resources required to run the template.</para>
    /// </summary>
    public partial class EstimateTemplateCostRequest : AmazonCloudFormationRequest
    {
        private string templateBody;
        private string templateURL;
        private List<Parameter> parameters = new List<Parameter>();


        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.) Conditional: You must pass
        /// <c>TemplateBody</c> or <c>TemplateURL</c>. If both are passed, only <c>TemplateBody</c> is used.
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
        /// Location of file containing the template body. The URL must point to a template located in an S3 bucket in the same region as the stack. For
        /// more information, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a>.
        /// Conditional: You must pass <c>TemplateURL</c> or <c>TemplateBody</c>. If both are passed, only <c>TemplateBody</c> is used.
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

        /// <summary>
        /// A list of <c>Parameter</c> structures that specify input parameters.
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

    }
}
    
