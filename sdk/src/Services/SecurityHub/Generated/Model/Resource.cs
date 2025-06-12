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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A resource related to a finding.
    /// </summary>
    public partial class Resource
    {
        private string _applicationArn;
        private string _applicationName;
        private DataClassificationDetails _dataClassification;
        private ResourceDetails _details;
        private string _id;
        private Partition _partition;
        private string _region;
        private string _resourceRole;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the application that is related to a finding. 
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application that is related to a finding. 
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property DataClassification. 
        /// <para>
        /// Contains information about sensitive data that was detected on the resource.
        /// </para>
        /// </summary>
        public DataClassificationDetails DataClassification
        {
            get { return this._dataClassification; }
            set { this._dataClassification = value; }
        }

        // Check to see if DataClassification property is set
        internal bool IsSetDataClassification()
        {
            return this._dataClassification != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details about the resource related to a finding.
        /// </para>
        /// </summary>
        public ResourceDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The canonical identifier for the given resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The canonical Amazon Web Services partition name that the Region is assigned to.
        /// </para>
        /// </summary>
        public Partition Partition
        {
            get { return this._partition; }
            set { this._partition = value; }
        }

        // Check to see if Partition property is set
        internal bool IsSetPartition()
        {
            return this._partition != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The canonical Amazon Web Services external Region name where this resource is located.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 16.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// Identifies the role of the resource in the finding. A resource is either the actor
        /// or target of the finding activity,
        /// </para>
        /// </summary>
        public string ResourceRole
        {
            get { return this._resourceRole; }
            set { this._resourceRole = value; }
        }

        // Check to see if ResourceRole property is set
        internal bool IsSetResourceRole()
        {
            return this._resourceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed. Tags must follow <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html#tag-conventions">Amazon
        /// Web Services tag naming limits and requirements</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource that details are provided for. If possible, set <c>Type</c>
        /// to one of the supported resource types. For example, if the resource is an EC2 instance,
        /// then set <c>Type</c> to <c>AwsEc2Instance</c>.
        /// </para>
        ///  
        /// <para>
        /// If the resource does not match any of the provided types, then set <c>Type</c> to
        /// <c>Other</c>. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}