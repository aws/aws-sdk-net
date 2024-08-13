/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Indicates if the specified CNAME is available.
    /// </summary>
    public partial class CheckDNSAvailabilityResponse : AmazonWebServiceResponse
    {
        private bool? _available;
        private string _fullyQualifiedCNAME;

        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// Indicates if the specified CNAME is available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> : The CNAME is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> : The CNAME is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? Available
        {
            get { return this._available; }
            set { this._available = value; }
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this._available.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullyQualifiedCNAME. 
        /// <para>
        /// The fully qualified CNAME to reserve when <a>CreateEnvironment</a> is called with
        /// the provided prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FullyQualifiedCNAME
        {
            get { return this._fullyQualifiedCNAME; }
            set { this._fullyQualifiedCNAME = value; }
        }

        // Check to see if FullyQualifiedCNAME property is set
        internal bool IsSetFullyQualifiedCNAME()
        {
            return this._fullyQualifiedCNAME != null;
        }

    }
}