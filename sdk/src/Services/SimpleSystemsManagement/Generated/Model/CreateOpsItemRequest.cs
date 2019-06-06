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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOpsItem operation.
    /// Creates a new OpsItem. You must have permission in AWS Identity and Access Management
    /// (IAM) to create a new OpsItem. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsItems-getting-started.html">Getting
    /// Started with OpsItems</a> in the <i>AWS Systems Manager User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Operations engineers and IT professionals use the Systems Manager OpsItems capability
    /// to view, investigate, and remediate operational issues impacting the performance and
    /// health of their AWS resources. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/OpsItems.html">AWS
    /// Systems Manager OpsItems</a> in the <i>AWS Systems Manager User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateOpsItemRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _description;
        private List<OpsItemNotification> _notifications = new List<OpsItemNotification>();
        private Dictionary<string, OpsItemDataValue> _operationalData = new Dictionary<string, OpsItemDataValue>();
        private int? _priority;
        private List<RelatedOpsItem> _relatedOpsItems = new List<RelatedOpsItem>();
        private string _source;
        private List<Tag> _tags = new List<Tag>();
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the OpsItem. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an SNS topic where notifications are sent when this
        /// OpsItem is edited or changed.
        /// </para>
        /// </summary>
        public List<OpsItemNotification> Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null && this._notifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperationalData. 
        /// <para>
        /// Operational data is custom data that provides useful reference details about the OpsItem.
        /// For example, you can specify log files, error strings, license keys, troubleshooting
        /// tips, or other relevant data. You enter operational data as key-value pairs. The key
        /// has a maximum length of 128 characters. The value has a maximum size of 20 KB.
        /// </para>
        ///  
        /// <para>
        /// This custom data is searchable, but with restrictions. For the <code>Searchable operational
        /// data</code> feature, all users with access to the OpsItem Overview page (as provided
        /// by the <a>DescribeOpsItems</a> API action) can view and search on the specified data.
        /// For the <code>Private operational data</code> feature, the data is only viewable by
        /// users who have access to the OpsItem (as provided by the <a>GetOpsItem</a> API action).
        /// </para>
        /// </summary>
        public Dictionary<string, OpsItemDataValue> OperationalData
        {
            get { return this._operationalData; }
            set { this._operationalData = value; }
        }

        // Check to see if OperationalData property is set
        internal bool IsSetOperationalData()
        {
            return this._operationalData != null && this._operationalData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The importance of this OpsItem in relation to other OpsItems in the system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedOpsItems. 
        /// <para>
        /// One or more OpsItems that share something in common with the current OpsItems. For
        /// example, related OpsItems can include OpsItems with similar error messages, impacted
        /// resources, or statuses for the impacted resource.
        /// </para>
        /// </summary>
        public List<RelatedOpsItem> RelatedOpsItems
        {
            get { return this._relatedOpsItems; }
            set { this._relatedOpsItems = value; }
        }

        // Check to see if RelatedOpsItems property is set
        internal bool IsSetRelatedOpsItems()
        {
            return this._relatedOpsItems != null && this._relatedOpsItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The origin of the OpsItem, such as Amazon EC2 or AWS Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag an OpsItem to identify the AWS resource or the type of issue. In this
        /// case, you could specify the following key name/value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=source,Value=EC2-instance</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=status,Value=stopped</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing OpsItem, use the <a>AddTagsToResource</a> action.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1000)]
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

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short heading that describes the nature of the OpsItem and the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}