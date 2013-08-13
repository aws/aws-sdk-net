/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> ListGatewaysOutput$Gateways </li>
    /// <li> ListGatewaysOutput$Marker </li>
    /// 
    /// </ul>
    /// </summary>
    public class ListGatewaysResult  
    {
        
        private List<GatewayInfo> gateways = new List<GatewayInfo>();
        private string marker;

        /// <summary>
        /// An array of <a>GatewayInfo</a> objects.
        ///  
        /// </summary>
        public List<GatewayInfo> Gateways
        {
            get { return this.gateways; }
            set { this.gateways = value; }
        }
        /// <summary>
        /// Adds elements to the Gateways collection
        /// </summary>
        /// <param name="gateways">The values to add to the Gateways collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListGatewaysResult WithGateways(params GatewayInfo[] gateways)
        {
            foreach (GatewayInfo element in gateways)
            {
                this.gateways.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Gateways collection
        /// </summary>
        /// <param name="gateways">The values to add to the Gateways collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListGatewaysResult WithGateways(IEnumerable<GatewayInfo> gateways)
        {
            foreach (GatewayInfo element in gateways)
            {
                this.gateways.Add(element);
            }

            return this;
        }

        // Check to see if Gateways property is set
        internal bool IsSetGateways()
        {
            return this.gateways.Count > 0;       
        }

        /// <summary>
        /// Use the marker in your next request to fetch the next set of gateways in the list. If there are no more gateways to list, this field does
        /// not appear in the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListGatewaysResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
