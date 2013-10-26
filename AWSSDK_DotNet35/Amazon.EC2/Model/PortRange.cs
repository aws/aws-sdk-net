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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PortRange
    {
        
        private int? from;
        private int? to;


        /// <summary>
        /// The first port in the range. Required if specifying <c>tcp</c> or <c>udp</c> for the protocol.
        ///  
        /// </summary>
        public int From
        {
            get { return this.from ?? default(int); }
            set { this.from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this.from.HasValue;
        }

        /// <summary>
        /// The last port in the range. Required if specifying <c>tcp</c> or <c>udp</c> for the protocol.
        ///  
        /// </summary>
        public int To
        {
            get { return this.to ?? default(int); }
            set { this.to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this.to.HasValue;
        }
    }
}
