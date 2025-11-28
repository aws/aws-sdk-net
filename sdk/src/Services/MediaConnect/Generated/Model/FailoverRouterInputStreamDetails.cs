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
    /// Configuration details for a failover router input that can automatically switch between
    /// two sources.
    /// </summary>
    public partial class FailoverRouterInputStreamDetails
    {
        private FailoverRouterInputIndexedStreamDetails _sourceIndexOneStreamDetails;
        private FailoverRouterInputIndexedStreamDetails _sourceIndexZeroStreamDetails;

        /// <summary>
        /// Gets and sets the property SourceIndexOneStreamDetails. 
        /// <para>
        /// Configuration details for the secondary source (index 1) in the failover setup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FailoverRouterInputIndexedStreamDetails SourceIndexOneStreamDetails
        {
            get { return this._sourceIndexOneStreamDetails; }
            set { this._sourceIndexOneStreamDetails = value; }
        }

        // Check to see if SourceIndexOneStreamDetails property is set
        internal bool IsSetSourceIndexOneStreamDetails()
        {
            return this._sourceIndexOneStreamDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIndexZeroStreamDetails. 
        /// <para>
        /// Configuration details for the primary source (index 0) in the failover setup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FailoverRouterInputIndexedStreamDetails SourceIndexZeroStreamDetails
        {
            get { return this._sourceIndexZeroStreamDetails; }
            set { this._sourceIndexZeroStreamDetails = value; }
        }

        // Check to see if SourceIndexZeroStreamDetails property is set
        internal bool IsSetSourceIndexZeroStreamDetails()
        {
            return this._sourceIndexZeroStreamDetails != null;
        }

    }
}