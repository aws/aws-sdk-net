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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the ListLoggingConfigurations operation.
    /// </summary>
    public partial class ListLoggingConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<LoggingConfiguration> _loggingConfigurations = AWSConfigs.InitializeCollections ? new List<LoggingConfiguration>() : null;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property LoggingConfigurations. 
        /// <para>
        /// An array of <a>LoggingConfiguration</a> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoggingConfiguration> LoggingConfigurations
        {
            get { return this._loggingConfigurations; }
            set { this._loggingConfigurations = value; }
        }

        // Check to see if LoggingConfigurations property is set
        internal bool IsSetLoggingConfigurations()
        {
            return this._loggingConfigurations != null && (this._loggingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <c>LoggingConfigurations</c> than the number that you specified for
        /// <c>Limit</c> in the request, the response includes a <c>NextMarker</c> value. To list
        /// more <c>LoggingConfigurations</c>, submit another <c>ListLoggingConfigurations</c>
        /// request, and specify the <c>NextMarker</c> value from the response in the <c>NextMarker</c>
        /// value in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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

    }
}