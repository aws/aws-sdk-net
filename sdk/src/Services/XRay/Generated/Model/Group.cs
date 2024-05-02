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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Details and metadata for a group.
    /// </summary>
    public partial class Group
    {
        private string _filterExpression;
        private string _groupARN;
        private string _groupName;
        private InsightsConfiguration _insightsConfiguration;

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filter expression defining the parameters to include traces.
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group generated based on the GroupName.
        /// </para>
        /// </summary>
        public string GroupARN
        {
            get { return this._groupARN; }
            set { this._groupARN = value; }
        }

        // Check to see if GroupARN property is set
        internal bool IsSetGroupARN()
        {
            return this._groupARN != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The unique case-sensitive name of the group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsConfiguration. 
        /// <para>
        /// The structure containing configurations related to insights.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The InsightsEnabled boolean can be set to true to enable insights for the group or
        /// false to disable insights for the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The NotificationsEnabled boolean can be set to true to enable insights notifications
        /// through Amazon EventBridge for the group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InsightsConfiguration InsightsConfiguration
        {
            get { return this._insightsConfiguration; }
            set { this._insightsConfiguration = value; }
        }

        // Check to see if InsightsConfiguration property is set
        internal bool IsSetInsightsConfiguration()
        {
            return this._insightsConfiguration != null;
        }

    }
}