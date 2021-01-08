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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for a <a>DescribeStackResource</a> action.
    /// </summary>
    public partial class DescribeStackResourceResponse : AmazonWebServiceResponse
    {
        private StackResourceDetail _stackResourceDetail;

        /// <summary>
        /// Gets and sets the property StackResourceDetail. 
        /// <para>
        /// A <code>StackResourceDetail</code> structure containing the description of the specified
        /// resource in the specified stack.
        /// </para>
        /// </summary>
        public StackResourceDetail StackResourceDetail
        {
            get { return this._stackResourceDetail; }
            set { this._stackResourceDetail = value; }
        }

        // Check to see if StackResourceDetail property is set
        internal bool IsSetStackResourceDetail()
        {
            return this._stackResourceDetail != null;
        }

    }
}