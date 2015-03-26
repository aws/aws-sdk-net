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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>DescribeLoadBalancers</a>
    /// action. For information about Elastic Load Balancing security groups, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-security-features.html#using-elb-security-groups">Using
    /// Security Groups With Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer
    /// Guide</i>.
    /// </summary>
    public partial class SourceSecurityGroup
    {
        private string _groupName;
        private string _ownerAlias;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  Name of the source security group. Use this value for the <code>--source-group</code>
        /// parameter of the <code>ec2-authorize</code> command in the Amazon EC2 command line
        /// tool. 
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        ///  Owner of the source security group. Use this value for the <code>--source-group-user</code>
        /// parameter of the <code>ec2-authorize</code> command in the Amazon EC2 command line
        /// tool. 
        /// </para>
        /// </summary>
        public string OwnerAlias
        {
            get { return this._ownerAlias; }
            set { this._ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this._ownerAlias != null;
        }

    }
}