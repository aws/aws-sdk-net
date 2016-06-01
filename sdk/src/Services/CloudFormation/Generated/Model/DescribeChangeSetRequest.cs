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
    /// Container for the parameters to the DescribeChangeSet operation.
    /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
    /// will make if you execute the change set. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
    /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
    /// </summary>
    public partial class DescribeChangeSetRequest : AmazonCloudFormationRequest
    {
        private string _changeSetName;
        private string _nextToken;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the change set that you want to describe.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string (provided by the <a>DescribeChangeSet</a> response output) that identifies
        /// the next page of information that you want to retrieve.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// If you specified the name of a change set, specify the stack name or ID (ARN) of the
        /// change set you want to describe.
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

    }
}