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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateDataTableAttribute operation.
    /// </summary>
    public partial class CreateDataTableAttributeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The unique identifier assigned to the created attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AttributeId { get; set; }

        /// <summary>
        /// Checks to see if the AttributeId property is set.
        /// </summary>
        internal bool IsSetAttributeId() => this.AttributeId != null;

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The lock version information for the data table and attribute, used for optimistic
        /// locking and versioning.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableLockVersion LockVersion { get; set; }

        /// <summary>
        /// Checks to see if the LockVersion property is set.
        /// </summary>
        internal bool IsSetLockVersion() => this.LockVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the created attribute since it also serves as the identifier. This could
        /// be different than the parameter passed in since it will be trimmed for whitespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
