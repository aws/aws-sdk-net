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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Information that describes the required tags for a given resource type.
    /// </summary>
    public partial class RequiredTag
    {
        private List<string> _cloudFormationResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _reportingTagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property CloudFormationResourceTypes. 
        /// <para>
        /// Describes the CloudFormation resource type assigned the required tag keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CloudFormationResourceTypes
        {
            get { return this._cloudFormationResourceTypes; }
            set { this._cloudFormationResourceTypes = value; }
        }

        // Check to see if CloudFormationResourceTypes property is set
        internal bool IsSetCloudFormationResourceTypes()
        {
            return this._cloudFormationResourceTypes != null && (this._cloudFormationResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportingTagKeys. 
        /// <para>
        /// These tag keys are marked as <c>required</c> in the <c>report_required_tag_for</c>
        /// block of the effective tag policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReportingTagKeys
        {
            get { return this._reportingTagKeys; }
            set { this._reportingTagKeys = value; }
        }

        // Check to see if ReportingTagKeys property is set
        internal bool IsSetReportingTagKeys()
        {
            return this._reportingTagKeys != null && (this._reportingTagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Describes the resource type for the required tag keys.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}