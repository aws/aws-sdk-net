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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeContainerAssociation operation.
    /// Returns the properties of a container association.
    /// </summary>
    public partial class DescribeContainerAssociationRequest : AmazonNetworkFirewallRequest
    {
        private string _containerAssociationArn;
        private string _containerAssociationName;

        /// <summary>
        /// Gets and sets the property ContainerAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container association. You must specify the
        /// ARN or the name, and you can specify both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContainerAssociationArn
        {
            get { return this._containerAssociationArn; }
            set { this._containerAssociationArn = value; }
        }

        // Check to see if ContainerAssociationArn property is set
        internal bool IsSetContainerAssociationArn()
        {
            return this._containerAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerAssociationName. 
        /// <para>
        /// The descriptive name of the container association. You must specify the ARN or the
        /// name, and you can specify both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ContainerAssociationName
        {
            get { return this._containerAssociationName; }
            set { this._containerAssociationName = value; }
        }

        // Check to see if ContainerAssociationName property is set
        internal bool IsSetContainerAssociationName()
        {
            return this._containerAssociationName != null;
        }

    }
}