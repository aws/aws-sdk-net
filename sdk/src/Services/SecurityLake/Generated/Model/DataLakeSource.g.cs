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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Amazon Security Lake collects logs and events from supported Amazon Web Services services
    /// and custom sources. For the list of supported Amazon Web Services services, see the
    /// <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
    /// Security Lake User Guide</a>.
    /// </summary>
    public partial class DataLakeSource
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The ID of the Security Lake account for which logs are collected.
        /// </para>
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property EventClasses. 
        /// <para>
        /// The Open Cybersecurity Schema Framework (OCSF) event classes describes the type of
        /// data that the custom source will send to Security Lake. For the list of supported
        /// event classes, see <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/adding-custom-sources.html#ocsf-eventclass.html">Supported
        /// OCSF Event classes</a> in the Amazon Security Lake User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EventClasses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventClasses property is set.
        /// </summary>
        internal bool IsSetEventClasses() => this.EventClasses != null && (this.EventClasses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services services.
        /// </para>
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property SourceStatuses. 
        /// <para>
        /// The log status for the Security Lake account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataLakeSourceStatus> SourceStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakeSourceStatus>() : null;

        /// <summary>
        /// Checks to see if the SourceStatuses property is set.
        /// </summary>
        internal bool IsSetSourceStatuses() => this.SourceStatuses != null && (this.SourceStatuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
