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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A construct update to apply during a mapping update operation.
    /// </summary>
    public partial class StartNetworkMigrationMappingUpdateConstruct
    {
        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The ID of the construct to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConstructID { get; set; }

        /// <summary>
        /// Checks to see if the ConstructID property is set.
        /// </summary>
        internal bool IsSetConstructID() => this.ConstructID != null;

        /// <summary>
        /// Gets and sets the property ConstructType. 
        /// <para>
        /// The type of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 24)]
        public string ConstructType { get; set; }

        /// <summary>
        /// Checks to see if the ConstructType property is set.
        /// </summary>
        internal bool IsSetConstructType() => this.ConstructType != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation to perform on the construct.
        /// </para>
        /// </summary>
        public OperationUnion Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment containing the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;
    }
}
