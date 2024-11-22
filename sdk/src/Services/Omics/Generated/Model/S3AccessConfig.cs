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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// S3 access configuration parameters.
    /// </summary>
    public partial class S3AccessConfig
    {
        private string _accessLogLocation;

        /// <summary>
        /// Gets and sets the property AccessLogLocation. 
        /// <para>
        /// Location of the access logs.
        /// </para>
        /// </summary>
        public string AccessLogLocation
        {
            get { return this._accessLogLocation; }
            set { this._accessLogLocation = value; }
        }

        // Check to see if AccessLogLocation property is set
        internal bool IsSetAccessLogLocation()
        {
            return this._accessLogLocation != null;
        }

    }
}