/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Adds an application that is created from a resource group.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonApplicationInsightsRequest
    {
        private bool? _cweMonitorEnabled;
        private bool? _opsCenterEnabled;
        private string _opsItemSNSTopicArn;
        private string _resourceGroupName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CWEMonitorEnabled. 
        /// <para>
        ///  Indicates whether Application Insights can listen to CloudWatch events for the application
        /// resources, such as <code>instance terminated</code>, <code>failed deployment</code>,
        /// and others. 
        /// </para>
        /// </summary>
        public bool CWEMonitorEnabled
        {
            get { return this._cweMonitorEnabled.GetValueOrDefault(); }
            set { this._cweMonitorEnabled = value; }
        }

        // Check to see if CWEMonitorEnabled property is set
        internal bool IsSetCWEMonitorEnabled()
        {
            return this._cweMonitorEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  When set to <code>true</code>, creates opsItems for any problems detected on an application.
        /// 
        /// </para>
        /// </summary>
        public bool OpsCenterEnabled
        {
            get { return this._opsCenterEnabled.GetValueOrDefault(); }
            set { this._opsCenterEnabled = value; }
        }

        // Check to see if OpsCenterEnabled property is set
        internal bool IsSetOpsCenterEnabled()
        {
            return this._opsCenterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpsItemSNSTopicArn. 
        /// <para>
        ///  The SNS topic provided to Application Insights that is associated to the created
        /// opsItem. Allows you to receive notifications for updates to the opsItem. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=300)]
        public string OpsItemSNSTopicArn
        {
            get { return this._opsItemSNSTopicArn; }
            set { this._opsItemSNSTopicArn = value; }
        }

        // Check to see if OpsItemSNSTopicArn property is set
        internal bool IsSetOpsItemSNSTopicArn()
        {
            return this._opsItemSNSTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags to add to the application. tag key (<code>Key</code>) and an associated
        /// tag value (<code>Value</code>). The maximum length of a tag key is 128 characters.
        /// The maximum length of a tag value is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}