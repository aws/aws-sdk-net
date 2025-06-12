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
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a group which you can use to associate canaries with each other, including
    /// cross-Region canaries. Using groups can help you with managing and automating your
    /// canaries, and you can also view aggregated run results and statistics for all canaries
    /// in a group. 
    /// 
    ///  
    /// <para>
    /// Groups are global resources. When you create a group, it is replicated across Amazon
    /// Web Services Regions, and you can view it and add canaries to it from any Region.
    /// Although the group ARN format reflects the Region name where it was created, a group
    /// is not constrained to any Region. This means that you can put canaries from multiple
    /// Regions into the same group, and then use that group to view and manage all of those
    /// canaries in a single view.
    /// </para>
    ///  
    /// <para>
    /// Groups are supported in all Regions except the Regions that are disabled by default.
    /// For more information about these Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Enabling
    /// a Region</a>.
    /// </para>
    ///  
    /// <para>
    /// Each group can contain as many as 10 canaries. You can have as many as 20 groups in
    /// your account. Any single canary can be a member of up to 10 groups.
    /// </para>
    /// </summary>
    public partial class CreateGroupRequest : AmazonSyntheticsRequest
    {
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the group. It can include any Unicode characters.
        /// </para>
        ///  
        /// <para>
        /// The names for all groups in your account, across all Regions, must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the group. You can associate as many as
        /// 50 tags with a group.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only the
        /// resources that have certain tag values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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