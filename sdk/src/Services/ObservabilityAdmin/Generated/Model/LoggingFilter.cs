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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration that determines which WAF log records to keep or drop based on specified
    /// conditions.
    /// </summary>
    public partial class LoggingFilter
    {
        private FilterBehavior _defaultBehavior;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Gets and sets the property DefaultBehavior. 
        /// <para>
        ///  The default action (KEEP or DROP) for log records that don't match any filter conditions.
        /// 
        /// </para>
        /// </summary>
        public FilterBehavior DefaultBehavior
        {
            get { return this._defaultBehavior; }
            set { this._defaultBehavior = value; }
        }

        // Check to see if DefaultBehavior property is set
        internal bool IsSetDefaultBehavior()
        {
            return this._defaultBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  A list of filter conditions that determine log record handling behavior. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}