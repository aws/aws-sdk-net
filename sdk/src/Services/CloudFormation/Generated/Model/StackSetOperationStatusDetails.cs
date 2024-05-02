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
    /// Detailed information about the StackSet operation.
    /// </summary>
    public partial class StackSetOperationStatusDetails
    {
        private int? _failedStackInstancesCount;

        /// <summary>
        /// Gets and sets the property FailedStackInstancesCount. 
        /// <para>
        /// The number of stack instances for which the StackSet operation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FailedStackInstancesCount
        {
            get { return this._failedStackInstancesCount; }
            set { this._failedStackInstancesCount = value; }
        }

        // Check to see if FailedStackInstancesCount property is set
        internal bool IsSetFailedStackInstancesCount()
        {
            return this._failedStackInstancesCount.HasValue; 
        }

    }
}