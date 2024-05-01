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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// For tasks that use the <c>awsvpc</c> networking mode, the VPC subnet and security
    /// group configuration.
    /// </summary>
    public partial class AwsEcsServiceNetworkConfigurationDetails
    {
        private AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails _awsVpcConfiguration;

        /// <summary>
        /// Gets and sets the property AwsVpcConfiguration. 
        /// <para>
        /// The VPC subnet and security group configuration.
        /// </para>
        /// </summary>
        public AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails AwsVpcConfiguration
        {
            get { return this._awsVpcConfiguration; }
            set { this._awsVpcConfiguration = value; }
        }

        // Check to see if AwsVpcConfiguration property is set
        internal bool IsSetAwsVpcConfiguration()
        {
            return this._awsVpcConfiguration != null;
        }

    }
}