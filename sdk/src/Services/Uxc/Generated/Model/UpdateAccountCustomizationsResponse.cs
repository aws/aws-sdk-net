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
    /// This is the response object from the UpdateAccountCustomizations operation.
    /// </summary>
    public partial class UpdateAccountCustomizationsResponse : AmazonWebServiceResponse
    {
        private AccountColor _accountColor;
        private List<string> _visibleRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _visibleServices = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountColor. 
        /// <para>
        /// The current account color preference after the update.
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
        /// The current list of visible Region codes after the update.
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
        /// The current list of visible service identifiers after the update.
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