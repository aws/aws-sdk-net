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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that specifies a relationship with another component type.
    /// </summary>
    public partial class Relationship
    {
        /// <summary>
        /// Gets and sets the property RelationshipType. 
        /// <para>
        /// The type of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelationshipType { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipType property is set.
        /// </summary>
        internal bool IsSetRelationshipType() => this.RelationshipType != null;

        /// <summary>
        /// Gets and sets the property TargetComponentTypeId. 
        /// <para>
        /// The ID of the target component type associated with this relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TargetComponentTypeId { get; set; }

        /// <summary>
        /// Checks to see if the TargetComponentTypeId property is set.
        /// </summary>
        internal bool IsSetTargetComponentTypeId() => this.TargetComponentTypeId != null;
    }
}
