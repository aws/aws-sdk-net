/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Indicates if the specified CNAME is available.
    /// </summary>
    public partial class CheckDNSAvailabilityResult
    {
        private bool? _available;
        private string _fullyQualifiedCNAME;


        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        ///          Indicates if the specified CNAME is available:        
        /// </para>
        ///       <enumValues>         <value name="true">            
        /// <para>
        ///                <code>true</code>               : The CNAME is available.         
        ///   
        /// </para>
        ///          </value>         <value name="false">            
        /// <para>
        ///                <code>true</code>               : The CNAME is not available.     
        ///       
        /// </para>
        ///          </value>      </enumValues>      
        /// <para>
        ///          <ul>            <li>               <code>true</code>               : The
        /// CNAME is available.            </li>            <li>               <code>false</code>
        ///               : The CNAME is not available.            </li>         </ul>      
        /// </para>
        /// </summary>
        public bool Available
        {
            get { return this._available.GetValueOrDefault(); }
            set { this._available = value; }
        }


        /// <summary>
        /// Sets the Available property
        /// </summary>
        /// <param name="available">The value to set for the Available property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CheckDNSAvailabilityResult WithAvailable(bool available)
        {
            this._available = available;
            return this;
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this._available.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property FullyQualifiedCNAME. 
        /// <para>
        /// The fully qualified CNAME to reserve when <a>CreateEnvironment</a> is called     
        ///    with the provided prefix.
        /// </para>
        /// </summary>
        public string FullyQualifiedCNAME
        {
            get { return this._fullyQualifiedCNAME; }
            set { this._fullyQualifiedCNAME = value; }
        }


        /// <summary>
        /// Sets the FullyQualifiedCNAME property
        /// </summary>
        /// <param name="fullyQualifiedCNAME">The value to set for the FullyQualifiedCNAME property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CheckDNSAvailabilityResult WithFullyQualifiedCNAME(string fullyQualifiedCNAME)
        {
            this._fullyQualifiedCNAME = fullyQualifiedCNAME;
            return this;
        }

        // Check to see if FullyQualifiedCNAME property is set
        internal bool IsSetFullyQualifiedCNAME()
        {
            return this._fullyQualifiedCNAME != null;
        }

    }
}