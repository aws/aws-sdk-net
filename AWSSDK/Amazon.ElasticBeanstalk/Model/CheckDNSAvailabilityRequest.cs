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
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CheckDNSAvailability operation.
    /// <para> Checks if the specified CNAME is available. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.CheckDNSAvailability"/>
    public class CheckDNSAvailabilityRequest : AmazonWebServiceRequest
    {
        private string cNAMEPrefix;

        /// <summary>
        /// The prefix used when this CNAME is reserved.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 63</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CNAMEPrefix
        {
            get { return this.cNAMEPrefix; }
            set { this.cNAMEPrefix = value; }
        }

        /// <summary>
        /// Sets the CNAMEPrefix property
        /// </summary>
        /// <param name="cNAMEPrefix">The value to set for the CNAMEPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CheckDNSAvailabilityRequest WithCNAMEPrefix(string cNAMEPrefix)
        {
            this.cNAMEPrefix = cNAMEPrefix;
            return this;
        }
            

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this.cNAMEPrefix != null;       
        }
    }
}
    
