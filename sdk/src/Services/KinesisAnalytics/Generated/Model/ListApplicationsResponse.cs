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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListApplicationsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationSummary> _applicationSummaries = AWSConfigs.InitializeCollections ? new List<ApplicationSummary>() : null;
        private bool? _hasMoreApplications;

        /// <summary>
        /// Gets and sets the property ApplicationSummaries. 
        /// <para>
        /// List of <c>ApplicationSummary</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ApplicationSummary> ApplicationSummaries
        {
            get { return this._applicationSummaries; }
            set { this._applicationSummaries = value; }
        }

        // Check to see if ApplicationSummaries property is set
        internal bool IsSetApplicationSummaries()
        {
            return this._applicationSummaries != null && (this._applicationSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HasMoreApplications. 
        /// <para>
        /// Returns true if there are more applications to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? HasMoreApplications
        {
            get { return this._hasMoreApplications; }
            set { this._hasMoreApplications = value; }
        }

        // Check to see if HasMoreApplications property is set
        internal bool IsSetHasMoreApplications()
        {
            return this._hasMoreApplications.HasValue; 
        }

    }
}