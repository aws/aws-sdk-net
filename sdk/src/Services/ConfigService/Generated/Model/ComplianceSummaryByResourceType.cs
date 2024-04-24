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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The number of Amazon Web Services resources of a specific type that are compliant
    /// or noncompliant, up to a maximum of 100 for each.
    /// </summary>
    public partial class ComplianceSummaryByResourceType
    {
        private ComplianceSummary _complianceSummary;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ComplianceSummary. 
        /// <para>
        /// The number of Amazon Web Services resources that are compliant or noncompliant, up
        /// to a maximum of 100 for each.
        /// </para>
        /// </summary>
        public ComplianceSummary ComplianceSummary
        {
            get { return this._complianceSummary; }
            set { this._complianceSummary = value; }
        }

        // Check to see if ComplianceSummary property is set
        internal bool IsSetComplianceSummary()
        {
            return this._complianceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}