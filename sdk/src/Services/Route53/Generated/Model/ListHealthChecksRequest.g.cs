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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthChecks operation. Retrieve a list of
    /// the health checks that are associated with the current Amazon Web Services account.
    /// </summary>
    public partial class ListHealthChecksRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>true</c>, you have
        /// more health checks. To get another group, submit another <c>ListHealthChecks</c> request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For the value of <c>marker</c>, specify the value of <c>NextMarker</c> from the previous
        /// response, which is the ID of the first health check that Amazon Route 53 will return
        /// if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>false</c>, there
        /// are no more health checks to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of health checks that you want <c>ListHealthChecks</c> to return
        /// in response to the current request. Amazon Route 53 returns a maximum of 1000 items.
        /// If you set <c>MaxItems</c> to a value greater than 1000, Route 53 returns only the
        /// first 1000 health checks. 
        /// </para>
        /// </summary>
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;
    }
}
