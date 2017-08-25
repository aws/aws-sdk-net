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
    /// The structure that contains summary information about a stack instance.
    /// </summary>
    public partial class StackInstanceSummary
    {
        private string _account;
        private string _region;
        private string _stackId;
        private string _stackSetId;
        private StackInstanceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The name of the AWS account that the stack instance is associated with.
        /// </para>
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the AWS region that the stack instance is associated with.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack instance.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The name or unique ID of the stack set that the stack instance is associated with.
        /// </para>
        /// </summary>
        public string StackSetId
        {
            get { return this._stackSetId; }
            set { this._stackSetId = value; }
        }

        // Check to see if StackSetId property is set
        internal bool IsSetStackSetId()
        {
            return this._stackSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stack instance, in terms of its synchronization with its associated
        /// stack set.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INOPERABLE</code>: A <code>DeleteStackInstances</code> operation has failed
        /// and left the stack in an unstable state. Stacks in this state are excluded from further
        /// <code>UpdateStackSet</code> operations. You might need to perform a <code>DeleteStackInstances</code>
        /// operation, with <code>RetainStacks</code> set to <code>true</code>, to delete the
        /// stack instance, and then delete the stack manually.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OUTDATED</code>: The stack isn't currently up to date with the stack set because:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The associated stack failed during a <code>CreateStackSet</code> or <code>UpdateStackSet</code>
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The stack was part of a <code>CreateStackSet</code> or <code>UpdateStackSet</code>
        /// operation that failed or was stopped before the stack was created or updated. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>CURRENT</code>: The stack is currently up to date with the stack set.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackInstanceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The explanation for the specific status code assigned to this stack instance.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}