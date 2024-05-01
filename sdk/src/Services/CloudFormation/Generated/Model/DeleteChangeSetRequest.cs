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
    /// Container for the parameters to the DeleteChangeSet operation.
    /// Deletes the specified change set. Deleting change sets ensures that no one executes
    /// the wrong change set.
    /// 
    ///  
    /// <para>
    /// If the call successfully completes, CloudFormation successfully deleted the change
    /// set.
    /// </para>
    ///  
    /// <para>
    /// If <c>IncludeNestedStacks</c> specifies <c>True</c> during the creation of the nested
    /// change set, then <c>DeleteChangeSet</c> will delete all change sets that belong to
    /// the stacks hierarchy and will also delete all change sets for nested stacks with the
    /// status of <c>REVIEW_IN_PROGRESS</c>.
    /// </para>
    /// </summary>
    public partial class DeleteChangeSetRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the change set that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// If you specified the name of a change set to delete, specify the stack name or Amazon
        /// Resource Name (ARN) that's associated with it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}