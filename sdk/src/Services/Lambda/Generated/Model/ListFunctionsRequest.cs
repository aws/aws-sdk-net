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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListFunctions operation.
    /// Returns a list of Lambda functions, with the version-specific configuration of each.
    /// Lambda returns up to 50 functions per call.
    /// 
    ///  
    /// <para>
    /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
    /// of each function in addition to the unpublished version.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
    /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
    /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
    /// or version, use <a>GetFunction</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListFunctionsRequest : AmazonLambdaRequest
    {
        private FunctionVersion _functionVersion;
        private string _marker;
        private string _masterRegion;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// Set to <code>ALL</code> to include entries for all published versions of each function.
        /// </para>
        /// </summary>
        public FunctionVersion FunctionVersion
        {
            get { return this._functionVersion; }
            set { this._functionVersion = value; }
        }

        // Check to see if FunctionVersion property is set
        internal bool IsSetFunctionVersion()
        {
            return this._functionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Specify the pagination token that's returned by a previous request to retrieve the
        /// next page of results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MasterRegion. 
        /// <para>
        /// For Lambda@Edge functions, the Amazon Web Services Region of the master function.
        /// For example, <code>us-east-1</code> filters the list of functions to include only
        /// Lambda@Edge functions replicated from a master function in US East (N. Virginia).
        /// If specified, you must set <code>FunctionVersion</code> to <code>ALL</code>.
        /// </para>
        /// </summary>
        public string MasterRegion
        {
            get { return this._masterRegion; }
            set { this._masterRegion = value; }
        }

        // Check to see if MasterRegion property is set
        internal bool IsSetMasterRegion()
        {
            return this._masterRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of functions to return in the response. Note that <code>ListFunctions</code>
        /// returns a maximum of 50 items in each response, even if you set the number higher.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}