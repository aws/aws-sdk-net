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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about the specified configurable setting for a directory.
    /// </summary>
    public partial class SettingEntry
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The valid range of values for the directory setting. These values depend on the <c>DataType</c>
        /// of your directory.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property AppliedValue. 
        /// <para>
        /// The value of the directory setting that is applied to the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AppliedValue { get; set; }

        /// <summary>
        /// Checks to see if the AppliedValue property is set.
        /// </summary>
        internal bool IsSetAppliedValue() => this.AppliedValue != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of a directory setting. This is used to define the <c>AllowedValues</c>
        /// of a setting. For example a data type can be <c>Boolean</c>, <c>DurationInSeconds</c>,
        /// or <c>Enum</c>.
        /// </para>
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property LastRequestedDateTime. 
        /// <para>
        /// The date and time when the request to update a directory setting was last submitted.
        /// </para>
        /// </summary>
        public DateTime? LastRequestedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRequestedDateTime property is set.
        /// </summary>
        internal bool IsSetLastRequestedDateTime() => this.LastRequestedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the directory setting was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the directory setting. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>TLS_1_0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestDetailedStatus. 
        /// <para>
        /// Details about the status of the request to update the directory setting. If the directory
        /// setting is deployed in more than one region, status is returned for the request in
        /// each region where the setting is deployed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestDetailedStatus { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestDetailedStatus property is set.
        /// </summary>
        internal bool IsSetRequestDetailedStatus() => this.RequestDetailedStatus != null && (this.RequestDetailedStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The overall status of the request to update the directory setting request. If the
        /// directory setting is deployed in more than one region, and the request fails in any
        /// region, the overall status is <c>Failed</c>.
        /// </para>
        /// </summary>
        public DirectoryConfigurationStatus RequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the RequestStatus property is set.
        /// </summary>
        internal bool IsSetRequestStatus() => this.RequestStatus != null;

        /// <summary>
        /// Gets and sets the property RequestStatusMessage. 
        /// <para>
        /// The last status message for the directory status request.
        /// </para>
        /// </summary>
        public string RequestStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the RequestStatusMessage property is set.
        /// </summary>
        internal bool IsSetRequestStatusMessage() => this.RequestStatusMessage != null;

        /// <summary>
        /// Gets and sets the property RequestedValue. 
        /// <para>
        /// The value that was last requested for the directory setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RequestedValue { get; set; }

        /// <summary>
        /// Checks to see if the RequestedValue property is set.
        /// </summary>
        internal bool IsSetRequestedValue() => this.RequestedValue != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type, or category, of a directory setting. Similar settings have the same type.
        /// For example, <c>Protocol</c>, <c>Cipher</c>, or <c>Certificate-Based Authentication</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
