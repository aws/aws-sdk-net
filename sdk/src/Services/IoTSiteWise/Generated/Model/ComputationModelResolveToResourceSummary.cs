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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A summary of the resource that a computation model resolves to.
    /// </summary>
    public partial class ComputationModelResolveToResourceSummary
    {
        private ResolveTo _resolveTo;

        /// <summary>
        /// Gets and sets the property ResolveTo.
        /// </summary>
        public ResolveTo ResolveTo
        {
            get { return this._resolveTo; }
            set { this._resolveTo = value; }
        }

        // Check to see if ResolveTo property is set
        internal bool IsSetResolveTo()
        {
            return this._resolveTo != null;
        }

    }
}