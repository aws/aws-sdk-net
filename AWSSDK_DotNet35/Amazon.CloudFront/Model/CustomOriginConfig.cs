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
        private OriginProtocolPolicy originProtocolPolicy;


        /// <summary>
        /// The HTTP port the custom origin listens on.
        ///  
        /// </summary>
        public int HTTPPort
        {
            get { return this.hTTPPort ?? default(int); }
            set { this.hTTPPort = value; }
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
        public OriginProtocolPolicy OriginProtocolPolicy
        {
            get { return this.originProtocolPolicy; }
            set { this.originProtocolPolicy = value; }
        }

        // Check to see if OriginProtocolPolicy property is set
        internal bool IsSetOriginProtocolPolicy()
        {
            return this.originProtocolPolicy != null;
        }
    }
}
