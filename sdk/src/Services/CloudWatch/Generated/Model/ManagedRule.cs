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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Contains the information that's required to enable a managed Contributor Insights
    /// rule for an Amazon Web Services resource.
    /// </summary>
    public partial class ManagedRule
    {
        private string _resourceARN;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        ///  The ARN of an Amazon Web Services resource that has managed Contributor Insights
        /// rules. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of key-value pairs that you can associate with a managed Contributor Insights
        /// rule. You can associate as many as 50 tags with a rule. Tags can help you organize
        /// and categorize your resources. You also can use them to scope user permissions by
        /// granting a user permission to access or change only the resources that have certain
        /// tag values. To associate tags with a rule, you must have the <c>cloudwatch:TagResource</c>
        /// permission in addition to the <c>cloudwatch:PutInsightRule</c> permission. If you
        /// are using this operation to update an existing Contributor Insights rule, any tags
        /// that you specify in this parameter are ignored. To change the tags of an existing
        /// rule, use <c>TagResource</c>. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  The template name for the managed Contributor Insights rule, as returned by <c>ListManagedInsightRules</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}