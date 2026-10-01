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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about the suppression list preferences for your
    /// account or for a specific tenant.
    /// </summary>
    public partial class SuppressionOptions
    {
        /// <summary>
        /// Gets and sets the property SuppressedReasons. 
        /// <para>
        /// A list that contains the reasons that email addresses are automatically added to the
        /// suppression list for your account or for a specific tenant. This list can contain
        /// any or all of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> – Amazon SES adds an email address to the suppression list for your
        /// account or for a specific tenant when a message sent to that address results in a
        /// complaint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOUNCE</c> – Amazon SES adds an email address to the suppression list for your
        /// account or for a specific tenant when a message sent to that address results in a
        /// hard bounce.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuppressedReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SuppressedReasons property is set.
        /// </summary>
        internal bool IsSetSuppressedReasons() => this.SuppressedReasons != null && (this.SuppressedReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuppressionScope. 
        /// <para>
        /// The suppression scope for the configuration set. This overrides the tenant or account
        /// suppression scope for emails sent using this configuration set. Can be one of the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TENANT</c> – Use the tenant's suppression list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> – Use the account-level suppression list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SuppressionListScope SuppressionScope { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionScope property is set.
        /// </summary>
        internal bool IsSetSuppressionScope() => this.SuppressionScope != null;

        /// <summary>
        /// Gets and sets the property ValidationOptions.
        /// </summary>
        public SuppressionValidationOptions ValidationOptions { get; set; }

        /// <summary>
        /// Checks to see if the ValidationOptions property is set.
        /// </summary>
        internal bool IsSetValidationOptions() => this.ValidationOptions != null;
    }
}
