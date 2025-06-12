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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFormationStack operation.
    /// Creates an AWS CloudFormation stack, which creates a new Amazon EC2 instance from
    /// an exported Amazon Lightsail snapshot. This operation results in a CloudFormation
    /// stack record that can be used to track the AWS CloudFormation stack created. Use the
    /// <c>get cloud formation stack records</c> operation to get a list of the CloudFormation
    /// stacks created.
    /// 
    ///  <important> 
    /// <para>
    /// Wait until after your new Amazon EC2 instance is created before running the <c>create
    /// cloud formation stack</c> operation again with the same export snapshot record.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateCloudFormationStackRequest : AmazonLightsailRequest
    {
        private List<InstanceEntry> _instances = AWSConfigs.InitializeCollections ? new List<InstanceEntry>() : null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// An array of parameters that will be used to create the new Amazon EC2 instance. You
        /// can only pass one instance entry at a time in this array. You will get an invalid
        /// parameter error if you pass more than one instance entry in this array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InstanceEntry> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}