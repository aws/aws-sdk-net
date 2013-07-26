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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthChecks operation.
    /// <para> To retrieve a list of your health checks, send a <c>GET</c> request to the <c>2012-12-12/healthcheck</c> resource. The response to
    /// this request includes a <c>HealthChecks</c> element with zero, one, or multiple <c>HealthCheck</c> child elements. By default, the list of
    /// health checks is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c>
    /// parameter. You can use the <c>Marker</c> parameter to control the health check that the list begins with. </para> <para><b>NOTE:</b> Amazon
    /// Route 53 returns a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
    /// </summary>
    public partial class ListHealthChecksRequest : AmazonWebServiceRequest
    {
        private string marker;
        private string maxItems;

        /// <summary>
        /// If the request returned more than one page of results, submit another request and specify the value of <c>NextMarker</c> from the last
        /// response in the <c>marker</c> parameter to get the next page of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// Specify the maximum number of health checks to return per page of results.
        ///  
        /// </summary>
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems != null;
        }

    }
}
    
