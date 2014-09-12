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
    /// Container for the parameters to the DescribeStackEvents operation.
    /// Returns all stack related events for a specified stack. For more information about
    /// a stack's event history, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
    /// in the AWS CloudFormation User Guide.
    /// </summary>
    public partial class DescribeStackEventsRequest : AmazonCloudFormationRequest
    {
        private string _nextToken;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// String that identifies the start of the next list of events, if there is one.
        /// </para>
        ///  
        /// <para>
        /// Default: There is no default value.
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
        /// The name or the unique identifier associated with the stack, which are not always
        /// interchangeable:
        /// </para>
        ///  <ul> <li>Running stacks: You can specify either the stack's name or its unique stack
        /// ID.</li> <li>Deleted stacks: You must specify the unique stack ID.</li> </ul> 
        /// <para>
        /// Default: There is no default value.
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