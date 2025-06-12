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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Summary information about the assistant association.
    /// </summary>
    public partial class AssistantAssociationSummary
    {
        private string _assistantArn;
        private string _assistantAssociationArn;
        private string _assistantAssociationId;
        private string _assistantId;
        private AssistantAssociationOutputData _associationData;
        private AssociationType _associationType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssistantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Wisdom assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantArn
        {
            get { return this._assistantArn; }
            set { this._assistantArn = value; }
        }

        // Check to see if AssistantArn property is set
        internal bool IsSetAssistantArn()
        {
            return this._assistantArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the assistant association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantAssociationArn
        {
            get { return this._assistantAssociationArn; }
            set { this._assistantAssociationArn = value; }
        }

        // Check to see if AssistantAssociationArn property is set
        internal bool IsSetAssistantAssociationArn()
        {
            return this._assistantAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantAssociationId. 
        /// <para>
        /// The identifier of the assistant association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantAssociationId
        {
            get { return this._assistantAssociationId; }
            set { this._assistantAssociationId = value; }
        }

        // Check to see if AssistantAssociationId property is set
        internal bool IsSetAssistantAssociationId()
        {
            return this._assistantAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Wisdom assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationData. 
        /// <para>
        /// The association data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssistantAssociationOutputData AssociationData
        {
            get { return this._associationData; }
            set { this._associationData = value; }
        }

        // Check to see if AssociationData property is set
        internal bool IsSetAssociationData()
        {
            return this._associationData != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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

    }
}