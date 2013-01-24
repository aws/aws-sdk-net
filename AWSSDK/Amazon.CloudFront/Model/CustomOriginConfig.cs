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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A customer origin. </para>
    /// </summary>
    public class CustomOriginConfig  
    {
        
        private int? hTTPPort;
        private int? hTTPSPort;
        private string originProtocolPolicy;

        /// <summary>
        /// The HTTP port the custom origin listens on.
        ///  
        /// </summary>
        public int HTTPPort
        {
            get { return this.hTTPPort ?? default(int); }
            set { this.hTTPPort = value; }
        }

        /// <summary>
        /// Sets the HTTPPort property
        /// </summary>
        /// <param name="hTTPPort">The value to set for the HTTPPort property </param>
        /// <returns>this instance</returns>
        public CustomOriginConfig WithHTTPPort(int hTTPPort)
        {
            this.hTTPPort = hTTPPort;
            return this;
        }
            

        // Check to see if HTTPPort property is set
        internal bool IsSetHTTPPort()
        {
            return this.hTTPPort.HasValue;       
        }

        /// <summary>
        /// The HTTPS port the custom origin listens on.
        ///  
        /// </summary>
        public int HTTPSPort
        {
            get { return this.hTTPSPort ?? default(int); }
            set { this.hTTPSPort = value; }
        }

        /// <summary>
        /// Sets the HTTPSPort property
        /// </summary>
        /// <param name="hTTPSPort">The value to set for the HTTPSPort property </param>
        /// <returns>this instance</returns>
        public CustomOriginConfig WithHTTPSPort(int hTTPSPort)
        {
            this.hTTPSPort = hTTPSPort;
            return this;
        }
            

        // Check to see if HTTPSPort property is set
        internal bool IsSetHTTPSPort()
        {
            return this.hTTPSPort.HasValue;       
        }

        /// <summary>
        /// The origin protocol policy to apply to your origin.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>http-only, match-viewer</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string OriginProtocolPolicy
        {
            get { return this.originProtocolPolicy; }
            set { this.originProtocolPolicy = value; }
        }

        /// <summary>
        /// Sets the OriginProtocolPolicy property
        /// </summary>
        /// <param name="originProtocolPolicy">The value to set for the OriginProtocolPolicy property </param>
        /// <returns>this instance</returns>
        public CustomOriginConfig WithOriginProtocolPolicy(string originProtocolPolicy)
        {
            this.originProtocolPolicy = originProtocolPolicy;
            return this;
        }
            

        // Check to see if OriginProtocolPolicy property is set
        internal bool IsSetOriginProtocolPolicy()
        {
            return this.originProtocolPolicy != null;       
        }
    }
}
