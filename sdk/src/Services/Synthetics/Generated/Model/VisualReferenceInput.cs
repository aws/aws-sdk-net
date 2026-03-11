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
    /// An object that specifies what screenshots to use as a baseline for visual monitoring
    /// by this canary. It can optionally also specify parts of the screenshots to ignore
    /// during the visual monitoring comparison.
    /// 
    ///  
    /// <para>
    /// Visual monitoring is supported only on canaries running the <b>syn-puppeteer-node-3.2</b>
    /// runtime or later. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Library_SyntheticsLogger_VisualTesting.html">
    /// Visual monitoring</a> and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Blueprints_VisualTesting.html">
    /// Visual monitoring blueprint</a> 
    /// </para>
    /// </summary>
    public partial class VisualReferenceInput
    {
        private string _baseCanaryRunId;
        private List<BaseScreenshot> _baseScreenshots = AWSConfigs.InitializeCollections ? new List<BaseScreenshot>() : null;
        private BrowserType _browserType;

        /// <summary>
        /// Gets and sets the property BaseCanaryRunId. 
        /// <para>
        /// Specifies which canary run to use the screenshots from as the baseline for future
        /// visual monitoring with this canary. Valid values are <c>nextrun</c> to use the screenshots
        /// from the next run after this update is made, <c>lastrun</c> to use the screenshots
        /// from the most recent run before this update was made, or the value of <c>Id</c> in
        /// the <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_CanaryRun.html">
        /// CanaryRun</a> from a run of this a canary in the past 31 days. If you specify the
        /// <c>Id</c> of a canary run older than 31 days, the operation returns a 400 validation
        /// exception error..
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// An array of screenshots that will be used as the baseline for visual monitoring in
        /// future runs of this canary. If there is a screenshot that you don't want to be used
        /// for visual monitoring, remove it from this array.
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