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
using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Indicates if the specified CNAME is available.</para>
    /// </summary>
    public partial class CheckDNSAvailabilityResult : AmazonWebServiceResponse
    {
        
        private bool? available;
        private string fullyQualifiedCNAME;

        /// <summary>
        /// Indicates if the specified CNAME is available: <enumValues> <value name="true"> <c>true</c> : The CNAME is available. </value> <value
        /// name="false"> <c>true</c> : The CNAME is not available. </value> </enumValues> <ul> <li> <c>true</c> : The CNAME is available. </li> <li>
        /// <c>false</c> : The CNAME is not available. </li> </ul>
        ///  
        /// </summary>
        public bool Available
        {
            get { return this.available ?? default(bool); }
            set { this.available = value; }
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this.available.HasValue;
        }

        /// <summary>
        /// The fully qualified CNAME to reserve when <a>CreateEnvironment</a> is called with the provided prefix.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FullyQualifiedCNAME
        {
            get { return this.fullyQualifiedCNAME; }
            set { this.fullyQualifiedCNAME = value; }
        }

        // Check to see if FullyQualifiedCNAME property is set
        internal bool IsSetFullyQualifiedCNAME()
        {
            return this.fullyQualifiedCNAME != null;
        }
    }
}
