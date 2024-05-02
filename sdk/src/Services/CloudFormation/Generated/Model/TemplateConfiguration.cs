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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
    /// The configuration details of a generated template.
    /// </summary>
    public partial class TemplateConfiguration
    {
        private GeneratedTemplateDeletionPolicy _deletionPolicy;
        private GeneratedTemplateUpdateReplacePolicy _updateReplacePolicy;

        /// <summary>
        /// Gets and sets the property DeletionPolicy. 
        /// <para>
        /// The <c>DeletionPolicy</c> assigned to resources in the generated template. Supported
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE</c> - delete all resources when the stack is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RETAIN</c> - retain all resources when the stack is deleted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-deletionpolicy.html">DeletionPolicy
        /// attribute</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public GeneratedTemplateDeletionPolicy DeletionPolicy
        {
            get { return this._deletionPolicy; }
            set { this._deletionPolicy = value; }
        }

        // Check to see if DeletionPolicy property is set
        internal bool IsSetDeletionPolicy()
        {
            return this._deletionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReplacePolicy. 
        /// <para>
        /// The <c>UpdateReplacePolicy</c> assigned to resources in the generated template. Supported
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE</c> - delete all resources when the resource is replaced during an update
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RETAIN</c> - retain all resources when the resource is replaced during an update
        /// operation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatereplacepolicy.html">UpdateReplacePolicy
        /// attribute</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public GeneratedTemplateUpdateReplacePolicy UpdateReplacePolicy
        {
            get { return this._updateReplacePolicy; }
            set { this._updateReplacePolicy = value; }
        }

        // Check to see if UpdateReplacePolicy property is set
        internal bool IsSetUpdateReplacePolicy()
        {
            return this._updateReplacePolicy != null;
        }

    }
}