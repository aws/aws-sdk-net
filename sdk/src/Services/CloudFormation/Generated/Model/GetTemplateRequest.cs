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
    /// Container for the parameters to the GetTemplate operation.
    /// Returns the template body for a specified stack. You can get the template for running
    /// or deleted stacks.
    /// 
    ///  
    /// <para>
    /// For deleted stacks, <c>GetTemplate</c> returns the template for up to 90 days after
    /// the stack has been deleted.
    /// </para>
    ///  <note> 
    /// <para>
    /// If the template doesn't exist, a <c>ValidationError</c> is returned.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetTemplateRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private string _stackName;
        private TemplateStage _templateStage;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of a change set for which CloudFormation returns
        /// the associated template. If you specify a name, you must also specify the <c>StackName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the unique stack ID that's associated with the stack, which aren't always
        /// interchangeable:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running stacks: You can specify either the stack's name or its unique stack ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted stacks: You must specify the unique stack ID.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property TemplateStage. 
        /// <para>
        /// For templates that include transforms, the stage of the template that CloudFormation
        /// returns. To get the user-submitted template, specify <c>Original</c>. To get the template
        /// after CloudFormation has processed all transforms, specify <c>Processed</c>.
        /// </para>
        ///  
        /// <para>
        /// If the template doesn't include transforms, <c>Original</c> and <c>Processed</c> return
        /// the same template. By default, CloudFormation specifies <c>Processed</c>.
        /// </para>
        /// </summary>
        public TemplateStage TemplateStage
        {
            get { return this._templateStage; }
            set { this._templateStage = value; }
        }

        // Check to see if TemplateStage property is set
        internal bool IsSetTemplateStage()
        {
            return this._templateStage != null;
        }

    }
}