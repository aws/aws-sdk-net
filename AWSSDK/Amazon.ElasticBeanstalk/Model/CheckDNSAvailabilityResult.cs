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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Indicates if the specified CNAME is available.</para>
    /// </summary>
    public class CheckDNSAvailabilityResult  
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

        /// <summary>
        /// Sets the Available property
        /// </summary>
        /// <param name="available">The value to set for the Available property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CheckDNSAvailabilityResult WithAvailable(bool available)
        {
            this.available = available;
            return this;
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

        /// <summary>
        /// Sets the FullyQualifiedCNAME property
        /// </summary>
        /// <param name="fullyQualifiedCNAME">The value to set for the FullyQualifiedCNAME property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CheckDNSAvailabilityResult WithFullyQualifiedCNAME(string fullyQualifiedCNAME)
        {
            this.fullyQualifiedCNAME = fullyQualifiedCNAME;
            return this;
        }
            

        // Check to see if FullyQualifiedCNAME property is set
        internal bool IsSetFullyQualifiedCNAME()
        {
            return this.fullyQualifiedCNAME != null;       
        }
    }
}
