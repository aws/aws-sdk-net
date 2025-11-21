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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// If this canary performs visual monitoring by comparing screenshots, this structure
    /// contains the ID of the canary run that is used as the baseline for screenshots, and
    /// the coordinates of any parts of those screenshots that are ignored during visual monitoring
    /// comparison.
    /// 
    ///  
    /// <para>
    /// Visual monitoring is supported only on canaries running the <b>syn-puppeteer-node-3.2</b>
    /// runtime or later.
    /// </para>
    /// </summary>
    public partial class VisualReferenceOutput
    {
        private string _baseCanaryRunId;
        private List<BaseScreenshot> _baseScreenshots = AWSConfigs.InitializeCollections ? new List<BaseScreenshot>() : null;
        private BrowserType _browserType;

        /// <summary>
        /// Gets and sets the property BaseCanaryRunId. 
        /// <para>
        /// The ID of the canary run that produced the baseline screenshots that are used for
        /// visual monitoring comparisons by this canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string BaseCanaryRunId
        {
            get { return this._baseCanaryRunId; }
            set { this._baseCanaryRunId = value; }
        }

        // Check to see if BaseCanaryRunId property is set
        internal bool IsSetBaseCanaryRunId()
        {
            return this._baseCanaryRunId != null;
        }

        /// <summary>
        /// Gets and sets the property BaseScreenshots. 
        /// <para>
        /// An array of screenshots that are used as the baseline for comparisons during visual
        /// monitoring.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BaseScreenshot> BaseScreenshots
        {
            get { return this._baseScreenshots; }
            set { this._baseScreenshots = value; }
        }

        // Check to see if BaseScreenshots property is set
        internal bool IsSetBaseScreenshots()
        {
            return this._baseScreenshots != null && (this._baseScreenshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BrowserType. 
        /// <para>
        /// The browser type associated with this visual reference.
        /// </para>
        /// </summary>
        public BrowserType BrowserType
        {
            get { return this._browserType; }
            set { this._browserType = value; }
        }

        // Check to see if BrowserType property is set
        internal bool IsSetBrowserType()
        {
            return this._browserType != null;
        }

    }
}