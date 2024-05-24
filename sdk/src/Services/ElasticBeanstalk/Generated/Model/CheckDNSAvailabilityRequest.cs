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
    /// Container for the parameters to the CheckDNSAvailability operation.
    /// Checks if the specified CNAME is available.
    /// </summary>
    public partial class CheckDNSAvailabilityRequest : AmazonElasticBeanstalkRequest
    {
        private string _cnamePrefix;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CheckDNSAvailabilityRequest() { }

        /// <summary>
        /// Instantiates CheckDNSAvailabilityRequest with the parameterized properties
        /// </summary>
        /// <param name="cnamePrefix">The prefix used when this CNAME is reserved.</param>
        public CheckDNSAvailabilityRequest(string cnamePrefix)
        {
            _cnamePrefix = cnamePrefix;
        }

        /// <summary>
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        /// The prefix used when this CNAME is reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=63)]
        public string CNAMEPrefix
        {
            get { return this._cnamePrefix; }
            set { this._cnamePrefix = value; }
        }

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this._cnamePrefix != null;
        }

    }
}