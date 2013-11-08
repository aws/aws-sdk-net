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
    /// Container for the parameters to the ListStackResources operation.
    /// <para>Returns descriptions of all resources of the specified stack.</para> <para>For deleted stacks, ListStackResources returns resource
    /// information for up to 90 days after the stack has been deleted.</para>
    /// </summary>
    public partial class ListStackResourcesRequest : AmazonCloudFormationRequest
    {
        private string stackName;
        private string nextToken;


        /// <summary>
        /// The name or the unique identifier associated with the stack, which are not always interchangeable: <ul> <li>Running stacks: You can specify
        /// either the stack's name or its unique stack ID.</li> <li>Deleted stacks: You must specify the unique stack ID.</li> </ul> Default: There is
        /// no default value.
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// String that identifies the start of the next list of stack resource summaries, if there is one. Default: There is no default value.
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
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
