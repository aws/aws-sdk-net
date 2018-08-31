/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the ListLoggingConfigurations operation.
    /// </summary>
    public partial class ListLoggingConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<LoggingConfiguration> _loggingConfigurations = new List<LoggingConfiguration>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property LoggingConfigurations. 
        /// <para>
        /// An array of <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        public List<LoggingConfiguration> LoggingConfigurations
        {
            get { return this._loggingConfigurations; }
            set { this._loggingConfigurations = value; }
        }

        // Check to see if LoggingConfigurations property is set
        internal bool IsSetLoggingConfigurations()
        {
            return this._loggingConfigurations != null && this._loggingConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <code>LoggingConfigurations</code> than the number that you specified
        /// for <code>Limit</code> in the request, the response includes a <code>NextMarker</code>
        /// value. To list more <code>LoggingConfigurations</code>, submit another <code>ListLoggingConfigurations</code>
        /// request, and specify the <code>NextMarker</code> value from the response in the <code>NextMarker</code>
        /// value in the next request.
        /// </para>
        /// </summary>
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