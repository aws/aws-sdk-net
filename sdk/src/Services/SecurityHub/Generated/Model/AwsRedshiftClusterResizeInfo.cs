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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the resize operation for the cluster.
    /// </summary>
    public partial class AwsRedshiftClusterResizeInfo
    {
        private bool? _allowCancelResize;
        private string _resizeType;

        /// <summary>
        /// Gets and sets the property AllowCancelResize. 
        /// <para>
        /// Indicates whether the resize operation can be canceled.
        /// </para>
        /// </summary>
        public bool? AllowCancelResize
        {
            get { return this._allowCancelResize; }
            set { this._allowCancelResize = value; }
        }

        // Check to see if AllowCancelResize property is set
        internal bool IsSetAllowCancelResize()
        {
            return this._allowCancelResize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResizeType. 
        /// <para>
        /// The type of resize operation.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ClassicResize</c> 
        /// </para>
        /// </summary>
        public string ResizeType
        {
            get { return this._resizeType; }
            set { this._resizeType = value; }
        }

        // Check to see if ResizeType property is set
        internal bool IsSetResizeType()
        {
            return this._resizeType != null;
        }

    }
}