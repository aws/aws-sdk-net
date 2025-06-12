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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a group resource with a name and a filter expression.
    /// </summary>
    public partial class CreateGroupRequest : AmazonXRayRequest
    {
        private string _filterExpression;
        private string _groupName;
        private InsightsConfiguration _insightsConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filter expression defining criteria by which to group traces.
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The case-sensitive name of the new group. Default is a reserved name and names must
        /// be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property InsightsConfiguration. 
        /// <para>
        /// The structure containing configurations related to insights.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The InsightsEnabled boolean can be set to true to enable insights for the new group
        /// or false to disable insights for the new group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The NotificationsEnabled boolean can be set to true to enable insights notifications
        /// for the new group. Notifications may only be enabled on a group with InsightsEnabled
        /// set to true.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InsightsConfiguration InsightsConfiguration
        {
            get { return this._insightsConfiguration; }
            set { this._insightsConfiguration = value; }
        }

        // Check to see if InsightsConfiguration property is set
        internal bool IsSetInsightsConfiguration()
        {
            return this._insightsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains one or more tag keys and tag values to attach to an X-Ray group.
        /// For more information about ways to use tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of user-applied tags per resource: 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum tag key length: 128 Unicode characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum tag value length: 256 Unicode characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for key and value: a-z, A-Z, 0-9, space, and the following characters:
        /// _ . : / = + - and @
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't use <c>aws:</c> as a prefix for keys; it's reserved for Amazon Web Services
        /// use.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}