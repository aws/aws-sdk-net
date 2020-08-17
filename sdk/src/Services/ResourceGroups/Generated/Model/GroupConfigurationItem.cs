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
    /// An item in a group configuration. A group configuration can have one or more items.
    /// </summary>
    public partial class GroupConfigurationItem
    {
        private List<GroupConfigurationParameter> _parameters = new List<GroupConfigurationParameter>();
        private string _type;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A collection of parameters for this group configuration item.
        /// </para>
        /// </summary>
        public List<GroupConfigurationParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of group configuration item. Each item must have a unique value
        /// for <code>type</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following string values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::EC2::CapacityReservationPool</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information about EC2 capacity reservation groups, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/capacity-reservations-using.html#create-cr-group">Working
        /// with capacity reservation groups</a> in the <i>EC2 Users Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::ResourceGroups::Generic</code> - Supports parameters that configure the
        /// behavior of resource groups of any type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=40)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}