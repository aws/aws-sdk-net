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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A URL for the Amazon Web Services Systems Manager (Systems Manager) bucket where you
    /// want to store the results of this request.
    /// </summary>
    public partial class S3OutputUrl
    {
        private string _outputUrl;

        /// <summary>
        /// Gets and sets the property OutputUrl. 
        /// <para>
        /// A URL for an S3 bucket where you want to store the results of this request.
        /// </para>
        /// </summary>
        public string OutputUrl
        {
            get { return this._outputUrl; }
            set { this._outputUrl = value; }
        }

        // Check to see if OutputUrl property is set
        internal bool IsSetOutputUrl()
        {
            return this._outputUrl != null;
        }

    }
}