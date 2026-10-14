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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// An Firewall Manager applications list.
    /// </summary>
    public partial class AppsListData
    {
        /// <summary>
        /// Gets and sets the property AppsList. 
        /// <para>
        /// An array of applications in the Firewall Manager applications list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<App> AppsList { get; set; } = AWSConfigs.InitializeCollections ? new List<App>() : null;

        /// <summary>
        /// Checks to see if the AppsList property is set.
        /// </summary>
        internal bool IsSetAppsList() => this.AppsList != null && (this.AppsList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the Firewall Manager applications list was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time that the Firewall Manager applications list was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ListId. 
        /// <para>
        /// The ID of the Firewall Manager applications list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ListId { get; set; }

        /// <summary>
        /// Checks to see if the ListId property is set.
        /// </summary>
        internal bool IsSetListId() => this.ListId != null;

        /// <summary>
        /// Gets and sets the property ListName. 
        /// <para>
        /// The name of the Firewall Manager applications list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ListName { get; set; }

        /// <summary>
        /// Checks to see if the ListName property is set.
        /// </summary>
        internal bool IsSetListName() => this.ListName != null;

        /// <summary>
        /// Gets and sets the property ListUpdateToken. 
        /// <para>
        /// A unique identifier for each update to the list. When you update the list, the update
        /// token must match the token of the current version of the application list. You can
        /// retrieve the update token by getting the list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ListUpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the ListUpdateToken property is set.
        /// </summary>
        internal bool IsSetListUpdateToken() => this.ListUpdateToken != null;

        /// <summary>
        /// Gets and sets the property PreviousAppsList. 
        /// <para>
        /// A map of previous version numbers to their corresponding <c>App</c> object arrays.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<App>> PreviousAppsList { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<App>>() : null;

        /// <summary>
        /// Checks to see if the PreviousAppsList property is set.
        /// </summary>
        internal bool IsSetPreviousAppsList() => this.PreviousAppsList != null && (this.PreviousAppsList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
