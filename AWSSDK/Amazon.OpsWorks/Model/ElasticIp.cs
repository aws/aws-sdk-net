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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes an Elastic IP address.</para>
    /// </summary>
    public class ElasticIp
    {
        
        private string ip;
        private string name;
        private string region;

        /// <summary>
        /// The Elastic IP address
        ///  
        /// </summary>
        public string Ip
        {
            get { return this.ip; }
            set { this.ip = value; }
        }

        /// <summary>
        /// Sets the Ip property
        /// </summary>
        /// <param name="ip">The value to set for the Ip property </param>
        /// <returns>this instance</returns>
        public ElasticIp WithIp(string ip)
        {
            this.ip = ip;
            return this;
        }
            

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this.ip != null;
        }

        /// <summary>
        /// The Elastic IP address name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public ElasticIp WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The AWS region. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and Endpoints</a>.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        public ElasticIp WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }
    }
}
