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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the response details that are returned when querying about an asynchronous
    /// request.
    /// </summary>
    public partial class AsyncResponseDetails
    {
        private AsyncErrorDetails _errorDetails;
        private MultiRegionAccessPointsAsyncResponse _multiRegionAccessPointDetails;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Error details for an asynchronous request.
        /// </para>
        /// </summary>
        public AsyncErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionAccessPointDetails. 
        /// <para>
        /// The details for the Multi-Region Access Point.
        /// </para>
        /// </summary>
        public MultiRegionAccessPointsAsyncResponse MultiRegionAccessPointDetails
        {
            get { return this._multiRegionAccessPointDetails; }
            set { this._multiRegionAccessPointDetails = value; }
        }

        // Check to see if MultiRegionAccessPointDetails property is set
        internal bool IsSetMultiRegionAccessPointDetails()
        {
            return this._multiRegionAccessPointDetails != null;
        }

    }
}