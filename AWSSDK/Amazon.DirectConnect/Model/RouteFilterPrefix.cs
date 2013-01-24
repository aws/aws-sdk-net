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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>A route filter prefix that the customer can advertise through BGP over a public virtual interface.</para>
    /// </summary>
    public class RouteFilterPrefix  
    {
        
        private string cidr;

        /// <summary>
        /// CIDR notation for the advertised route. Multiple routes are separated by commas Example: 10.10.10.0/24,10.10.11.0/24
        ///  
        /// </summary>
        public string Cidr
        {
            get { return this.cidr; }
            set { this.cidr = value; }
        }

        /// <summary>
        /// Sets the Cidr property
        /// </summary>
        /// <param name="cidr">The value to set for the Cidr property </param>
        /// <returns>this instance</returns>
        public RouteFilterPrefix WithCidr(string cidr)
        {
            this.cidr = cidr;
            return this;
        }
            

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this.cidr != null;       
        }
    }
}
