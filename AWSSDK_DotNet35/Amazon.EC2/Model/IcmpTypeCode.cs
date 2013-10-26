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
    public class IcmpTypeCode
    {
        
        private int? type;
        private int? code;


        /// <summary>
        /// For the ICMP protocol, the ICMP type. A value of <c>-1</c> is a wildcard meaning all types. Required if specifying <c>icmp</c> for the
        /// protocol.
        ///  
        /// </summary>
        public int Type
        {
            get { return this.type ?? default(int); }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type.HasValue;
        }

        /// <summary>
        /// For the ICMP protocol, the ICMP code. A value of <c>-1</c> is a wildcard meaning all codes. Required if specifying <c>icmp</c> for the
        /// protocol.
        ///  
        /// </summary>
        public int Code
        {
            get { return this.code ?? default(int); }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code.HasValue;
        }
    }
}
