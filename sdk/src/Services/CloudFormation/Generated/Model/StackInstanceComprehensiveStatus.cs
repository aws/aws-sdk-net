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
    /// The detailed status of the stack instance.
    /// </summary>
    public partial class StackInstanceComprehensiveStatus
    {
        private StackInstanceDetailedStatus _detailedStatus;

        /// <summary>
        /// Gets and sets the property DetailedStatus. <ul> <li> 
        /// <para>
        ///  <c>CANCELLED</c>: The operation in the specified account and Region has been canceled.
        /// This is either because a user has stopped the StackSet operation, or because the failure
        /// tolerance of the StackSet operation has been exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The operation in the specified account and Region failed. If the StackSet
        /// operation fails in enough accounts within a Region, the failure tolerance for the
        /// StackSet operation as a whole might be exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_IMPORT</c>: The import of the stack instance in the specified account and
        /// Region failed and left the stack in an unstable state. Once the issues causing the
        /// failure are fixed, the import operation can be retried. If enough StackSet operations
        /// fail in enough accounts within a Region, the failure tolerance for the StackSet operation
        /// as a whole might be exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INOPERABLE</c>: A <c>DeleteStackInstances</c> operation has failed and left the
        /// stack in an unstable state. Stacks in this state are excluded from further <c>UpdateStackSet</c>
        /// operations. You might need to perform a <c>DeleteStackInstances</c> operation, with
        /// <c>RetainStacks</c> set to <c>true</c>, to delete the stack instance, and then delete
        /// the stack manually.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: The operation in the specified account and Region has yet to start.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>: The operation in the specified account and Region is currently in
        /// progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED_SUSPENDED_ACCOUNT</c>: The operation in the specified account and Region
        /// has been skipped because the account was suspended at the time of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The operation in the specified account and Region completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackInstanceDetailedStatus DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

    }
}