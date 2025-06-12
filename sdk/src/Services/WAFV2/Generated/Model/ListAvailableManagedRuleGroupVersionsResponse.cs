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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the ListAvailableManagedRuleGroupVersions operation.
    /// </summary>
    public partial class ListAvailableManagedRuleGroupVersionsResponse : AmazonWebServiceResponse
    {
        private string _currentDefaultVersion;
        private string _nextMarker;
        private List<ManagedRuleGroupVersion> _versions = AWSConfigs.InitializeCollections ? new List<ManagedRuleGroupVersion>() : null;

        /// <summary>
        /// Gets and sets the property CurrentDefaultVersion. 
        /// <para>
        /// The name of the version that's currently set as the default. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CurrentDefaultVersion
        {
            get { return this._currentDefaultVersion; }
            set { this._currentDefaultVersion = value; }
        }

        // Check to see if CurrentDefaultVersion property is set
        internal bool IsSetCurrentDefaultVersion()
        {
            return this._currentDefaultVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        /// The versions that are currently available for the specified managed rule group. If
        /// you specified a <c>Limit</c> in your request, this might not be the full list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedRuleGroupVersion> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && (this._versions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}