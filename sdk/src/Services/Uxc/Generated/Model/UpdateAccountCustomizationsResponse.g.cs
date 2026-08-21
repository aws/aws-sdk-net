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

namespace Amazon.Uxc.Model
{
    /// <summary>
    /// This is the response object from the UpdateAccountCustomizations operation.
    /// </summary>
    public partial class UpdateAccountCustomizationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountColor. 
        /// <para>
        /// The current account color preference after the update.
        /// </para>
        /// </summary>
        public AccountColor AccountColor { get; set; }

        /// <summary>
        /// Checks to see if the AccountColor property is set.
        /// </summary>
        internal bool IsSetAccountColor() => this.AccountColor != null;

        /// <summary>
        /// Gets and sets the property VisibleRegions. 
        /// <para>
        /// The current list of visible Region codes after the update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> VisibleRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VisibleRegions property is set.
        /// </summary>
        internal bool IsSetVisibleRegions() => this.VisibleRegions != null && (this.VisibleRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VisibleServices. 
        /// <para>
        /// The current list of visible service identifiers after the update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 500)]
        public List<string> VisibleServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VisibleServices property is set.
        /// </summary>
        internal bool IsSetVisibleServices() => this.VisibleServices != null && (this.VisibleServices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
