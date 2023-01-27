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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// A resource group that contains Amazon Web Services resources. You can assign resources
    /// to the group by associating either of the following elements with the group:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>ResourceQuery</a> - Use a resource query to specify a set of tag keys and values.
    /// All resources in the same Amazon Web Services Region and Amazon Web Services account
    /// that have those keys with the same values are included in the group. You can add a
    /// resource query when you create the group, or later by using the <a>PutGroupConfiguration</a>
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GroupConfiguration</a> - Use a service configuration to associate the group with
    /// an Amazon Web Services service. The configuration specifies which resource types can
    /// be included in the group.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Group
    {
        private string _description;
        private string _groupArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The ARN of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1600)]
        public string GroupArn
        {
            get { return this._groupArn; }
            set { this._groupArn = value; }
        }

        // Check to see if GroupArn property is set
        internal bool IsSetGroupArn()
        {
            return this._groupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}