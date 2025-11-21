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
    /// Describes whether StackSets performs non-conflicting operations concurrently and queues
    /// conflicting operations.
    /// </summary>
    public partial class ManagedExecution
    {
        private bool? _active;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// When <c>true</c>, CloudFormation performs non-conflicting operations concurrently
        /// and queues conflicting operations. After conflicting operations finish, CloudFormation
        /// starts queued operations in request order.
        /// </para>
        ///  <note> 
        /// <para>
        /// If there are already running or queued operations, CloudFormation queues all incoming
        /// operations even if they are non-conflicting.
        /// </para>
        ///  
        /// <para>
        /// You can't modify your StackSet's execution configuration while there are running or
        /// queued operations for that StackSet.
        /// </para>
        ///  </note> 
        /// <para>
        /// When <c>false</c> (default), StackSets performs one operation at a time in request
        /// order.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

    }
}