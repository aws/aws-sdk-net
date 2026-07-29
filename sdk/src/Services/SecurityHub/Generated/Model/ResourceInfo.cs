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
    /// Additional details about a resource that are specific to its category. For AI/ML resources
    /// and their host resources, this structure contains <c>AIDetails</c>.
    /// </summary>
    public partial class ResourceInfo
    {
        private AIDetails _aiDetails;

        /// <summary>
        /// Gets and sets the property AIDetails. 
        /// <para>
        /// Details that are specific to self-hosted AI resources and their host resources.
        /// </para>
        /// </summary>
        public AIDetails AIDetails
        {
            get { return this._aiDetails; }
            set { this._aiDetails = value; }
        }

        // Check to see if AIDetails property is set
        internal bool IsSetAIDetails()
        {
            return this._aiDetails != null;
        }

    }
}