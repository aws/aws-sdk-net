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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The endpoint to which service requests can be submitted, including the actual URL prefix for sending requests and the Amazon Resource
    /// Name (ARN) so the endpoint can be referenced in other API calls such as UpdateServiceAccessPolicies.</para>
    /// </summary>
    public class ServiceEndpoint  
    {
        
        private string arn;
        private string endpoint;

        /// <summary>
        /// An Amazon Resource Name (ARN). See <a href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access Management</i> for more information.
        ///  
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        public ServiceEndpoint WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;       
        }

        /// <summary>
        /// The URL (including /version/pathPrefix) to which service requests can be submitted.
        ///  
        /// </summary>
        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        /// <summary>
        /// Sets the Endpoint property
        /// </summary>
        /// <param name="endpoint">The value to set for the Endpoint property </param>
        /// <returns>this instance</returns>
        public ServiceEndpoint WithEndpoint(string endpoint)
        {
            this.endpoint = endpoint;
            return this;
        }
            

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;       
        }
    }
}
