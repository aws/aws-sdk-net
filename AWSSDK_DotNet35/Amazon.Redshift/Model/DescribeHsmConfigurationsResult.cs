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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeHsmConfigurationsResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<HsmConfiguration> hsmConfigurations = new List<HsmConfiguration>();


        /// <summary>
        /// A marker at which to continue listing HSM configurations in a new request. The response returns a marker if there are more HSM
        /// configurations to list than returned in the response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of Amazon Redshift HSM configurations.
        ///  
        /// </summary>
        public List<HsmConfiguration> HsmConfigurations
        {
            get { return this.hsmConfigurations; }
            set { this.hsmConfigurations = value; }
        }

        // Check to see if HsmConfigurations property is set
        internal bool IsSetHsmConfigurations()
        {
            return this.hsmConfigurations.Count > 0;
        }
    }
}
