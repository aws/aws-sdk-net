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
    /// Container for the parameters to the DescribeStackRefactor operation.
    /// Describes the stack refactor status.
    /// </summary>
    public partial class DescribeStackRefactorRequest : AmazonCloudFormationRequest
    {
        private string _stackRefactorId;

        /// <summary>
        /// Gets and sets the property StackRefactorId. 
        /// <para>
        /// The ID associated with the stack refactor created from the <a>CreateStackRefactor</a>
        /// action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackRefactorId
        {
            get { return this._stackRefactorId; }
            set { this._stackRefactorId = value; }
        }

        // Check to see if StackRefactorId property is set
        internal bool IsSetStackRefactorId()
        {
            return this._stackRefactorId != null;
        }

    }
}