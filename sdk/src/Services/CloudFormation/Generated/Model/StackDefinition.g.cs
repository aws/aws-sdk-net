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
    /// Describes the stack and the template used by the stack.
    /// </summary>
    public partial class StackDefinition
    {
        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The file path for the stack template file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        /// The desired final state of the stack template.
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
