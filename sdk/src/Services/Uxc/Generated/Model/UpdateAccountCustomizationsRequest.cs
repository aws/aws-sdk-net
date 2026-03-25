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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
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
    /// Container for the parameters to the UpdateAccountCustomizations operation.
    /// Updates one or more account customization settings. You can update account color,
    /// visible services, and visible Regions in a single request. Only the settings that
    /// you include in the request body are modified. Omitted settings remain unchanged. To
    /// reset a setting to its default behavior, set the value to <c>null</c> for visible
    /// Regions and visible services, or <c>none</c> for account color. This operation is
    /// idempotent.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>visibleServices</c> and <c>visibleRegions</c> settings control only the appearance
    /// of services and Regions in the Amazon Web Services Management Console. They do not
    /// restrict access through the CLI, SDKs, or other APIs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateAccountCustomizationsRequest : AmazonUxcRequest
    {
        private AccountColor _accountColor;
        private List<string> _visibleRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _visibleServices = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountColor. 
        /// <para>
        /// The account color preference to set. Set to <c>none</c> to reset to the default (no
        /// color).
        /// </para>
        /// </summary>
        public AccountColor AccountColor
        {
            get { return this._accountColor; }
            set { this._accountColor = value; }
        }

        // Check to see if AccountColor property is set
        internal bool IsSetAccountColor()
        {
            return this._accountColor != null;
        }

        /// <summary>
        /// Gets and sets the property VisibleRegions. 
        /// <para>
        /// The list of Amazon Web Services Region codes to make visible in the Amazon Web Services
        /// Management Console. Set to <c>null</c> to reset to the default, which makes all Regions
        /// visible. For a list of valid Region codes, see <a href="https://docs.aws.amazon.com/global-infrastructure/latest/regions/aws-regions.html">Amazon
        /// Web Services Regions</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> VisibleRegions
        {
            get { return this._visibleRegions; }
            set { this._visibleRegions = value; }
        }

        // Check to see if VisibleRegions property is set
        internal bool IsSetVisibleRegions()
        {
            return this._visibleRegions != null && (this._visibleRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VisibleServices. 
        /// <para>
        /// The list of Amazon Web Services service identifiers to make visible in the Amazon
        /// Web Services Management Console. Set to <c>null</c> to reset to the default, which
        /// makes all services visible. For valid service identifiers, call <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/APIReference/API_ListServices.html">ListServices</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> VisibleServices
        {
            get { return this._visibleServices; }
            set { this._visibleServices = value; }
        }

        // Check to see if VisibleServices property is set
        internal bool IsSetVisibleServices()
        {
            return this._visibleServices != null && (this._visibleServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}