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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListFunctionVersionsByCapacityProvider operation.
    /// Returns a list of function versions that are configured to use a specific capacity
    /// provider.
    /// </summary>
    public partial class ListFunctionVersionsByCapacityProviderRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The name of the capacity provider to list function versions for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string CapacityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderName property is set.
        /// </summary>
        internal bool IsSetCapacityProviderName() => this.CapacityProviderName != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Specify the pagination token that's returned by a previous request to retrieve the
        /// next page of results.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of function versions to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}
