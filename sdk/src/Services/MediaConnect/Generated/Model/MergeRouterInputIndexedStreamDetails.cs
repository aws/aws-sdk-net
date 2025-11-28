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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configuration details for an indexed stream in a merge router input setup.
    /// </summary>
    public partial class MergeRouterInputIndexedStreamDetails
    {
        private int? _sourceIndex;
        private string _sourceIpAddress;

        /// <summary>
        /// Gets and sets the property SourceIndex. 
        /// <para>
        /// The index number (0 or 1) assigned to this source in the merge configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SourceIndex
        {
            get { return this._sourceIndex; }
            set { this._sourceIndex = value; }
        }

        // Check to see if SourceIndex property is set
        internal bool IsSetSourceIndex()
        {
            return this._sourceIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIpAddress. 
        /// <para>
        /// The IP address of the source for this indexed stream in the merge setup.
        /// </para>
        /// </summary>
        public string SourceIpAddress
        {
            get { return this._sourceIpAddress; }
            set { this._sourceIpAddress = value; }
        }

        // Check to see if SourceIpAddress property is set
        internal bool IsSetSourceIpAddress()
        {
            return this._sourceIpAddress != null;
        }

    }
}