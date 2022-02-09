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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcConnector operation.
    /// Create an App Runner VPC connector resource. App Runner requires this resource when
    /// you want to associate your App Runner service to a custom Amazon Virtual Private Cloud
    /// (Amazon VPC).
    /// </summary>
    public partial class CreateVpcConnectorRequest : AmazonAppRunnerRequest
    {
        private List<string> _securityGroups = new List<string>();
        private List<string> _subnets = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcConnectorName;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of IDs of security groups that App Runner should use for access to Amazon Web
        /// Services resources under the specified subnets. If not specified, App Runner uses
        /// the default security group of the Amazon VPC. The default security group allows all
        /// outbound traffic.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of IDs of subnets that App Runner should use when it associates your service
        /// with a custom Amazon VPC. Specify IDs of subnets of a single Amazon VPC. App Runner
        /// determines the Amazon VPC from the subnets you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of metadata items that you can associate with your VPC connector resource.
        /// A tag is a key-value pair.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcConnectorName. 
        /// <para>
        /// A name for the VPC connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=40)]
        public string VpcConnectorName
        {
            get { return this._vpcConnectorName; }
            set { this._vpcConnectorName = value; }
        }

        // Check to see if VpcConnectorName property is set
        internal bool IsSetVpcConnectorName()
        {
            return this._vpcConnectorName != null;
        }

    }
}