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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the ListNotificationConfigurations operation.
    /// </summary>
    public partial class ListNotificationConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<NotificationConfigurationSummary> _notificationConfigurationList = AWSConfigs.InitializeCollections ? new List<NotificationConfigurationSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that can be used to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationConfigurationList. 
        /// <para>
        /// The list of notification configurations.
        /// </para>
        /// </summary>
        public List<NotificationConfigurationSummary> NotificationConfigurationList
        {
            get { return this._notificationConfigurationList; }
            set { this._notificationConfigurationList = value; }
        }

        // Check to see if NotificationConfigurationList property is set
        internal bool IsSetNotificationConfigurationList()
        {
            return this._notificationConfigurationList != null && (this._notificationConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}