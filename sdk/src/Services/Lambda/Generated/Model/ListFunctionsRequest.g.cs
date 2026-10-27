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
    /// Container for the parameters to the ListFunctions operation. Returns a list of Lambda
    /// Event Functions, with the version-specific configuration of each. Lambda returns up
    /// to 50 functions per call. <para> Set <c>FunctionVersion</c> to <c>ALL</c> to include
    /// all published versions of each function in addition to the unpublished version. </para>
    /// <note> <para> The <c>ListFunctions</c> operation returns a subset of the <a>FunctionConfiguration</a>
    /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
    /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
    /// or version, use <a>GetFunction</a>. </para> </note>
    /// </summary>
    public partial class ListFunctionsRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// Set to <c>ALL</c> to include entries for all published versions of each function.
        /// </para>
        /// </summary>
        public FunctionVersion FunctionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FunctionVersion property is set.
        /// </summary>
        internal bool IsSetFunctionVersion() => this.FunctionVersion != null;

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
        /// Gets and sets the property MasterRegion. 
        /// <para>
        /// For Lambda@Edge functions, the Amazon Web Services Region of the master function.
        /// For example, <c>us-east-1</c> filters the list of functions to include only Lambda@Edge
        /// functions replicated from a master function in US East (N. Virginia). If specified,
        /// you must set <c>FunctionVersion</c> to <c>ALL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string MasterRegion { get; set; }

        /// <summary>
        /// Checks to see if the MasterRegion property is set.
        /// </summary>
        internal bool IsSetMasterRegion() => this.MasterRegion != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of functions to return in the response. Note that <c>ListFunctions</c>
        /// returns a maximum of 50 items in each response, even if you set the number higher.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}
