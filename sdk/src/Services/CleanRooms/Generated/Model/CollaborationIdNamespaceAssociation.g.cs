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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Defines details for the collaboration ID namespace association.
    /// </summary>
    public partial class CollaborationIdNamespaceAssociation
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collaboration ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collaboration that contains the collaboration
        /// ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string CollaborationArn { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationArn property is set.
        /// </summary>
        internal bool IsSetCollaborationArn() => this.CollaborationArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique identifier of the collaboration that contains the collaboration ID namespace
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the collaboration ID namespace association was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The unique identifier of the Amazon Web Services account that created the collaboration
        /// ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the collaboration ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collaboration ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IdMappingConfig.
        /// </summary>
        public IdMappingConfig IdMappingConfig { get; set; }

        /// <summary>
        /// Checks to see if the IdMappingConfig property is set.
        /// </summary>
        internal bool IsSetIdMappingConfig() => this.IdMappingConfig != null;

        /// <summary>
        /// Gets and sets the property InputReferenceConfig. 
        /// <para>
        /// The input reference configuration that's necessary to create the collaboration ID
        /// namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdNamespaceAssociationInputReferenceConfig InputReferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputReferenceConfig property is set.
        /// </summary>
        internal bool IsSetInputReferenceConfig() => this.InputReferenceConfig != null;

        /// <summary>
        /// Gets and sets the property InputReferenceProperties. 
        /// <para>
        /// The input reference properties that are needed to create the collaboration ID namespace
        /// association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdNamespaceAssociationInputReferenceProperties InputReferenceProperties { get; set; }

        /// <summary>
        /// Checks to see if the InputReferenceProperties property is set.
        /// </summary>
        internal bool IsSetInputReferenceProperties() => this.InputReferenceProperties != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collaboration ID namespace association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the collaboration ID namespace was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
