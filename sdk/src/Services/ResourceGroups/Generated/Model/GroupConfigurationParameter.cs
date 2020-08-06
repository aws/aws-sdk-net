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
    /// A parameter for a group configuration item.
    /// </summary>
    public partial class GroupConfigurationParameter
    {
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the group configuration parameter.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following string values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For configuration item type <code>AWS::ResourceGroups::Generic</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>allowed-resource-types</code> 
        /// </para>
        ///  
        /// <para>
        /// Specifies the types of resources that you can add to this group by using the <a>GroupResources</a>
        /// operation.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For configuration item type <code>AWS::EC2::CapacityReservationPool</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// None - This configuration item type doesn't support any parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about EC2 capacity reservation groups, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/capacity-reservations-using.html#create-cr-group">Working
        /// with capacity reservation groups</a> in the <i>EC2 Users Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
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

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of for this parameter.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following string value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For item type <code>allowed-resource-types</code>: the only supported parameter value
        /// is <code>AWS::EC2::CapacityReservation</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}