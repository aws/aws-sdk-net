/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Validates a specified template. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ValidateTemplate"/>
    public class ValidateTemplateRequest : AmazonWebServiceRequest
    {
        private string templateBody;
        private string templateURL;

        /// <summary>
        /// Structure containing the template body. (For more information, go to the <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/CFNGuide">AWS CloudFormation User Guide</a>.)
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

        /// <summary>
        /// Sets the TemplateBody property
        /// </summary>
        /// <param name="templateBody">The value to set for the TemplateBody property </param>
        /// <returns>this instance</returns>
        public ValidateTemplateRequest WithTemplateBody(string templateBody)
        {
            this.templateBody = templateBody;
            return this;
        }
            

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this.templateBody != null;       
        }

        /// <summary>
        /// Location of file containing the template body. (For more information, go to the <a
        /// href="http://docs.amazonwebservices.com/AWSCloudFormation/latest/CFNGuide">AWS CloudFormation User Guide</a>.)
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

        /// <summary>
        /// Sets the TemplateURL property
        /// </summary>
        /// <param name="templateURL">The value to set for the TemplateURL property </param>
        /// <returns>this instance</returns>
        public ValidateTemplateRequest WithTemplateURL(string templateURL)
        {
            this.templateURL = templateURL;
            return this;
        }
            

        // Check to see if TemplateURL property is set
        internal bool IsSetTemplateURL()
        {
            return this.templateURL != null;       
        }
    }
}
    
