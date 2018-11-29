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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFormationStack operation.
    /// Creates an AWS CloudFormation stack, which creates a new Amazon EC2 instance from
    /// an exported Amazon Lightsail snapshot. This operation results in a CloudFormation
    /// stack record that can be used to track the AWS CloudFormation stack created. Use the
    /// <code>get cloud formation stack records</code> operation to get a list of the CloudFormation
    /// stacks created.
    /// 
    ///  <important> 
    /// <para>
    /// Wait until after your new Amazon EC2 instance is created before running the <code>create
    /// cloud formation stack</code> operation again with the same export snapshot record.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateCloudFormationStackRequest : AmazonLightsailRequest
    {
        private List<InstanceEntry> _instances = new List<InstanceEntry>();

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// An array of parameters that will be used to create the new Amazon EC2 instance. You
        /// can only pass one instance entry at a time in this array. You will get an invalid
        /// parameter error if you pass more than one instance entry in this array.
        /// </para>
        /// </summary>
        public List<InstanceEntry> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

    }
}