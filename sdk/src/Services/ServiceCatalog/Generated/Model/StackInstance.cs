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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// An AWS CloudFormation stack, in a specific account and region, that's part of a stack
    /// set operation. A stack instance is a reference to an attempted or actual stack in
    /// a given account within a given region. A stack instance can exist without a stack—for
    /// example, if the stack couldn't be created for some reason. A stack instance is associated
    /// with only one stack set. Each stack instance contains the ID of its associated stack
    /// set, as well as the ID of the actual stack and the stack status.
    /// </summary>
    public partial class StackInstance
    {
        private string _account;
        private string _region;
        private StackInstanceStatus _stackInstanceStatus;

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
        /// Gets and sets the property StackInstanceStatus. 
        /// <para>
        /// The status of the stack instance, in terms of its synchronization with its associated
        /// stack set. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INOPERABLE</code>: A <code>DeleteStackInstances</code> operation has failed
        /// and left the stack in an unstable state. Stacks in this state are excluded from further
        /// <code>UpdateStackSet</code> operations. You might need to perform a <code>DeleteStackInstances</code>
        /// operation, with <code>RetainStacks</code> set to true, to delete the stack instance,
        /// and then delete the stack manually. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OUTDATED</code>: The stack isn't currently up to date with the stack set because
        /// either the associated stack failed during a <code>CreateStackSet</code> or <code>UpdateStackSet</code>
        /// operation, or the stack was part of a <code>CreateStackSet</code> or <code>UpdateStackSet</code>
        /// operation that failed or was stopped before the stack was created or updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CURRENT</code>: The stack is currently up to date with the stack set.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackInstanceStatus StackInstanceStatus
        {
            get { return this._stackInstanceStatus; }
            set { this._stackInstanceStatus = value; }
        }

        // Check to see if StackInstanceStatus property is set
        internal bool IsSetStackInstanceStatus()
        {
            return this._stackInstanceStatus != null;
        }

    }
}