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
    /// Container for the parameters to the CheckDNSAvailability operation.
    /// Checks if the specified CNAME is available.
    /// </summary>
    public partial class CheckDNSAvailabilityRequest : AmazonElasticBeanstalkRequest
    {
        private string _cNAMEPrefix;


        /// <summary>
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        ///          The prefix used when this CNAME is reserved.        
        /// </para>
        /// </summary>
        public string CNAMEPrefix
        {
            get { return this._cNAMEPrefix; }
            set { this._cNAMEPrefix = value; }
        }

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this._cNAMEPrefix != null;
        }

    }
}