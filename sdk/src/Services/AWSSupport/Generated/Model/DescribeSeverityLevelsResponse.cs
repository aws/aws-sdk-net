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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The list of severity levels returned by the <a>DescribeSeverityLevels</a> operation.
    /// </summary>
    public partial class DescribeSeverityLevelsResponse : AmazonWebServiceResponse
    {
        private List<SeverityLevel> _severityLevels = AWSConfigs.InitializeCollections ? new List<SeverityLevel>() : null;

        /// <summary>
        /// Gets and sets the property SeverityLevels. 
        /// <para>
        /// The available severity levels for the support case. Available severity levels are
        /// defined by your service level agreement with Amazon Web Services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SeverityLevel> SeverityLevels
        {
            get { return this._severityLevels; }
            set { this._severityLevels = value; }
        }

        // Check to see if SeverityLevels property is set
        internal bool IsSetSeverityLevels()
        {
            return this._severityLevels != null && (this._severityLevels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}