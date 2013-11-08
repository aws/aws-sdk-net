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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// <para>Response for ListEndpointsByPlatformApplication action.</para>
    /// </summary>
    public partial class ListEndpointsByPlatformApplicationResult : AmazonWebServiceResponse
    {
        
        private List<Endpoint> endpoints = new List<Endpoint>();
        private string nextToken;

        /// <summary>
        /// Endpoints returned for ListEndpointsByPlatformApplication action.
        ///  
        /// </summary>
        public List<Endpoint> Endpoints
        {
            get { return this.endpoints; }
            set { this.endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this.endpoints.Count > 0;
        }

        /// <summary>
        /// NextToken string is returned when calling ListEndpointsByPlatformApplication action if additional records are available after the first page
        /// results.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
