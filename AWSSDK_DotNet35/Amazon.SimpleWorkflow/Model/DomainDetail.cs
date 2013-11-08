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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains details of a domain. </para>
    /// </summary>
    public partial class DomainDetail : AmazonWebServiceResponse
    {
        
        private DomainInfo domainInfo;
        private DomainConfiguration configuration;

        /// <summary>
        /// Contains general information about a domain.
        ///  
        /// </summary>
        public DomainInfo DomainInfo
        {
            get { return this.domainInfo; }
            set { this.domainInfo = value; }
        }

        // Check to see if DomainInfo property is set
        internal bool IsSetDomainInfo()
        {
            return this.domainInfo != null;
        }

        /// <summary>
        /// Contains the configuration settings of a domain.
        ///  
        /// </summary>
        public DomainConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }
    }
}
