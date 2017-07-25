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
    /// Container for the parameters to the DescribeStackInstance operation.
    /// Returns the stack instance that's associated with the specified stack set, AWS account,
    /// and region.
    /// 
    ///  
    /// <para>
    /// For a list of stack instances that are associated with a specific stack set, use <a>ListStackInstances</a>.
    /// </para>
    /// </summary>
    public partial class DescribeStackInstanceRequest : AmazonCloudFormationRequest
    {
        private string _stackInstanceAccount;
        private string _stackInstanceRegion;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property StackInstanceAccount. 
        /// <para>
        /// The ID of an AWS account that's associated with this stack instance.
        /// </para>
        /// </summary>
        public string StackInstanceAccount
        {
            get { return this._stackInstanceAccount; }
            set { this._stackInstanceAccount = value; }
        }

        // Check to see if StackInstanceAccount property is set
        internal bool IsSetStackInstanceAccount()
        {
            return this._stackInstanceAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StackInstanceRegion. 
        /// <para>
        /// The name of a region that's associated with this stack instance.
        /// </para>
        /// </summary>
        public string StackInstanceRegion
        {
            get { return this._stackInstanceRegion; }
            set { this._stackInstanceRegion = value; }
        }

        // Check to see if StackInstanceRegion property is set
        internal bool IsSetStackInstanceRegion()
        {
            return this._stackInstanceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or the unique stack ID of the stack set that you want to get stack instance
        /// information for.
        /// </para>
        /// </summary>
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}