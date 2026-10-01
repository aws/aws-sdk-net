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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The session logger resource.
    /// </summary>
    public partial class SessionLogger
    {
        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the session logger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEncryptionContext property is set.
        /// </summary>
        internal bool IsSetAdditionalEncryptionContext() => this.AdditionalEncryptionContext != null && (this.AdditionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// The associated portal ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPortalArns property is set.
        /// </summary>
        internal bool IsSetAssociatedPortalArns() => this.AssociatedPortalArns != null && (this.AssociatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the session logger resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The custom managed key of the session logger.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomerManagedKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedKey property is set.
        /// </summary>
        internal bool IsSetCustomerManagedKey() => this.CustomerManagedKey != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable display name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The filter that specifies which events to monitor.
        /// </para>
        /// </summary>
        public EventFilter EventFilter { get; set; }

        /// <summary>
        /// Checks to see if the EventFilter property is set.
        /// </summary>
        internal bool IsSetEventFilter() => this.EventFilter != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The configuration that specifies where logs are fowarded.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionLoggerArn. 
        /// <para>
        /// The ARN of the session logger resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SessionLoggerArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionLoggerArn property is set.
        /// </summary>
        internal bool IsSetSessionLoggerArn() => this.SessionLoggerArn != null;
    }
}
